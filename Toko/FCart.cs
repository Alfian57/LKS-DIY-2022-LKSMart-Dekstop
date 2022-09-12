using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Toko
{
    public partial class FCart : Form
    {
        LKSMartDataContext db;
        Dictionary<int, string> paymentList = new Dictionary<int, string>();
        public int newQty { get; set; }
        public FCart()
        {
            InitializeComponent();
        }

        private void FCart_Load(object sender, EventArgs e)
        {
            db = new LKSMartDataContext();
            loadData();

            dataGridView1.RowHeadersVisible = false;

            //PAYMENT
            var payments = from p in db.PaymentTypes
                          where p.deleted_at == null
                          select p;

            foreach (var payment in payments)
            {
                paymentList.Add(payment.id, payment.name);
                cbPayment.Items.Add(payment.name);
            }
            cbPayment.SelectedIndex = 0;

            calculateTotal();
        }

        private void loadData()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Toko\images\products\";

            Dictionary<int, int> cart = Helper.Helper.Cart;

            dataGridView1.Rows.Clear();
            foreach (var item in cart)
            {
                int index = dataGridView1.Rows.Add();

                var product = (from p in db.Products
                               where p.id == item.Key
                               select p).SingleOrDefault();

                Image productImage = Image.FromFile(path + "not_available.png");

                if (product.image_name != null)
                {
                    if (File.Exists(path + product.image_name))
                    {
                        productImage = Image.FromFile(path + product.image_name);
                    }
                }

                dataGridView1.Rows[index].Cells[0].Value = product.id;
                dataGridView1.Rows[index].Cells[1].Value = productImage;
                dataGridView1.Rows[index].Cells[2].Value = product.name;
                dataGridView1.Rows[index].Cells[3].Value = product.price;
                dataGridView1.Rows[index].Cells[4].Value = item.Value;
            }
        }

        private void cbUsePoint_CheckedChanged(object sender, EventArgs e)
        {
            Customer customer = Helper.Helper.Customer;
            if (customer.point == 0 && cbUsePoint.Checked)
            {
                MessageBox.Show("You Don't Have Point", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbUsePoint.Checked = false;
            }
            calculateTotal();
        }

        private void calculateTotal()
        {
            Customer currentCustomer = Helper.Helper.Customer;

            decimal subTotal = 0;

            Dictionary<int, int> cart = Helper.Helper.Cart;

            foreach (var item in cart)
            {

                var product = (from p in db.Products
                               where p.id == item.Key
                               select p).SingleOrDefault();

                subTotal += product.price * item.Value;
                
            }

            lblSubTotal.Text = subTotal.ToString();
            lblPlatformFee.Text = (subTotal * 5 / 100).ToString();
            lblTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) + Convert.ToDecimal(lblPlatformFee.Text)).ToString();
            lblTotal2.Text = (Convert.ToDecimal(lblSubTotal.Text) + Convert.ToDecimal(lblPlatformFee.Text)).ToString();

            if (cbUsePoint.Checked)
            {
                lblPoint.Text = currentCustomer.point.ToString();
            } else
            {
                lblPoint.Text = "0";
            }


            lblPay.Text = (Convert.ToDecimal(lblTotal.Text) - Convert.ToDecimal(lblPoint.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FMain().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DELETE
            if (e.ColumnIndex == 6)
            {
                if (MessageBox.Show("Are you want to Delete this Product ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Helper.Helper.deleteCartAt(int.Parse(id));
                    loadData();
                    calculateTotal();
                }
            }

            //EDIT
            if (e.ColumnIndex == 5)
            {
                string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string qty = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                FAddToCart f = new FAddToCart();
                f.IsEditCart = true;
                f.ProductId = int.Parse(id);
                f.Count = int.Parse(qty);
                f.ShowDialog();
                loadData();
                calculateTotal();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> cart = Helper.Helper.Cart;

            if (cart.Count == 0)
            {
                if (MessageBox.Show("Cart Still Empty." + Environment.NewLine + "Are you Want to Add Product ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new FShop().Show();
                    this.Hide();
                }
                return;
            }

            FPayment f = new FPayment();
            f.PaymentTypeName = cbPayment.Text;
            f.PaymentTypeId = paymentList.FirstOrDefault(x => x.Value == cbPayment.Text).Key;
            f.SubTotal = Convert.ToDecimal(lblSubTotal.Text);
            f.PointUsed = Convert.ToInt32(lblPoint.Text);
            if (cbUsePoint.Checked)
            {
                string point = "-" + lblPoint.Text;
                f.PointGained = Convert.ToInt32(point);
            } else
            {
                decimal data = Convert.ToDecimal(lblSubTotal.Text);
                f.PointGained = Decimal.ToInt32(data) * 20 / 100;
            }
            f.Show();
            this.Hide();
        }
    }
}

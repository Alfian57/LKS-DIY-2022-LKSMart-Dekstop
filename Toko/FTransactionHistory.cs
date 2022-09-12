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
    public partial class FTransactionHistory : Form
    {
        LKSMartDataContext db;
        public FTransactionHistory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FMain().Show();
            this.Hide();
        }

        private void FTransactionHistory_Load(object sender, EventArgs e)
        {
            db = new LKSMartDataContext();
            Customer customer = Helper.Helper.Customer;

            var transanctions = from h in db.HeaderTransactions
                                join d in db.DetailTransactions
                                on h.id equals d.header_transaction_id
                                join p in db.PointHistories
                                on h.id equals p.header_transaction_id
                                where h.deleted_at == null &&
                                h.customer_id == customer.id
                                select new
                                {
                                    Id = h.id,
                                    Date = h.datetime,
                                    TotalPayment = h.sub_total,
                                    PointGained = p.point_gained,
                                    PointDeducted = p.point_deducted,
                                    PaymentCode = h.payment_code
                                };

            transanctions = transanctions.Distinct();

            dataGridView2.RowHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

            foreach (var transaction in transanctions)
            {
                int index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells[0].Value = transaction.Id; 
                dataGridView1.Rows[index].Cells[1].Value = transaction.Date; 
                dataGridView1.Rows[index].Cells[2].Value = transaction.TotalPayment;

                if (transaction.PointGained != 0)
                {
                    dataGridView1.Rows[index].Cells[3].Value = transaction.PointDeducted;
                } else
                {
                    dataGridView1.Rows[index].Cells[3].Value = transaction.PointGained;
                }

                dataGridView1.Rows[index].Cells[4].Value = transaction.PaymentCode; 
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Toko\images\products\";

            string id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var transactions = from p in db.Products
                               join d in db.DetailTransactions
                               on p.id equals d.product_id
                              where d.header_transaction_id == Convert.ToInt32(id)
                              select new
                              {
                                  ProductImage = p.image_name,
                                  Name = p.name,
                                  Price = p.price,
                                  Qty = d.quantity
                              };

            dataGridView2.Rows.Clear();
            foreach (var transaction in transactions)
            {
                int index = dataGridView2.Rows.Add();

                Image productImage = Image.FromFile(path + "not_available.png");

                if (transaction.ProductImage!= null)
                {
                    if (File.Exists(path + transaction.ProductImage))
                    {
                        productImage = Image.FromFile(path + transaction.ProductImage);
                    }
                }

                dataGridView2.Rows[index].Cells[0].Value = productImage;
                dataGridView2.Rows[index].Cells[1].Value = transaction.Name;
                dataGridView2.Rows[index].Cells[2].Value = transaction.Price;
                dataGridView2.Rows[index].Cells[3].Value = transaction.Qty;
            }
        }
    }
}

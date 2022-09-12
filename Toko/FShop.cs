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
    public partial class FShop : Form
    {
        public FShop()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.FullName + @"\images\products\";

            LKSMartDataContext db = new LKSMartDataContext();

            var products = from p in db.Products
                          where p.deleted_at == null &&
                          p.stock != 0
                          select new
                          {
                              Id = p.id,
                              ImageName = p.image_name,
                              Name = p.name,
                              Price = p.price,
                              Stock = p.stock
                          };

            if (txtKey.Text != "")
            {
                products = products.Where(e => e.Name.Contains(txtKey.Text));
            }

            if (txtMin.Text != "")
            {
                if (int.TryParse(txtMin.Text, out var min))
                {
                    products = products.Where(e => e.Price >= min);
                } else
                {
                    MessageBox.Show("Please Insert a Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMin.Text = "";
                }
            }

            if (txtMax.Text != "")
            {
                if (int.TryParse(txtMax.Text, out var max))
                {
                    products = products.Where(e => e.Price <= max);
                }
                else
                {
                    MessageBox.Show("Please Insert a Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMax.Text = "";
                }
            }

            dataGridView1.Rows.Clear();
            foreach (var product in products)
            {
                int index = dataGridView1.Rows.Add();

                Image productImage = Image.FromFile(path + "not_available.png");

                if (product.ImageName != null)
                {
                    if (File.Exists(path + product.ImageName))
                    {
                        productImage = Image.FromFile(path + product.ImageName);
                    }
                }

                dataGridView1.Rows[index].Cells[0].Value = product.Id;
                dataGridView1.Rows[index].Cells[1].Value = productImage;
                dataGridView1.Rows[index].Cells[2].Value = product.Name;
                dataGridView1.Rows[index].Cells[3].Value = product.Price;
                dataGridView1.Rows[index].Cells[4].Value = product.Stock;
            }
        }

        private void FShop_Load(object sender, EventArgs e)
        {            
            loadData();

            DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
            addButton.Text = "Add To Cart";
            addButton.HeaderText = "Action";
            addButton.UseColumnTextForButtonValue = true;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns.Add(addButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FMain().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                FAddToCart f = new FAddToCart();
                int id = (int) dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                f.ProductId = id;
                f.ShowDialog();
            }
        }
    }
}

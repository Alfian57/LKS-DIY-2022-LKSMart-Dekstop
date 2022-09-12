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
    public partial class FAddToCart : Form
    {
        public int ProductId { get; set; }
        public bool IsEditCart { get; set; } = false;
        public int Count { get; set; } = 1;
        Product product;
        public FAddToCart()
        {
            InitializeComponent();
        }

        private void FAddToCart_Load(object sender, EventArgs e)
        {
            LKSMartDataContext db = new LKSMartDataContext();

            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Toko\images\products\";

            product = (from p in db.Products
                           where p.id == ProductId
                           select p).SingleOrDefault();

            if (product.image_name != null)
            {
                string imagePath = path + product.image_name;
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(path + "not_available.png");
                }
            }
            else
            {
                pictureBox1.Image = Image.FromFile(path + "not_available.png");
            }

            string desc = "Name:" + product.name + Environment.NewLine +
                "Price:" + product.price + Environment.NewLine +
                "Stock:" + product.stock;
            textBox1.Text = desc;
            txtCount.Text = Count.ToString();
            txtName.Text = product.name;
            txtPrice.Text = product.price.ToString();
            
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (Count > 1)
            {
                Count--;
                txtCount.Text = Count.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Count < product.stock)
            {
                Count++;
                txtCount.Text = Count.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsEditCart)
            {
                Helper.Helper.editQtyCartAt(ProductId, Count);
            } else
            {
                Helper.Helper.addCart(ProductId, Count);
                MessageBox.Show("Product Added To Cart", "Add to Cart", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            this.Close();
        }
    }
}

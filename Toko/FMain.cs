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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            Customer customer = Helper.Helper.Customer;

            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Toko\images\profile_pictures\";

            if (customer.name != null)
            {
                txtWelcome.Text = "Welcome, " + customer.name + "!";
            }
            
            if (customer.profile_image_name != null)
            {
                string imagePath = path + customer.profile_image_name;
                if (File.Exists(imagePath)) {
                    pbAvatar.Image = Image.FromFile(imagePath);
                }else
                {
                    pbAvatar.Image = Image.FromFile(path + "default_profile_picture.png");
                }
            }else
            {
                pbAvatar.Image = Image.FromFile(path + "default_profile_picture.png");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Logout ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new FLogin().Show();
                this.Hide();
                Helper.Helper.Customer = null;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("dd MMMM yyyy, HH:mm:ss");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new FProfile().Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new FShop().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new FTransactionHistory().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new FPointHistory().Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new FCart().Show();
            this.Hide();
        }
    }
}

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
using System.Diagnostics;

namespace Toko
{
    public partial class FProfile : Form
    {
        LKSMartDataContext db;
        string imagePath;
        Image cusImage = null;
        public FProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FMain().Show();
            this.Hide();
        }

        private void FProfile_Load(object sender, EventArgs e)
        {
            db = new LKSMartDataContext();
            Customer customer = Helper.Helper.Customer;
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Toko\images\profile_pictures\";

            txtName.Text = customer.name;
            txtPhoneNum.Text = customer.phone_number;
            txtEmail.Text = customer.email;
            txtPIN.Text = customer.pin_number;
            txtAddress.Text = customer.address;
            DateTime dateOfBirth = Convert.ToDateTime(customer.date_of_birth);
            date.Value = dateOfBirth;

            if (customer.gender == "Male")
            {
                cbGender.SelectedIndex = 0;
            } else {
                cbGender.SelectedIndex = 1;
            }

            cusImage = Image.FromFile(path + "default_profile_picture.png");
            if (customer.profile_image_name != null)
            {
                string imagePath = path + customer.profile_image_name;
                if (File.Exists(imagePath))
                {
                    cusImage = Image.FromFile(imagePath);
                }
            }
            pbAvatar.Invoke((MethodInvoker)delegate { pbAvatar.Image = cusImage; });
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                lblName.Visible = true;
                lblName.Text = "Field Still Blank";
                return;
            }

            Customer CurrentCustomer = Helper.Helper.Customer;

            var customer = (from c in db.Customers
                           where c.id == CurrentCustomer.id
                           select c).SingleOrDefault();

            customer.name = txtName.Text;

            db.SubmitChanges();
            Helper.Helper.Customer = customer;

            MessageBox.Show("Name Updated", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblName.Visible = false;
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text.Trim() == "")
            {
                lblPIN.Visible = true;
                lblPIN.Text = "Field Still Blank";
                return;
            }
            if (!int.TryParse(txtPIN.Text, out int value))
            {
                lblPIN.Visible = true;
                lblPIN.Text = "PIN Must Be Numeric";
                return;
            }
            if (txtPIN.Text.Length != 6)
            {
                lblPIN.Visible = true;
                lblPIN.Text = "PIN Must Be 6 Digits";
                return;
            }

            Customer CurrentCustomer = Helper.Helper.Customer;

            var customer = (from c in db.Customers
                            where c.id == CurrentCustomer.id
                            select c).SingleOrDefault();

            customer.pin_number = txtPIN.Text;

            db.SubmitChanges();
            Helper.Helper.Customer = customer;

            MessageBox.Show("PIN Updated", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            Customer CurrentCustomer = Helper.Helper.Customer;

            var customer = (from c in db.Customers
                            where c.id == CurrentCustomer.id
                            select c).SingleOrDefault();

            customer.address = txtAddress.Text;

            db.SubmitChanges();
            Helper.Helper.Customer = customer;

            MessageBox.Show("Address Updated", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGender_Click(object sender, EventArgs e)
        {
            Customer CurrentCustomer = Helper.Helper.Customer;
            string gender = null;

            if (cbGender.SelectedIndex == 0)
            {
                gender = "Male";
            } else
            {
                gender = "Female";
            }

            var customer = (from c in db.Customers
                            where c.id == CurrentCustomer.id
                            select c).SingleOrDefault();

            customer.gender = gender;

            db.SubmitChanges();
            Helper.Helper.Customer = customer;

            MessageBox.Show("Gender Updated", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            Customer CurrentCustomer = Helper.Helper.Customer;

            var customer = (from c in db.Customers
                            where c.id == CurrentCustomer.id
                            select c).SingleOrDefault();

            customer.date_of_birth = date.Value;

            db.SubmitChanges();
            Helper.Helper.Customer = customer;

            MessageBox.Show("Date Of Birth Updated", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblDate.Visible = false;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Customer CurrentCustomer = Helper.Helper.Customer;
            string workingDirectory = Environment.CurrentDirectory;
            string path = Directory.GetParent(workingDirectory).Parent.Parent.FullName + @"\Toko\images\profile_pictures\";


            var customer = (from c in db.Customers
                            where c.id == CurrentCustomer.id
                            select c).SingleOrDefault();

            cusImage.Dispose();
            try
            {
                if (File.Exists(path + CurrentCustomer.profile_image_name) || CurrentCustomer.profile_image_name == null)
                {
                    if (File.Exists(imagePath))
                    {
                        if (CurrentCustomer.profile_image_name != null)
                        {
                            File.Delete(path + CurrentCustomer.profile_image_name);
                        }
                        File.Copy(imagePath, path + CurrentCustomer.id + ".png");

                        customer.profile_image_name = CurrentCustomer.id + ".png";
                        db.SubmitChanges();
                        Helper.Helper.Customer = customer;
                        MessageBox.Show("Image Updated", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Image Failed To Update", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Filter = "Files | *.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFile.FileName;
                pbAvatar.Image = Image.FromFile(openFile.FileName);
            }
        }
    }
}

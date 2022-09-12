using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmailOrPhone.Text.Trim() == "" || txtPin.Text.Trim() == "") 
            {
                MessageBox.Show("Field Still Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LKSMartDataContext db = new LKSMartDataContext();

            string phoneNum = txtEmailOrPhone.Text;
            if (Int64.TryParse(phoneNum, out var data))
            {
                phoneNum = phoneNum.Insert(1, "-").Insert(5, "-").Insert(9 ,"-");
            }

            var customer = (from c in db.Customers
                           where c.email == txtEmailOrPhone.Text ||
                           c.phone_number == phoneNum &&
                           c.deleted_at == null
                           select c).SingleOrDefault();

            if (customer != null)
            {
                if (customer.pin_number == txtPin.Text)
                {
                    Helper.Helper.Customer = customer;
                    new FMain().Show();
                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("User Not Found", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

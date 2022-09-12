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
    public partial class FPointHistory : Form
    {
        public FPointHistory()
        {
            InitializeComponent();
        }

        private void FPointHistory_Load(object sender, EventArgs e)
        {
            LKSMartDataContext db = new LKSMartDataContext();
            Customer customer = Helper.Helper.Customer;

            lblPoint.Text = customer.point.ToString();

            var points = from p in db.PointHistories
                        join h in db.HeaderTransactions
                        on p.header_transaction_id equals h.id
                        where p.deleted_at == null
                        select new
                        {
                            Date = h.datetime,
                            PaymentCode = h.payment_code,
                            PointGained = p.point_gained,
                            PointBefore = p.point_before,
                            PointAfter = p.point_after
                        };

            dataGridView1.RowHeadersVisible = false;
            foreach (var point in points)
            {
                int index = dataGridView1.Rows.Add();

                dataGridView1.Rows[index].Cells[0].Value = point.Date;
                dataGridView1.Rows[index].Cells[1].Value = point.PaymentCode;
                dataGridView1.Rows[index].Cells[2].Value = point.PointGained;
                dataGridView1.Rows[index].Cells[3].Value = point.PointBefore;
                dataGridView1.Rows[index].Cells[4].Value = point.PointAfter;

                if (point.PointGained < 0)
                {
                    dataGridView1.Rows[index].Cells[2].Style.ForeColor = Color.Red;
                } else if (point.PointGained > 0)
                {
                    dataGridView1.Rows[index].Cells[2].Style.ForeColor = Color.Green;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FMain().Show();
            this.Hide();
        }
    }
}

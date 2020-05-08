using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Driver : Form
    {
        Controller controllerObj;
        public Driver()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void pay_click(object sender, EventArgs e)
        {
            int result = controllerObj.AddPaidMoney(Convert.ToInt32(textBox1.Text));
            if (result > 0)
                MessageBox.Show("Paid Money Added Successfully");
            else
                MessageBox.Show("Failed To Add Paid Money");
        }

        private void get_reserved_seats_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetReservedSeats(Convert.ToInt32(textBox3.Text));
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }
    }
}

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
    public partial class Marketing : Form
    {
        Controller controllerObj;
        public Marketing()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void get_reserved_seats_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetReservedSeats(Convert.ToInt32(textBox3.Text));
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void get_customer_data_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetCustomerData(Convert.ToInt32(textBox2.Text));
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void get_track_data_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetTrackData(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}

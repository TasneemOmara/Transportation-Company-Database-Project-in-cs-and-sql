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
            DataTable dt = controllerObj.SelectTracksID();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            DataTable dt2 = controllerObj.SelectBussesNum();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Number";
            comboBox2.ValueMember = "Number";
        }

        private void get_reserved_seats_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetReservedSeats(Convert.ToInt32(comboBox2.SelectedValue));
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
            DataTable dt = controllerObj.GetTrackData(Convert.ToInt32(comboBox1.SelectedValue));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login func = new Login();
            func.Show(this);
        }
    }
}

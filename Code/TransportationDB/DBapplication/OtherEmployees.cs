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
    public partial class OtherEmployees : Form
    {
        Controller controllerObj;
        public OtherEmployees()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void get_departure_time_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDepartureTime(Convert.ToInt32(textBox1.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void get_arrival_time_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetStationArrivalTime(textBox2.Text) ;
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
            
        }

        private void get_customers_click(object sender, EventArgs e)
        {
            int radio = 2;
            if (Txt_MoreThan.Checked)
            {
                radio = 1;
            }
            else if (Txt_FewerThan.Checked)
            {
                radio = 3;
            }
            else if (Txt_EqualTo.Checked)
            {
                radio = 2;
            }
            else
            {
                MessageBox.Show("Please Select A Radio Button");
            }
            DataTable dt = controllerObj.GetCustomerDataWithFrequency(Convert.ToInt32(textBox3.Text), radio);
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void get_employee_data_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetEmployeeData(Convert.ToString(textBox4.Text));
            dataGridView4.DataSource = dt;
            dataGridView4.Refresh();
        }

        private void OtherEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}

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
            DataTable dt = controllerObj.SelectTracksID();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ID";
            comboBox1.ValueMember = "ID";
            
        }

        private void get_departure_time_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDepartureTime(Convert.ToInt32(comboBox1.SelectedValue));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = controllerObj.SelectStations(Convert.ToInt32(comboBox1.SelectedValue));
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Location";
            comboBox2.ValueMember = "Location";
            comboBox2.Refresh();
        }

        private void get_arrival_time_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetStationArrivalTime(Convert.ToString(comboBox2.SelectedValue)) ;
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login func = new Login();
            func.Show(this);
        }
    }
}

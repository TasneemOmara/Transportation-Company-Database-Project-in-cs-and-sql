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
            DateTime dt = DateTime.Now;
            int month = Convert.ToInt32(dt.Month);
            int result = controllerObj.AddPaidMoney(Convert.ToDecimal(textBox1.Text) , month);
            if (result > 0)
                MessageBox.Show("Paid Money Added Successfully");
            else
                MessageBox.Show("Failed To Add Paid Money");
        }

        private void get_reserved_seats_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetReservedSeatsByName(Convert.ToString(textBox2.Text), Convert.ToString(textBox4.Text));
            dataGridView3.DataSource = dt;
            dataGridView3.Refresh();
        }

        private void Driver_Load(object sender, EventArgs e)
        {

        }

        private void get_my_schedule_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetDepartureByName(Convert.ToString(textBox2.Text), Convert.ToString(textBox4.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = controllerObj.GetScheduleByName(Convert.ToString(textBox2.Text), Convert.ToString(textBox4.Text));
            dataGridView2.DataSource = dt2;
            dataGridView2.Refresh();
        }

        private void check_boarding_pass_click(object sender, EventArgs e)
        {
            DataTable result = controllerObj.CheckBoardingPass(Convert.ToInt32(textBox5.Text) , Convert.ToString(textBox2.Text), Convert.ToString(textBox4.Text));
            //MessageBox.Show(result.ToString());
            //Equals(Convert.ToInt32(textBox5.Text)
            if (result == null)
                MessageBox.Show("Worng Boarding Pass - Do Not Allow Customer To Enter the Bus");
            else
                MessageBox.Show("Correct Boarding Pass - Allow Customer To Enter the Bus");


        }
    }
}

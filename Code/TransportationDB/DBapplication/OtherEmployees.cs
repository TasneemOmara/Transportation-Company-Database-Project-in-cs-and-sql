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

        }
    }
}

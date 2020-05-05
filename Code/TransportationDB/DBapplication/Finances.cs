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
    public partial class Finances : Form
    {
        Controller controllerObj;
        public Finances()
        {
            InitializeComponent();
            controllerObj = new Controller();
            //DataTable dt = controllerObj.SelectDepLoc();
            //comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Month";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Expenses_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Click(object sender, EventArgs e)
        {

        }

        private void Profit_Click(object sender, EventArgs e)
        {

        }
    }
}

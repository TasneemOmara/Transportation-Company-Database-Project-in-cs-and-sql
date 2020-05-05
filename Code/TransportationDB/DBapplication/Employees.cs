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
    public partial class Employees : Form
    {
        Controller controllerObj;
        public Employees()
        {
            InitializeComponent();
            comboBox1_Dep.DisplayMember  = "Department";
            comboBox2_SSSN.DisplayMember = "Manager SSN";
            comboBox3_update_SSN.DisplayMember = "Employee SSN";
            comboBox4_delete_SSN.DisplayMember = "Employee SSN";
        }

        private void EmployeesInfo_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1_SSN.Text = "";
            textBox2_FN.Text = "";
            textBox3_LN.Text = "";
            textBox4_Salary.Text = "";
            textBox5_gender.Text = "";
            textBox6_address.Text = "";
            comboBox1_Dep.DisplayMember = "Department";
            comboBox2_SSSN.DisplayMember = "Manager SSN";
            comboBox3_update_SSN.DisplayMember = "Employee SSN";
            comboBox4_delete_SSN.DisplayMember = "Employee SSN";
        }
    }
}

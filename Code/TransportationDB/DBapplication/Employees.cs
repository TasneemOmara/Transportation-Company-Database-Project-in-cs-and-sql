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
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepNum_and_Name();
            comboBox1_Dep.DataSource = dt;
            comboBox1_Dep.DisplayMember = "Name";
            comboBox1_Dep.ValueMember = "ID";

            DataTable dt2 = controllerObj.SelectEmp_SSN();
            comboBox3_update_SSN.DataSource = dt2;
            comboBox4_delete_SSN.DataSource = dt2;
            comboBox3_update_SSN.DisplayMember = "SSN";
            comboBox4_delete_SSN.DisplayMember = "SSN";
            comboBox3_update_SSN.ValueMember = "SSN";
            comboBox4_delete_SSN.ValueMember = "SSN";

            DataTable dt3 = controllerObj.SelectEmp_SSN();
            comboBox2_SSSN.DataSource = dt3;
            comboBox2_SSSN.DisplayMember = "SSN";
            comboBox2_SSSN.ValueMember = "SSN";

            comboBox4_gender.DataSource = new string[] { "Male", "Female"};

        }

        private void EmployeesInfo_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllEmp();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox1_SSN.Text == "" || textBox2_FN.Text == "" || textBox3_LN.Text == "" || textBox4_Salary.Text == "" || textBox4_Salary.Text == "" || textBox6_address.Text == "" || comboBox2_SSSN.SelectedValue == null || comboBox1_Dep.SelectedValue == null|| comboBox4_gender.SelectedItem == null ) //validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.InsertEmployee(long.Parse(textBox1_SSN.Text), 
                    textBox2_FN.Text, 
                    textBox3_LN.Text, 
                    textBox6_address.Text, 
                    (string)comboBox4_gender.SelectedValue, 
                    Convert.ToDouble(textBox4_Salary.Text), 
                    Convert.ToInt32(comboBox1_Dep.SelectedValue), 
                    (long)comboBox2_SSSN.SelectedValue);

                if (r > 0)
                    MessageBox.Show("Employee inserted successfully");
                else
                    MessageBox.Show("Error inserting employee");

                comboBox4_delete_SSN.Refresh();
                comboBox3_update_SSN.Refresh();
                comboBox2_SSSN.Refresh();
                comboBox4_gender.Refresh();
                

            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            DataRow employee = controllerObj.SelectEmp_fromSSN((long)comboBox3_update_SSN.SelectedValue).Rows[0];

            textBox1_SSN.Text = Convert.ToString(employee["SSN"]);
            textBox2_FN.Text = (string)employee["Fname"];
            textBox3_LN.Text = (string)employee["Lname"];
            textBox4_Salary.Text = Convert.ToString(employee["Salary"]);
            textBox6_address.Text = (string)employee["Address"];
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteEmployee((long)comboBox4_delete_SSN.SelectedValue);

            if (r > 0)
                MessageBox.Show("Employee deleted successfully");
            else
                MessageBox.Show("Error deleting employee");

            comboBox4_delete_SSN.Refresh();
            comboBox3_update_SSN.Refresh();
            comboBox2_SSSN.Refresh();
            comboBox4_gender.Refresh();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1_SSN.Text = "";
            textBox2_FN.Text = "";
            textBox3_LN.Text = "";
            textBox4_Salary.Text = "";
            textBox6_address.Text = "";
            comboBox4_delete_SSN.Refresh();
            comboBox3_update_SSN.Refresh();
            comboBox2_SSSN.Refresh();
            comboBox4_gender.Refresh();

        }

        private void button1_update_Click(object sender, EventArgs e)
        {
            if (textBox1_SSN.Text == "" || textBox2_FN.Text == "" || textBox3_LN.Text == "" || textBox4_Salary.Text == "" || textBox4_Salary.Text == "" || textBox6_address.Text == "" || comboBox2_SSSN.SelectedValue == null || comboBox1_Dep.SelectedValue == null || comboBox4_gender.SelectedItem == null) //validation part
            {
                MessageBox.Show("Please, select the employee you want to update");
            }
            else
            {
                int r = controllerObj.UpdateEmployee(
                (long)comboBox3_update_SSN.SelectedValue,
                textBox2_FN.Text,
                textBox3_LN.Text,
                textBox6_address.Text,
                (string)comboBox4_gender.SelectedValue,
                Convert.ToDouble(textBox4_Salary.Text),
                Convert.ToInt32(comboBox1_Dep.SelectedValue),
                (long)comboBox2_SSSN.SelectedValue);

                // UpdateEmployee(long ssn, string fname, string lname, string address, string Gender, int salary, int dno, long super_ssn)
                if (r > 0)
                    MessageBox.Show("Employee updated successfully");
                else
                    MessageBox.Show("Error Updating employee");

                comboBox4_delete_SSN.Refresh();
                comboBox3_update_SSN.Refresh();
                comboBox2_SSSN.Refresh();
                comboBox4_gender.Refresh();
            }
            
        }
    }
}

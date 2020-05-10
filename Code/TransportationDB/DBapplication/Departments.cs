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
    public partial class Departments : Form
    {
        Controller controllerObj;
        public Departments()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectDepNum_and_Name();
            comboBox2_nameUpdate.DataSource = dt;
            comboBox2_nameUpdate.DisplayMember = "Name";
            comboBox2_nameUpdate.ValueMember = "ID";

            DataTable dt2 = controllerObj.SelectAllMngrs();
            comboBox1_Mngr.DataSource = dt2;
            comboBox1_Mngr.DisplayMember = "Lname";
            comboBox1_Mngr.ValueMember = "SSN";
            

        }

        private void button1_getDepInfo_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllDep();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login func = new Login();
            func.Show(this);
        }

        private void button1_reset_Click(object sender, EventArgs e)
        {
            textBox2_Name.Text = "";
        }

        private void button3_add_Click(object sender, EventArgs e)
        {
            int r = controllerObj.InsertDep(textBox2_Name.Text, Convert.ToInt64(comboBox1_Mngr.SelectedValue));
            if (r > 0)
                MessageBox.Show("Department added successfully");
            else
                MessageBox.Show("Error added Department");
        }

        private void button4_get_Click(object sender, EventArgs e)
        {
            DataRow d = controllerObj.SelectDepInfoByID(Convert.ToInt32(comboBox2_nameUpdate.SelectedValue)).Rows[0];
            textBox2_Name.Text = (string)d["Name"];
        }

        private void button5_update_Click(object sender, EventArgs e)
        {
            int r = controllerObj.UpdateDep(textBox2_Name.Text, Convert.ToInt32(comboBox2_nameUpdate.SelectedValue), Convert.ToInt64(comboBox1_Mngr.SelectedValue));
            if (r > 0)
                MessageBox.Show("Department Updated successfully");
            else
                MessageBox.Show("Error updating Department");
        }

    }
}

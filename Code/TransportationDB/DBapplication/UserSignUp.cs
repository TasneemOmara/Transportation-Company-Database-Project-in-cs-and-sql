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
    public partial class UserSignUp : Form
    {
        Controller controllerObj;
        public UserSignUp()
        {
            InitializeComponent();
            controllerObj = new Controller();

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Priv", typeof(string));

            List<string> conString = new List<string>();
            conString.Add("GeneralManager,'Priv=1'");
            conString.Add("BussesManager,'Priv=9'");
            conString.Add("FinancialManager,'Priv=8'");
            conString.Add("Marketing,'Priv=7'");
            conString.Add("TrackDesigner,'Priv=6'");
            conString.Add("Sales,'Priv=5'");
            conString.Add("Driver,'Priv=4'");
            conString.Add("OtherEmployees,'Priv=3'");

            foreach (string s in conString)
            {
                DataRow dr = dt.NewRow();
                dr["Name"] = s.Split(',')[0];
                dr["Priv"] = s.Split(',')[1].Split('=')[1].Replace("'", string.Empty);
                dt.Rows.Add(dr);
            }
            comboBox1_pos.DataSource = dt;
            comboBox1_pos.DisplayMember = "Name"; comboBox1_pos.ValueMember = "Priv";

    }


        private void button1_signup_Click(object sender, EventArgs e)
        {
            int r = controllerObj.SignUp_newUser(textBox1_username.Text, textBox2_password.Text, Convert.ToInt32(comboBox1_pos.SelectedValue));
            if (r == -1)
            {
                MessageBox.Show("User Name already exist");
                textBox1_username.Text = "";
                textBox2_password.Text = "";
            }
            else if(r == 0)
            {
                MessageBox.Show("Signing up Failed!");
            }
            else
            {
                MessageBox.Show("Successfully added User!");
            }
        }
    }
}

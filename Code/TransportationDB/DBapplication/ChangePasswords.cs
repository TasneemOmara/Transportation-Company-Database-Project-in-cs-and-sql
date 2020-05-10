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
    public partial class ChangePasswords : Form
    {
        Controller controllerObj;
        public ChangePasswords(string username)
        {
            InitializeComponent();
            label3.Text = username;
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetLoginInfoByUsername(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Update_Password_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdatePassword(label3.Text, textBox2.Text);
            DataTable dt = controllerObj.GetLoginInfoByUsername(label3.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}

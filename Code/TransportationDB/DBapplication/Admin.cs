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
    public partial class Admin : Form
    {
        Controller controllerObj;
        public Admin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Manager_click(object sender, EventArgs e)
        {
            Manager func = new Manager();
            func.Show(this);
        }

        private void Marketing_Click(object sender, EventArgs e)
        {
            Marketing func = new Marketing();
            func.Show(this);
        }

        private void Other_Employees_Click(object sender, EventArgs e)
        {
            OtherEmployees func = new OtherEmployees();
            func.Show(this);
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            Sales func = new Sales();
            func.Show(this);
        }

        private void Track_Designer_Click(object sender, EventArgs e)
        {
            TracksDesigner func = new TracksDesigner();
            func.Show(this);
        }

        private void Driver_Click(object sender, EventArgs e)
        {
            Driver func = new Driver();
            func.Show(this);
        }

        private void Make_Admin_Click(object sender, EventArgs e)
        {
            int result = controllerObj.MakeAdmin(textBox1.Text);
            if (result > 0)
                MessageBox.Show("User had been set as Admin");
            else
                MessageBox.Show("Failed to set user as Admin");
        }
    }
}

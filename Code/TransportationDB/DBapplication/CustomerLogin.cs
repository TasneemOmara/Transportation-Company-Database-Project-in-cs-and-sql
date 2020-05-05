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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button1_Login_Click(object sender, EventArgs e)
        {
            //we have to check that the number is in the database
            int num = 0;   //number got from the textbox
            Customer C = new Customer(num);
            C.Show();
        }

        private void button2_SignUp_Click(object sender, EventArgs e)
        {
            //adding a new customer
        }
    }
}

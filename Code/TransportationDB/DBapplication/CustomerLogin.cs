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
        Controller controllerObj;
        public CustomerLogin()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Login_Click(object sender, EventArgs e)
        {
            //we have to check that the number is in the database
            int phonenumber = int.Parse(textBox1.Text);   //number got from the textbox
            int searchreturn = controllerObj.SearchForCustomerByNumber(phonenumber);

            if (searchreturn == 1)
            {
                MessageBox.Show("This phone number is not registered yet, Please SignUp!");
            }

            else
            {
                Customer C = new Customer(phonenumber);
                C.Show();
            }


        }

        private void button2_SignUp_Click(object sender, EventArgs e)
        {
            //adding a new customer
            //if (int.Parse(textBox2.Text) == NULL)

            int phonenumber = int.Parse(textBox2.Text);
            string fname = textBox3.Text;
            string lname = textBox4.Text;

            int SignUpReturn = controllerObj.CustomerSignUp(phonenumber, fname, lname);
            
            if (SignUpReturn == 0)
            {
                MessageBox.Show("This phone number already registered, Welcome Back!");
            }
        }
    }
}

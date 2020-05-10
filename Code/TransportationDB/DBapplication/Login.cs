using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public enum Privileges
    {
        GeneralManager=1,
        Customer=2,
        Employee=3,
        Driver=4,
        Sales=5,
        TrackDesigner=6,
        Marketing=7,
        FinancialManager=8,
        BussesManager=9

    }

    public partial class Login : Form
    {
        private bool _loggedin = false;
        private Controller controllerObj; // A Reference of type Controller
                                          // (Initially NULL; NO Controller Object is created yet)

        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller(); // Create the Controler Object
        }

       //checks the username/password and returns the privlidges associated with this user
        //Returns 0 in case of error
        private int CheckPassword_Basic(string username, string password)
        {
            controllerObj = new Controller();
            return controllerObj.CheckPassword_Basic(username, password);
            //return password == "1234";  //Password can be saved in the DB encrypted rather than being hardcoded.
                                        //Even if it is stored in a DB, keeping passwords in it's raw form is prone to attacks
        }


        private bool CheckPassword_Hash(string password)
        {
            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed == "w+0fHMgNFl7jSDJ7WpvRfIQLzfflSi9pPNdiQg+v4/E=";    //The Hash should be stored in the DB
                                                                                //Hashes needs a lot of time to be reversed (Brute Force, Dictionary Attacks, Rainbow Tables, etc.)
                                                                                //So even if they are stolen from the database,
                                                                                //you should have enough time to notify users to change it
                                                                                //before the attacker can use them.
        }


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            int privlg = controllerObj.CheckPassword_Basic(TxtBx_username.Text, TxtBx_pass.Text);

            if (privlg > 0)
            {
                if (privlg == 1 || privlg == 8 || privlg == 9) // Successful Login
                {
                    _loggedin = true;
                    Manager func = new Manager((Privileges)privlg);
                    func.Show(this);

                }
                else if (privlg == 3)
                {
                    OtherEmployees func = new OtherEmployees();
                    func.Show(this);
                }
                else if (privlg == 4)
                {
                    Driver func = new Driver();
                    func.Show(this);
                }
                else if (privlg == 5)
                {
                    Sales func = new Sales();
                    func.Show(this);
                }
                else if (privlg == 6)
                {
                    TracksDesigner T = new TracksDesigner();
                    T.Show();
                }
                else if (privlg == 7)
                {
                    Marketing func = new Marketing();
                    func.Show(this);
                }
                else if (privlg ==100)
                {
                    Admin func = new Admin();
                    func.Show();
                }
                TxtBx_pass.Clear();
                TxtBx_username.Clear();
                // Hide the Login Form
                // Don't close it because it's the startup form and the application will exit
                this.Hide();
            }

            else
            {
                MessageBox.Show("Wrong username or password");
            }
        }


        //private void Login_FormClosing(object sender, FormClosingEventArgs e)
        //{
            //if (e.CloseReason == CloseReason.UserClosing && !_loggedin)
              //  Owner.Show();
        //}

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_customer_Click(object sender, EventArgs e)
        {

                _loggedin = true;
                CustomerLogin func = new CustomerLogin();
                func.Show(this);
        }

        private void button1_signup_Click(object sender, EventArgs e)
        {
            UserSignUp func = new UserSignUp();
            func.Show(this);
        }

        private void Modify_Password_Click(object sender, EventArgs e)
        {
            int privlg = controllerObj.CheckPassword_Basic(TxtBx_username.Text, TxtBx_pass.Text);
            if (privlg > 0 && privlg < 10)
            {
                ChangePasswords func = new ChangePasswords(TxtBx_username.Text);
                func.Show(this);
            }

        }
    }
}

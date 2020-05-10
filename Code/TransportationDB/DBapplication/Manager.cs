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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private Privileges _privilege;

        public Manager(Privileges privilege)
        {
            InitializeComponent();
            this._privilege = privilege;
            if (privilege == Privileges.FinancialManager)
            {
                this.Employees.Enabled = false;
                this.Busses.Enabled = false;
                this.button1.Enabled = false;
            }
            else if(privilege == Privileges.BussesManager)
            {
                this.Employees.Enabled = false;
                this.Finances.Enabled = false;
                this.button1.Enabled = false;
            }
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees E = new Employees();
            E.Show();
            this.Hide();
        }

        private void Finances_Click(object sender, EventArgs e)
        {
            Finances F = new Finances();
            F.Show();
            this.Hide();
        }

        private void Busses_Click(object sender, EventArgs e)
        {
            Busses B = new Busses();
            B.Show();
            this.Hide();
        }

        private void show_statistics_click(object sender, EventArgs e)
        {
            Statistics S = new Statistics();
            S.Show();
            this.Hide();
        }

        private void button2_dep_Click(object sender, EventArgs e)
        {
            Departments D = new Departments();
            D.Show();
            this.Hide();
        }
    }
}

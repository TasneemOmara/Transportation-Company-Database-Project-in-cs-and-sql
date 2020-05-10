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
            }
            else if(privilege == Privileges.BussesManager)
            {
                this.Employees.Enabled = false;
                this.Finances.Enabled = false;
            }
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            Employees E = new Employees();
            E.Show();
        }

        private void Finances_Click(object sender, EventArgs e)
        {
            Finances F = new Finances();
            F.Show();
        }

        private void Busses_Click(object sender, EventArgs e)
        {
            Busses B = new Busses();
            B.Show();
        }

    }
}

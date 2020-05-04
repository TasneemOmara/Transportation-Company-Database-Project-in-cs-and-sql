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

        public Manager(Privileges privilege = Privileges.Others)
        {
            InitializeComponent();
            this._privilege = privilege;
            if (privilege == Privileges.Others)
            {
                //disable a functionality
            }
        }

        private void GetEmployerInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

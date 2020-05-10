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
    public partial class TracksDesigner : Form
    {
        public TracksDesigner()
        {
            InitializeComponent();
            comboBox1_DT.DisplayMember = "Departure Time";
            comboBox2_station1.DisplayMember = "First Station";
            comboBox3_station2.DisplayMember = "Second Station";
            comboBox4_station3.DisplayMember = "Third station";
            comboBox5_at3.DisplayMember = "Third Station Arrival Time";
            comboBox6_at2.DisplayMember = "Second Station Arrival Time";
            comboBox7_at1.DisplayMember = "First Station Arrival Time";
       

        }

        private void button1_addstation_Click(object sender, EventArgs e)
        {

        }

        private void button2_addATrack_Click(object sender, EventArgs e)
        {

        }

        private void button5_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login func = new Login();
            func.Show(this);
        }
    }
}

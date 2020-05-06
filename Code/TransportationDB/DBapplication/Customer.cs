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
    public partial class Customer : Form
    {
        public Customer(int num)
        {
            InitializeComponent();
            comboBox1_pickUp.DisplayMember = "Pick Up";
            comboBox2_dropOff.DisplayMember = "Drop Off";
            comboBox3_trackID.DisplayMember = "Track ID";

        }

        private void button1_avTracks_Click(object sender, EventArgs e)
        {

        }

        private void button2_book_Click(object sender, EventArgs e)
        {

        }

        private void button3_promo_Click(object sender, EventArgs e)
        {

        }

        private void button1_tracksByDate_Click(object sender, EventArgs e)
        {

        }
    }
}

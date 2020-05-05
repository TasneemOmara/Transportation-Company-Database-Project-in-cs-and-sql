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
    public partial class Busses : Form
    {
        Controller controllerObj;

        public Busses()
        {
            InitializeComponent();
            //DataTable dt = controllerObj.SelectDepLoc();
            //comboBox1.DataSource = dt;
            TrackID_RS_ComboBox.DisplayMember = "Track ID";
            TrackID_DT_ComboBox.DisplayMember = "Track ID";
            TrackID_AT_ComboBox.DisplayMember = "Track ID";
            StationsComboBoxAT.DisplayMember  = "Station";
            BusNum_RS_ComboBox.DisplayMember =  "Bus Number";
        }

        private void ReservedSeats_Click(object sender, EventArgs e)
        {

        }

        private void Arrival_Click(object sender, EventArgs e)
        {

        }

        private void Departure_Click(object sender, EventArgs e)
        {

        }

        private void TracksInfo_Click(object sender, EventArgs e)
        {
            //DataTable dt = controllerObj.SelectProject(comboBox1.Text);
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
        }
    }
}

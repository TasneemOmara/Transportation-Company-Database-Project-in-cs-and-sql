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
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectTracksID();
            ComboBox_TrackID_DT.DataSource = dt;
            ComboBox_TrackID_AT.DataSource = dt;
            Combobox_trackID_ReservedSeats.DataSource = dt;
            ComboBox_TrackID_DT.DisplayMember = "ID";
            ComboBox_TrackID_AT.DisplayMember = "ID";
            Combobox_trackID_ReservedSeats.DisplayMember = "ID";
            ComboBox_TrackID_DT.ValueMember = "ID";
            ComboBox_TrackID_AT.ValueMember = "ID";
            Combobox_trackID_ReservedSeats.ValueMember = "ID";

            DataTable dt2 = controllerObj.SelectBussesNum();
            ComboBox_BusNum_ReservedSeats.DataSource = dt2;
            ComboBox_BusNum_ReservedSeats.DisplayMember = "Number";
            ComboBox_BusNum_ReservedSeats.ValueMember = "Number";

            DataTable dt3 = controllerObj.SelectStations();
            ComboBox_Stations_ArrivalTime.DataSource = dt3;
            ComboBox_Stations_ArrivalTime.DisplayMember = "Location";
            ComboBox_Stations_ArrivalTime.ValueMember = "Location";

        }

        private void ReservedSeats_Click(object sender, EventArgs e)
        {
            //DataRow seats = controllerObj.SelectReservedSeats_TrackID_BusNumber((int)Combobox_trackID_ReservedSeats.SelectedValue, (int)ComboBox_BusNum_ReservedSeats.SelectedValue).Rows[0];
            //TextReserved.Text = Convert.ToString(seats["Seats"]);
        }

        private void Arrival_Click(object sender, EventArgs e)
        {

        }

        private void Departure_Click(object sender, EventArgs e)
        {
            //DataRow DT = controllerObj.Select_DepartureTime_ID(Convert.ToInt32(ComboBox_TrackID_DT.SelectedValue)).Rows[0];
            //TextDepart.Text = Convert.ToString(DT["Departure_Time"]);
        }

        private void TracksInfo_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllTracks();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_Reset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            TextReserved.Text = "";

        }
    }
}

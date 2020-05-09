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
        int last_clicked_ID_AT;
        int last_clicked_ID_RS;
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

            last_clicked_ID_AT = Convert.ToInt32(ComboBox_TrackID_AT.SelectedValue);
            last_clicked_ID_RS = Convert.ToInt32(Combobox_trackID_ReservedSeats.SelectedValue); ;

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
            textBox1_Reserved.Text = "";

        }

        private void button1_TrackBusses_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAllTracksBusses();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button1_getBusses_Click(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.SelectBussesNum(Convert.ToInt32(Combobox_trackID_ReservedSeats.SelectedValue));
            ComboBox_BusNum_ReservedSeats.DataSource = dt2;
            ComboBox_BusNum_ReservedSeats.DisplayMember = "Number";
            ComboBox_BusNum_ReservedSeats.ValueMember = "Number";
            last_clicked_ID_RS = Convert.ToInt32(Combobox_trackID_ReservedSeats.SelectedValue);
        }

        private void button1_getstations_Click(object sender, EventArgs e)
        {
            DataTable dt3 = controllerObj.SelectStations(Convert.ToInt32(ComboBox_TrackID_AT.SelectedValue));
            ComboBox_Stations_ArrivalTime.DataSource = dt3;
            ComboBox_Stations_ArrivalTime.DisplayMember = "Location";
            ComboBox_Stations_ArrivalTime.ValueMember = "Location";
            last_clicked_ID_AT = Convert.ToInt32(ComboBox_TrackID_AT.SelectedValue);
        }

        private void ReservedSeats_Click_1(object sender, EventArgs e)
        {
            DataRow seats = controllerObj.SelectReservedSeats_TrackID_BusNumber(last_clicked_ID_RS, Convert.ToInt64(ComboBox_BusNum_ReservedSeats.SelectedValue)).Rows[0];
            textBox1_Reserved.Text = Convert.ToString(seats["Seats"]);
        }

        private void Departure_Click_1(object sender, EventArgs e)
        {
            DataRow DT = controllerObj.Select_DepartureTime_ID(Convert.ToInt32(ComboBox_TrackID_DT.SelectedValue)).Rows[0];
            DateTime Date = Convert.ToDateTime(DT["Departure_Time"]);
            dateTimePicker2DT.Value = Date;
        }

        private void Arrival_Click(object sender, EventArgs e)
        {
            DataRow AT = controllerObj.Select_ArrivalTime_ID(last_clicked_ID_AT, Convert.ToString(ComboBox_Stations_ArrivalTime.SelectedValue)).Rows[0];
            DateTime Date = Convert.ToDateTime(AT["Arrival_Time"]);
            dateTimePicker2DT.Value = Date;
        }
    }
}

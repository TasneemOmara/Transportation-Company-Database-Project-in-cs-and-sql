using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DBapplication
{
    public partial class TracksDesigner : Form
    {
        Controller controllerObj;
        string newLine = Environment.NewLine;
        string DB_Connection_String = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;


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

            controllerObj = new Controller();

        }

        private void button1_addstation_Click(object sender, EventArgs e)
        {
            string Location = textBox1_addStation.Text.ToString();
            string Name = textBox2_addstation.Text.ToString();

            if(textBox1_addStation.Text.Length == 0 || textBox2_addstation.Text.Length == 0)
            {
                MessageBox.Show("Please, Enter the Station's Location and Name");
                return;
            }


            controllerObj.AddStation(Location, Name);
            RefreshStationsList();  //Refreshes the lists below to allow usasge of newly created stations
            MessageBox.Show("Done Successfuly!" + newLine + "Location is: " + Location + " and " + "Name is: " + Name);
        }

        private void button2_addATrack_Click(object sender, EventArgs e)
        {

            string station1 = comboBox2_station1.Text;
            string station2 = comboBox3_station2.Text;
            string station3 = comboBox4_station3.Text;
            string ArrivalTime1 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + " " + comboBox7_at1.Text;
            string ArrivalTime2 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + " " + comboBox6_at2.Text;
            string ArrivalTime3 = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + " " + comboBox5_at3.Text;
            string DepartureTime = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + " " + comboBox1_DT.Text;


            if (textBox2_trackID.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a valid ID");
                return;
            }
            else if (controllerObj.TrackCheckerByID(int.Parse(textBox2_trackID.Text.ToString())) == 1)
            {
                MessageBox.Show("This Track ID Already Exists!" + newLine + "Please, Try Another One.");
                return;
            }
            int ID = int.Parse(textBox2_trackID.Text);


            if (comboBox1_DT.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Departure Time for the Track!");
                return;
            }


            if (station1 == station2 || station1 == station3 || station2 == station3)
            {
                MessageBox.Show("Please Choose Different Locations for each Bus-Stop!");
                return;
            }


            if (comboBox7_at1.Text.Length == 0 || comboBox6_at2.Text.Length == 0 || comboBox5_at3.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Arrival Times for each Station!");
                return;
            }


            if (textBox3_price.Text.Length == 0)
            {
                MessageBox.Show("Please Enter a valid Price, This is not Charity!");
                return;
            }
            double price = double.Parse(textBox3_price.Text);


            controllerObj.AddTrack(DepartureTime, price, ID, station1, station2, station3, ArrivalTime1, ArrivalTime2, ArrivalTime3);
            MessageBox.Show("Track Added with Departure Time: " + DepartureTime + " and ID: " + ID + " and Price: " + price);

        }

        private void TracksDesigner_Load(object sender, EventArgs e)
        {
            //Setting DatePicker
            dateTimePicker1.Value = DateTime.Today;
            // Set the Format type and the CustomFormat string.
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "yyyy-MM-dd";


            //Refresh Stations' Lists
            RefreshStationsList();

            comboBox1_DT.Items.AddRange(new string[] { "00:00:00", "00:30:00", "01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00", "04:00:00", "04:30:00", "05:00:00", "05:30:00", "06:00:00", "06:30:00", "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00", "19:00:00", "19:30:00", "20:00:00", "20:30:00", "21:00:00", "21:30:00", "22:00:00", "22:30:00", "23:00:00", "23:30:00" });
            comboBox1_DT.Refresh();

            comboBox7_at1.Items.AddRange(new string[] { "00:00:00", "00:30:00", "01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00", "04:00:00", "04:30:00", "05:00:00", "05:30:00", "06:00:00", "06:30:00", "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00", "19:00:00", "19:30:00", "20:00:00", "20:30:00", "21:00:00", "21:30:00", "22:00:00", "22:30:00", "23:00:00", "23:30:00" });
            comboBox7_at1.Refresh();

            comboBox6_at2.Items.AddRange(new string[] { "00:00:00", "00:30:00", "01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00", "04:00:00", "04:30:00", "05:00:00", "05:30:00", "06:00:00", "06:30:00", "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00", "19:00:00", "19:30:00", "20:00:00", "20:30:00", "21:00:00", "21:30:00", "22:00:00", "22:30:00", "23:00:00", "23:30:00" });
            comboBox6_at2.Refresh();

            comboBox5_at3.Items.AddRange(new string[] { "00:00:00", "00:30:00", "01:00:00", "01:30:00", "02:00:00", "02:30:00", "03:00:00", "03:30:00", "04:00:00", "04:30:00", "05:00:00", "05:30:00", "06:00:00", "06:30:00", "07:00:00", "07:30:00", "08:00:00", "08:30:00", "09:30:00", "10:00:00", "10:30:00", "11:00:00", "11:30:00", "12:00:00", "12:30:00", "13:00:00", "13:30:00", "14:00:00", "14:30:00", "15:00:00", "15:30:00", "16:00:00", "16:30:00", "17:00:00", "17:30:00", "18:00:00", "18:30:00", "19:00:00", "19:30:00", "20:00:00", "20:30:00", "21:00:00", "21:30:00", "22:00:00", "22:30:00", "23:00:00", "23:30:00" });
            comboBox5_at3.Refresh();


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshStationsList()
        {
            //Refreshing Stations Lists
            SqlConnection conn = new SqlConnection(DB_Connection_String);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select [Name] From [Stations]",conn);
                SqlDataAdapter NarrowedDownPickup = new SqlDataAdapter();
                NarrowedDownPickup.SelectCommand = cmd;
                NarrowedDownPickup.Fill(ds);
                comboBox2_station1.DisplayMember = "Name";
                comboBox2_station1.ValueMember = "Name";
                comboBox2_station1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }


            SqlConnection conn2 = new SqlConnection(DB_Connection_String);
            DataSet ds2 = new DataSet();
            try
            {
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("Select [Name] From [Stations]", conn2);
                SqlDataAdapter NarrowedDownPickup2 = new SqlDataAdapter();
                NarrowedDownPickup2.SelectCommand = cmd2;
                NarrowedDownPickup2.Fill(ds2);
                comboBox3_station2.DisplayMember = "Name";
                comboBox3_station2.ValueMember = "Name";
                comboBox3_station2.DataSource = ds2.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn2.Close();
                conn2.Dispose();
            }


            SqlConnection conn3 = new SqlConnection(DB_Connection_String);
            DataSet ds3 = new DataSet();
            try
            {
                conn3.Open();
                SqlCommand cmd3 = new SqlCommand("Select [Name] From [Stations]", conn3);
                SqlDataAdapter NarrowedDownPickup3 = new SqlDataAdapter();
                NarrowedDownPickup3.SelectCommand = cmd3;
                NarrowedDownPickup3.Fill(ds3);
                comboBox4_station3.DisplayMember = "Name";
                comboBox4_station3.ValueMember = "Name";
                comboBox4_station3.DataSource = ds3.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn3.Close();
                conn3.Dispose();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox7_at1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_at2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_at3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login func = new Login();
            func.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PlatesNumber = int.Parse(textBox1.Text.ToString());
            int SeatsNumber = int.Parse(textBox2.Text.ToString());
            string BusType = textBox3.Text.ToString();

            controllerObj.AddBuss(PlatesNumber, SeatsNumber, BusType);
            MessageBox.Show("Buss Added!" + newLine + "Plates Number: " + PlatesNumber + newLine + "Seats Number: " + SeatsNumber + newLine + "Type: " + BusType);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string MaintDate = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            string SpareParts = textBox4.Text.ToString();
            int BusNumber = int.Parse(textBox7.Text.ToString());

            controllerObj.EditExistingBus(BusNumber, MaintDate, SpareParts);
            MessageBox.Show(SpareParts);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int PlatesNumber = int.Parse(textBox5.Text.ToString());
            int TrackID = int.Parse(textBox6.Text.ToString());

            controllerObj.AssignBusToTrack(PlatesNumber, TrackID);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }



}

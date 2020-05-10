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
    public partial class Customer : Form
    {
        Controller controllerObj;

        string DB_Connection_String = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public Customer(int num)
        {
            InitializeComponent();
            controllerObj = new Controller();

            label8.Text = num.ToString();
            label8.Refresh();

            DataTable CustomerName = controllerObj.GetCustomerNameByPhone(num);
            label9.Text = CustomerName.Rows[0][0].ToString();

            comboBox1_pickUp.DisplayMember = "Pick Up";
            comboBox2_dropOff.DisplayMember = "Drop Off";
            comboBox3_trackID.DisplayMember = "Track ID";

        }

        private void button1_avTracks_Click(object sender, EventArgs e)
        {
            string pickup = comboBox1_pickUp.Text;
            string dropoff = comboBox2_dropOff.Text;
            DateTime pickeddate = dateTimePicker1.Value;
            DataTable dtSearchResultRoutes = controllerObj.SearchRoutes(pickeddate, pickup, dropoff);
            dataGridView1.DataSource = dtSearchResultRoutes;
            dataGridView1.Refresh();

        }

        private void button2_book_Click(object sender, EventArgs e)
        {
            if (comboBox3_trackID.SelectedItem != null)
            {
                int CustomerPhone = int.Parse(label8.Text);

                int Checker = controllerObj.IfBookedBefore(CustomerPhone);
                if (Checker != 0)
                {
                    MessageBox.Show("You can't book more than one Trip!, Your Booked Boarding Pass is: " + Checker);
                    return;
                }

                int TrackID = int.Parse(comboBox3_trackID.SelectedValue.ToString());
                int SeatsCheck = controllerObj.CheckSeats(TrackID);

                if (SeatsCheck > 0)
                    {
                    controllerObj.BookRide(TrackID, CustomerPhone);
                    controllerObj.UpdateSeats(TrackID, 0);
                    DataTable dtBP = controllerObj.GetBoardingPass(CustomerPhone);
                    textBox1_boardingPass.Text = dtBP.Rows[0][0].ToString();
                    textBox1_boardingPass.Refresh();
                    
                    int percent = 0;
                    if ((radioButton1.Checked && !string.IsNullOrWhiteSpace(textBox1.Text)) || (radioButton2.Checked && controllerObj.PreviousPromoChecker(CustomerPhone) == 1))
                    {
                        if (radioButton1.Checked && !string.IsNullOrWhiteSpace(textBox1.Text))
                        {
                            controllerObj.UpdateUserPromo(textBox1.Text, CustomerPhone);
                            percent = 65;
                            MessageBox.Show("New Promo-Code Accepted!. You Booked Sucessfully with " + percent + "% Discount");
                        }

                        else if (radioButton1.Checked && string.IsNullOrWhiteSpace(textBox1.Text))
                        {
                            percent = 0;
                            MessageBox.Show("New Promo-Code is INVALID!. You Booked Sucessfully with " + percent + "% Discount");
                        }

                        else if (radioButton2.Checked && controllerObj.PreviousPromoChecker(CustomerPhone) == 1)
                        {
                            percent = 30;
                            MessageBox.Show("Previous Promo-Code is Still Working!. You Booked Sucessfully with " + percent + "% Discount");
                        }

                        else if (radioButton2.Checked && controllerObj.PreviousPromoChecker(CustomerPhone) == 0)
                        {
                            percent = 0;
                            MessageBox.Show("You did not use a Promo-Code before or your previous one is EXPIRED!. You Booked Sucessfully with " + percent + "% Discount");
                        }

                    }
                    else
                    {
                        MessageBox.Show("You Booked Sucessfully with " + percent + "% Discount");
                    }


                }

                else
                {
                    MessageBox.Show("This Bus is Full, Please Check Another Track/Bus!");
                }


            }
            else
            {
                //Value is null
            }
        }

        private void button3_promo_Click(object sender, EventArgs e)
        {

        }

        private void button1_tracksByDate_Click(object sender, EventArgs e)
        {
            DateTime PickedDate;
         
            //Available Tracks ID
            PickedDate = dateTimePicker1.Value;
            DataTable dtSearchResult = controllerObj.TracksSearchByDate(PickedDate);
            dataGridView1.DataSource = dtSearchResult;
            dataGridView1.Refresh();


            SqlConnection conn3 = new SqlConnection(DB_Connection_String);
            DataSet ds3 = new DataSet();
            try
            {
                conn3.Open();
                SqlCommand cmd3 = new SqlCommand("SELECT Distinct ID FROM Tracks INNER JOIN [Track Station Relation] ON [Tracks].[ID] = [Track Station Relation].[Track_ID] WHERE Convert(DATE, Departure_Time) = '" + PickedDate + "'", conn3);
                SqlDataAdapter da3 = new SqlDataAdapter();
                da3.SelectCommand = cmd3;
                da3.Fill(ds3);
                comboBox3_trackID.DisplayMember = "ID";
                comboBox3_trackID.ValueMember = "ID";
                comboBox3_trackID.DataSource = ds3.Tables[0];
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



            //Narrowed Down Option for PickUp
            SqlConnection conn4 = new SqlConnection(DB_Connection_String);
            DataSet ds4 = new DataSet();
            try
            {
                conn4.Open();
                SqlCommand cmd4 = new SqlCommand("Select Distinct [Station_Location] From [Track Station Relation] WHERE Convert(DATE, [Arrival_Time]) = '" + PickedDate + "' AND [Order] < 3", conn4);
                SqlDataAdapter NarrowedDownPickup = new SqlDataAdapter();
                NarrowedDownPickup.SelectCommand = cmd4;
                NarrowedDownPickup.Fill(ds4);
                comboBox1_pickUp.DisplayMember = "Station_Location";
                comboBox1_pickUp.ValueMember = "Station_Location";
                comboBox1_pickUp.DataSource = ds4.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn4.Close();
                conn4.Dispose();
            }

            
            //Narrowed Down Option for DropOff
            SqlConnection conn5 = new SqlConnection(DB_Connection_String);
            DataSet ds5 = new DataSet();
            try
            {
                conn5.Open();
                SqlCommand cmd5 = new SqlCommand("Select Distinct [Station_Location] From [Track Station Relation] WHERE Convert(DATE, [Arrival_Time]) = '" + PickedDate + "' AND [Order] > 1", conn5);
                SqlDataAdapter NarrowedDownDropoff = new SqlDataAdapter();
                NarrowedDownDropoff.SelectCommand = cmd5;
                NarrowedDownDropoff.Fill(ds5);
                comboBox2_dropOff.DisplayMember = "Station_Location";
                comboBox2_dropOff.ValueMember = "Station_Location";
                comboBox2_dropOff.DataSource = ds5.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn4.Close();
                conn4.Dispose();
            }

            



        }

        private void comboBox1_pickUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

            //Setting DatePicker
            dateTimePicker1.Value = DateTime.Today;


        }

        private void comboBox2_dropOff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_trackID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

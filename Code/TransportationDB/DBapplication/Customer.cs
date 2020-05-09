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

            //DataTable SearchByStations = controllerObj.SearchRoutes(pickup, dropoff);
            //dataGridView1.DataSource = SearchByStations;
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
                DataTable dtSeatsNo = controllerObj.CheckSeats(TrackID);

                if (int.Parse(dtSeatsNo.Rows[0][0].ToString()) > 0)
                    {
                    controllerObj.BookRide(TrackID, CustomerPhone);
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




        }

        private void comboBox1_pickUp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB_Connection_String);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select Name from Stations", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                comboBox1_pickUp.DisplayMember = "Name";
                comboBox1_pickUp.ValueMember = "Name";
                comboBox1_pickUp.DataSource = ds.Tables[0];
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
                SqlCommand cmd2 = new SqlCommand("select Name from Stations", conn2);
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.SelectCommand = cmd2;
                da2.Fill(ds2);
                comboBox2_dropOff.DisplayMember = "Name";
                comboBox2_dropOff.ValueMember = "Name";
                comboBox2_dropOff.DataSource = ds2.Tables[0];
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

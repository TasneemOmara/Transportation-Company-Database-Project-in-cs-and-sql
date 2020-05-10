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
    public partial class Statistics : Form
    {
        Controller controllerObj;
        public Statistics()
        {
            InitializeComponent();
            controllerObj = new Controller();

            label2.Text = controllerObj.HeighestSalesMonth().Rows[0][0].ToString();  //num.ToString();
            label2.Refresh();
            label4.Text = controllerObj.GetMonthBySales(Convert.ToDecimal(label2.Text)).Rows[0][0].ToString();
            label4.Refresh();
            label6.Text = controllerObj.HeighestExpensesMonth().Rows[0][0].ToString();
            label6.Refresh();
            label8.Text = controllerObj.GetMonthByExpenses(Convert.ToDecimal(label6.Text)).Rows[0][0].ToString();
            label8.Refresh();
            label10.Text = controllerObj.HeighestProfitMonth().Rows[0][0].ToString();
            label10.Refresh();
            label12.Text = controllerObj.GetMonthBYProfit(Convert.ToDecimal(label10.Text)).Rows[0][0].ToString();
            label12.Refresh();
            label14.Text = controllerObj.GetAvergeProfit().Rows[0][0].ToString();
            label14.Refresh();
            label16.Text = controllerObj.GetAvergeSalary().Rows[0][0].ToString();
            label16.Refresh();
            label18.Text = controllerObj.GetAvergeSalaryForMales().Rows[0][0].ToString();
            label18.Refresh();
            label20.Text = controllerObj.GetAvergeSalaryForFemales().Rows[0][0].ToString();
            label20.Refresh();
            DataTable tb = controllerObj.GetEmployeesNumberInEachDepartment();
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
            label22.Text = controllerObj.GetNumberOfCustomersWithPromoCodes().Rows[0][0].ToString();
            label22.Refresh();
            label24.Text = controllerObj.GetAverageFrequencyOfCustomers().Rows[0][0].ToString();
            label24.Refresh();
            label28.Text = controllerObj.SumOfCustomers().Rows[0][0].ToString();
            label28.Refresh();
            DataTable MosFreStation = controllerObj.GetNameMostFrequentStationAmongTracks();
            label30.Text = MosFreStation.Rows[0][0].ToString();
            label30.Refresh();
            label32.Text = MosFreStation.Rows[0][1].ToString();
            label32.Refresh();
            label34.Text = controllerObj.GetSumOfBusses().Rows[0][0].ToString();
            label34.Refresh();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login func = new Login();
            func.Show(this);
        }
    }
}

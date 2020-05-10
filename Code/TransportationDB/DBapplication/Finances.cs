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
    public partial class Finances : Form
    {
        Controller controllerObj;
        public Finances()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectMonthsFromFinance();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Month";
            comboBox1.ValueMember = "Month";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Expenses_Click(object sender, EventArgs e)
        {
            DataRow expenses = controllerObj.SelectExpenses(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0];
            Textbox_expenses.Text = Convert.ToString(expenses["Expenses"]);
        }

        private void Sales_Click(object sender, EventArgs e)
        {
            DataRow Sales = controllerObj.SelectSales(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0];
            Textbox_sales.Text = Convert.ToString(Sales["Sales"]);
        }

        private void Profit_Click(object sender, EventArgs e)
        {
            DataRow expenses = controllerObj.SelectExpenses(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0];
            DataRow Sales = controllerObj.SelectSales(Convert.ToInt32(comboBox1.SelectedValue)).Rows[0];
            int sale = Convert.ToInt32(Sales["Sales"]);
            int exp = Convert.ToInt32(expenses["Expenses"]);
            int pro = sale - exp;
            Textbox_profit.Text = Convert.ToString(pro);
        }

        private void button1AddExpenses_Click(object sender, EventArgs e)
        {
            if (textBox1_add_exp.Text == "")
            { 
                MessageBox.Show("Please, input how much money you want to add as expenses");
            }
            else
            {
                int r = controllerObj.AddExpenses((int)comboBox1.SelectedValue, Convert.ToDouble(textBox1_add_exp.Text));
                if (r > 0)
                    MessageBox.Show("Expenses added successfuly");
                else
                    MessageBox.Show("Error adding Expenses");
            }
        }

        private void button2AddSales_Click(object sender, EventArgs e)
        {
            if (textBox2_addSales.Text == "")
            {
                MessageBox.Show("Please, input how much money you want to add as Sales");
            }
            else
            {
                int r = controllerObj.AddSales((int)comboBox1.SelectedValue, Convert.ToDouble(textBox2_addSales.Text));
                if (r > 0)
                    MessageBox.Show("Sales added successfuly");
                else
                    MessageBox.Show("Error adding Sales");
            }
        }

        private void button1_reset_Click(object sender, EventArgs e)
        {
            textBox1_add_exp.Text = "";
            textBox2_addSales.Text = "";
            Textbox_expenses.Text = "";
            Textbox_profit.Text = "";
            Textbox_sales.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login func = new Login();
            func.Show(this);
        }
    }
}

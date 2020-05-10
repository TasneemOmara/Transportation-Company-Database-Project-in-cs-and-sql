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
    public partial class Sales : Form
    {
        Controller controllerObj;
        public Sales()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void get_price_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetTracks();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void modify_price_click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateTrackPrice(Convert.ToDecimal(textBox3.Text) , Convert.ToInt32(textBox1.Text));
            if (result > 0)
                MessageBox.Show("Price Updated Successfully");
            else
                MessageBox.Show("Failed To Update Price");
            DataTable dt = controllerObj.GetTracks();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void get_data_click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.GetCustomerData(Convert.ToInt32(textBox2.Text));
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void update_promo_click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdatePromo(Convert.ToString(textBox4.Text), Convert.ToInt32(textBox2.Text));
            if (result > 0)
                MessageBox.Show("Promo-Code Updated Successfully");
            else
                MessageBox.Show("Failed To Update Promo-Code");
        }

        private void Sales_Load(object sender, EventArgs e)
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

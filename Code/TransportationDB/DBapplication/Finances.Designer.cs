namespace DBapplication
{
    partial class Finances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Expenses = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.Profit = new System.Windows.Forms.Button();
            this.Textbox_expenses = new System.Windows.Forms.TextBox();
            this.Textbox_sales = new System.Windows.Forms.TextBox();
            this.Textbox_profit = new System.Windows.Forms.TextBox();
            this.button1AddExpenses = new System.Windows.Forms.Button();
            this.textBox1_add_exp = new System.Windows.Forms.TextBox();
            this.textBox2_addSales = new System.Windows.Forms.TextBox();
            this.button2AddSales = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1_reset = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(383, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Month";
            // 
            // Expenses
            // 
            this.Expenses.Location = new System.Drawing.Point(37, 177);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(204, 46);
            this.Expenses.TabIndex = 2;
            this.Expenses.Text = "Get Expenses";
            this.Expenses.UseVisualStyleBackColor = true;
            this.Expenses.Click += new System.EventHandler(this.Expenses_Click);
            // 
            // Sales
            // 
            this.Sales.Location = new System.Drawing.Point(37, 268);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(204, 46);
            this.Sales.TabIndex = 3;
            this.Sales.Text = "Get Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // Profit
            // 
            this.Profit.Location = new System.Drawing.Point(37, 353);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(204, 46);
            this.Profit.TabIndex = 4;
            this.Profit.Text = "Get Profit";
            this.Profit.UseVisualStyleBackColor = true;
            this.Profit.Click += new System.EventHandler(this.Profit_Click);
            // 
            // Textbox_expenses
            // 
            this.Textbox_expenses.Location = new System.Drawing.Point(268, 189);
            this.Textbox_expenses.Name = "Textbox_expenses";
            this.Textbox_expenses.Size = new System.Drawing.Size(189, 22);
            this.Textbox_expenses.TabIndex = 5;
            // 
            // Textbox_sales
            // 
            this.Textbox_sales.Location = new System.Drawing.Point(268, 280);
            this.Textbox_sales.Name = "Textbox_sales";
            this.Textbox_sales.Size = new System.Drawing.Size(189, 22);
            this.Textbox_sales.TabIndex = 6;
            // 
            // Textbox_profit
            // 
            this.Textbox_profit.Location = new System.Drawing.Point(268, 365);
            this.Textbox_profit.Name = "Textbox_profit";
            this.Textbox_profit.Size = new System.Drawing.Size(189, 22);
            this.Textbox_profit.TabIndex = 7;
            // 
            // button1AddExpenses
            // 
            this.button1AddExpenses.Location = new System.Drawing.Point(524, 218);
            this.button1AddExpenses.Name = "button1AddExpenses";
            this.button1AddExpenses.Size = new System.Drawing.Size(204, 46);
            this.button1AddExpenses.TabIndex = 8;
            this.button1AddExpenses.Text = "Add Expenses";
            this.button1AddExpenses.UseVisualStyleBackColor = true;
            this.button1AddExpenses.Click += new System.EventHandler(this.button1AddExpenses_Click);
            // 
            // textBox1_add_exp
            // 
            this.textBox1_add_exp.Location = new System.Drawing.Point(790, 230);
            this.textBox1_add_exp.Name = "textBox1_add_exp";
            this.textBox1_add_exp.Size = new System.Drawing.Size(189, 22);
            this.textBox1_add_exp.TabIndex = 9;
            // 
            // textBox2_addSales
            // 
            this.textBox2_addSales.Location = new System.Drawing.Point(790, 325);
            this.textBox2_addSales.Name = "textBox2_addSales";
            this.textBox2_addSales.Size = new System.Drawing.Size(189, 22);
            this.textBox2_addSales.TabIndex = 11;
            // 
            // button2AddSales
            // 
            this.button2AddSales.Location = new System.Drawing.Point(524, 313);
            this.button2AddSales.Name = "button2AddSales";
            this.button2AddSales.Size = new System.Drawing.Size(204, 46);
            this.button2AddSales.TabIndex = 10;
            this.button2AddSales.Text = "Add Sales";
            this.button2AddSales.UseVisualStyleBackColor = true;
            this.button2AddSales.Click += new System.EventHandler(this.button2AddSales_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Input the Expenses:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(817, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Input the Sales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choose the Month:";
            // 
            // button1_reset
            // 
            this.button1_reset.Location = new System.Drawing.Point(719, 67);
            this.button1_reset.Name = "button1_reset";
            this.button1_reset.Size = new System.Drawing.Size(204, 46);
            this.button1_reset.TabIndex = 16;
            this.button1_reset.Text = "Reset Fields";
            this.button1_reset.UseVisualStyleBackColor = true;
            this.button1_reset.Click += new System.EventHandler(this.button1_reset_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(918, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 41);
            this.button5.TabIndex = 44;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1_reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_addSales);
            this.Controls.Add(this.button2AddSales);
            this.Controls.Add(this.textBox1_add_exp);
            this.Controls.Add(this.button1AddExpenses);
            this.Controls.Add(this.Textbox_profit);
            this.Controls.Add(this.Textbox_sales);
            this.Controls.Add(this.Textbox_expenses);
            this.Controls.Add(this.Profit);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.Expenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Finances";
            this.Text = "Finances";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Expenses;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button Profit;
        private System.Windows.Forms.TextBox Textbox_expenses;
        private System.Windows.Forms.TextBox Textbox_sales;
        private System.Windows.Forms.TextBox Textbox_profit;
        private System.Windows.Forms.Button button1AddExpenses;
        private System.Windows.Forms.TextBox textBox1_add_exp;
        private System.Windows.Forms.TextBox textBox2_addSales;
        private System.Windows.Forms.Button button2AddSales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1_reset;
        private System.Windows.Forms.Button button5;
    }
}
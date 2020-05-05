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
            this.ExpensesTextBox = new System.Windows.Forms.TextBox();
            this.SalesTextBox = new System.Windows.Forms.TextBox();
            this.ProfitTextBox = new System.Windows.Forms.TextBox();
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
            this.Expenses.Location = new System.Drawing.Point(94, 189);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(204, 46);
            this.Expenses.TabIndex = 2;
            this.Expenses.Text = "Get Expenses";
            this.Expenses.UseVisualStyleBackColor = true;
            this.Expenses.Click += new System.EventHandler(this.Expenses_Click);
            // 
            // Sales
            // 
            this.Sales.Location = new System.Drawing.Point(94, 268);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(204, 46);
            this.Sales.TabIndex = 3;
            this.Sales.Text = "Get Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // Profit
            // 
            this.Profit.Location = new System.Drawing.Point(94, 353);
            this.Profit.Name = "Profit";
            this.Profit.Size = new System.Drawing.Size(204, 46);
            this.Profit.TabIndex = 4;
            this.Profit.Text = "Get Profit";
            this.Profit.UseVisualStyleBackColor = true;
            this.Profit.Click += new System.EventHandler(this.Profit_Click);
            // 
            // ExpensesTextBox
            // 
            this.ExpensesTextBox.Location = new System.Drawing.Point(472, 201);
            this.ExpensesTextBox.Name = "ExpensesTextBox";
            this.ExpensesTextBox.Size = new System.Drawing.Size(189, 22);
            this.ExpensesTextBox.TabIndex = 5;
            // 
            // SalesTextBox
            // 
            this.SalesTextBox.Location = new System.Drawing.Point(472, 280);
            this.SalesTextBox.Name = "SalesTextBox";
            this.SalesTextBox.Size = new System.Drawing.Size(189, 22);
            this.SalesTextBox.TabIndex = 6;
            // 
            // ProfitTextBox
            // 
            this.ProfitTextBox.Location = new System.Drawing.Point(472, 365);
            this.ProfitTextBox.Name = "ProfitTextBox";
            this.ProfitTextBox.Size = new System.Drawing.Size(189, 22);
            this.ProfitTextBox.TabIndex = 7;
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfitTextBox);
            this.Controls.Add(this.SalesTextBox);
            this.Controls.Add(this.ExpensesTextBox);
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
        private System.Windows.Forms.TextBox ExpensesTextBox;
        private System.Windows.Forms.TextBox SalesTextBox;
        private System.Windows.Forms.TextBox ProfitTextBox;
    }
}
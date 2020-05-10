namespace DBapplication
{
    partial class Manager
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
            this.Employees = new System.Windows.Forms.Button();
            this.Finances = new System.Windows.Forms.Button();
            this.Busses = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Employees
            // 
            this.Employees.Location = new System.Drawing.Point(132, 67);
            this.Employees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Employees.Name = "Employees";
            this.Employees.Size = new System.Drawing.Size(290, 54);
            this.Employees.TabIndex = 0;
            this.Employees.Text = "Employees";
            this.Employees.UseVisualStyleBackColor = true;
            this.Employees.Click += new System.EventHandler(this.Employees_Click);
            // 
            // Finances
            // 
            this.Finances.Location = new System.Drawing.Point(132, 156);
            this.Finances.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Finances.Name = "Finances";
            this.Finances.Size = new System.Drawing.Size(290, 54);
            this.Finances.TabIndex = 1;
            this.Finances.Text = "Finances";
            this.Finances.UseVisualStyleBackColor = true;
            this.Finances.Click += new System.EventHandler(this.Finances_Click);
            // 
            // Busses
            // 
            this.Busses.Location = new System.Drawing.Point(132, 247);
            this.Busses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Busses.Name = "Busses";
            this.Busses.Size = new System.Drawing.Size(290, 54);
            this.Busses.TabIndex = 2;
            this.Busses.Text = "Busses";
            this.Busses.UseVisualStyleBackColor = true;
            this.Busses.Click += new System.EventHandler(this.Busses_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 341);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Statistics";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_statistics_click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Busses);
            this.Controls.Add(this.Finances);
            this.Controls.Add(this.Employees);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Manager";
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Employees;
        private System.Windows.Forms.Button Finances;
        private System.Windows.Forms.Button Busses;
        private System.Windows.Forms.Button button1;
    }
}
﻿namespace DBapplication
{
    partial class Admin
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Manager_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Marketing";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Marketing_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Other Employees";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Other_Employees_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sales";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Sales_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(211, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tack Designer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Track_Designer_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(366, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 57);
            this.button6.TabIndex = 5;
            this.button6.Text = "Driver";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Driver_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(564, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 57);
            this.button7.TabIndex = 6;
            this.button7.Text = "Make Admin";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Make_Admin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a Username to Make Admin";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 224);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
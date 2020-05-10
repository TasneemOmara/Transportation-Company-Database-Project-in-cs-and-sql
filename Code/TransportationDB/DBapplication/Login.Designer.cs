﻿namespace DBapplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBx_pass = new System.Windows.Forms.TextBox();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.TxtBx_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_customer = new System.Windows.Forms.Button();
            this.button1_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(417, 74);
            this.TxtBx_pass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_pass.TabIndex = 2;
            // 
            // Btn_Login
            // 
            this.Btn_Login.AutoEllipsis = true;
            this.Btn_Login.Location = new System.Drawing.Point(311, 121);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(234, 28);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "&Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(417, 23);
            this.TxtBx_username.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(132, 22);
            this.TxtBx_username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1_customer
            // 
            this.button1_customer.AutoEllipsis = true;
            this.button1_customer.Location = new System.Drawing.Point(311, 231);
            this.button1_customer.Margin = new System.Windows.Forms.Padding(4);
            this.button1_customer.Name = "button1_customer";
            this.button1_customer.Size = new System.Drawing.Size(234, 46);
            this.button1_customer.TabIndex = 6;
            this.button1_customer.Text = "&I am a Customer";
            this.button1_customer.UseVisualStyleBackColor = true;
            this.button1_customer.Click += new System.EventHandler(this.button1_customer_Click);
            // 
            // button1_signup
            // 
            this.button1_signup.AutoEllipsis = true;
            this.button1_signup.Location = new System.Drawing.Point(311, 172);
            this.button1_signup.Margin = new System.Windows.Forms.Padding(4);
            this.button1_signup.Name = "button1_signup";
            this.button1_signup.Size = new System.Drawing.Size(234, 43);
            this.button1_signup.TabIndex = 7;
            this.button1_signup.Text = "&Don\'t have an account? Sign Up!";
            this.button1_signup.UseVisualStyleBackColor = true;
            this.button1_signup.Click += new System.EventHandler(this.button1_signup_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 315);
            this.Controls.Add(this.button1_signup);
            this.Controls.Add(this.button1_customer);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBx_pass;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.TextBox TxtBx_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_customer;
        private System.Windows.Forms.Button button1_signup;
    }
}
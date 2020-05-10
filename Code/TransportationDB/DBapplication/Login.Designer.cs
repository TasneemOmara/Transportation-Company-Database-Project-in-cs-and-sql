namespace DBapplication
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
            this.Modify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // TxtBx_pass
            // 
            this.TxtBx_pass.Location = new System.Drawing.Point(313, 60);
            this.TxtBx_pass.Name = "TxtBx_pass";
            this.TxtBx_pass.PasswordChar = '*';
            this.TxtBx_pass.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_pass.TabIndex = 2;
            // 
            // Btn_Login
            // 
            this.Btn_Login.AutoEllipsis = true;
            this.Btn_Login.Location = new System.Drawing.Point(233, 98);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(176, 23);
            this.Btn_Login.TabIndex = 3;
            this.Btn_Login.Text = "&Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // TxtBx_username
            // 
            this.TxtBx_username.Location = new System.Drawing.Point(313, 19);
            this.TxtBx_username.Name = "TxtBx_username";
            this.TxtBx_username.Size = new System.Drawing.Size(100, 20);
            this.TxtBx_username.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1_customer
            // 
            this.button1_customer.AutoEllipsis = true;
            this.button1_customer.Location = new System.Drawing.Point(233, 188);
            this.button1_customer.Name = "button1_customer";
            this.button1_customer.Size = new System.Drawing.Size(176, 37);
            this.button1_customer.TabIndex = 6;
            this.button1_customer.Text = "&I am a Customer";
            this.button1_customer.UseVisualStyleBackColor = true;
            this.button1_customer.Click += new System.EventHandler(this.button1_customer_Click);
            // 
            // button1_signup
            // 
            this.button1_signup.AutoEllipsis = true;
            this.button1_signup.Location = new System.Drawing.Point(233, 140);
            this.button1_signup.Name = "button1_signup";
            this.button1_signup.Size = new System.Drawing.Size(176, 35);
            this.button1_signup.TabIndex = 7;
            this.button1_signup.Text = "&Don\'t have an account? Sign Up!";
            this.button1_signup.UseVisualStyleBackColor = true;
            this.button1_signup.Click += new System.EventHandler(this.button1_signup_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(233, 231);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(176, 28);
            this.Modify.TabIndex = 8;
            this.Modify.Text = "Modify Passwords";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Password_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(476, 271);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.button1_signup);
            this.Controls.Add(this.button1_customer);
            this.Controls.Add(this.TxtBx_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.TxtBx_pass);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button Modify;
    }
}
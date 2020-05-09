namespace DBapplication
{
    partial class UserSignUp
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
            this.button1_signup = new System.Windows.Forms.Button();
            this.textBox1_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1_pos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_signup
            // 
            this.button1_signup.Location = new System.Drawing.Point(112, 327);
            this.button1_signup.Name = "button1_signup";
            this.button1_signup.Size = new System.Drawing.Size(207, 60);
            this.button1_signup.TabIndex = 0;
            this.button1_signup.Text = "&Sign Up";
            this.button1_signup.UseVisualStyleBackColor = true;
            this.button1_signup.Click += new System.EventHandler(this.button1_signup_Click);
            // 
            // textBox1_username
            // 
            this.textBox1_username.Location = new System.Drawing.Point(219, 149);
            this.textBox1_username.Name = "textBox1_username";
            this.textBox1_username.Size = new System.Drawing.Size(157, 22);
            this.textBox1_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(219, 200);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.Size = new System.Drawing.Size(157, 22);
            this.textBox2_password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position";
            // 
            // comboBox1_pos
            // 
            this.comboBox1_pos.FormattingEnabled = true;
            this.comboBox1_pos.Location = new System.Drawing.Point(219, 251);
            this.comboBox1_pos.Name = "comboBox1_pos";
            this.comboBox1_pos.Size = new System.Drawing.Size(157, 24);
            this.comboBox1_pos.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(163, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sign Up";
            // 
            // UserSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 510);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1_pos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_username);
            this.Controls.Add(this.button1_signup);
            this.Name = "UserSignUp";
            this.Text = "UserSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_signup;
        private System.Windows.Forms.TextBox textBox1_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1_pos;
        private System.Windows.Forms.Label label4;
    }
}
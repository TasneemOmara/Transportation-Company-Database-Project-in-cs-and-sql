namespace DBapplication
{
    partial class TracksDesigner
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
            this.button1_addstation = new System.Windows.Forms.Button();
            this.textBox1_addStation = new System.Windows.Forms.TextBox();
            this.button2_addATrack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2_trackID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1_DT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2_station1 = new System.Windows.Forms.ComboBox();
            this.comboBox3_station2 = new System.Windows.Forms.ComboBox();
            this.comboBox4_station3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox5_at3 = new System.Windows.Forms.ComboBox();
            this.comboBox6_at2 = new System.Windows.Forms.ComboBox();
            this.comboBox7_at1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3_price = new System.Windows.Forms.TextBox();
            this.button5_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_addstation
            // 
            this.button1_addstation.Location = new System.Drawing.Point(92, 67);
            this.button1_addstation.Name = "button1_addstation";
            this.button1_addstation.Size = new System.Drawing.Size(180, 39);
            this.button1_addstation.TabIndex = 0;
            this.button1_addstation.Text = "Add a Station";
            this.button1_addstation.UseVisualStyleBackColor = true;
            this.button1_addstation.Click += new System.EventHandler(this.button1_addstation_Click);
            // 
            // textBox1_addStation
            // 
            this.textBox1_addStation.Location = new System.Drawing.Point(347, 75);
            this.textBox1_addStation.Name = "textBox1_addStation";
            this.textBox1_addStation.Size = new System.Drawing.Size(194, 22);
            this.textBox1_addStation.TabIndex = 1;
            // 
            // button2_addATrack
            // 
            this.button2_addATrack.Location = new System.Drawing.Point(92, 514);
            this.button2_addATrack.Name = "button2_addATrack";
            this.button2_addATrack.Size = new System.Drawing.Size(180, 39);
            this.button2_addATrack.TabIndex = 2;
            this.button2_addATrack.Text = "Add a Track";
            this.button2_addATrack.UseVisualStyleBackColor = true;
            this.button2_addATrack.Click += new System.EventHandler(this.button2_addATrack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Track ID";
            // 
            // textBox2_trackID
            // 
            this.textBox2_trackID.Location = new System.Drawing.Point(206, 213);
            this.textBox2_trackID.Name = "textBox2_trackID";
            this.textBox2_trackID.Size = new System.Drawing.Size(194, 22);
            this.textBox2_trackID.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(206, 262);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(285, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depature Date";
            // 
            // comboBox1_DT
            // 
            this.comboBox1_DT.FormattingEnabled = true;
            this.comboBox1_DT.Location = new System.Drawing.Point(239, 310);
            this.comboBox1_DT.Name = "comboBox1_DT";
            this.comboBox1_DT.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_DT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Departure Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Second Station";
            // 
            // comboBox2_station1
            // 
            this.comboBox2_station1.FormattingEnabled = true;
            this.comboBox2_station1.Location = new System.Drawing.Point(239, 359);
            this.comboBox2_station1.Name = "comboBox2_station1";
            this.comboBox2_station1.Size = new System.Drawing.Size(121, 24);
            this.comboBox2_station1.TabIndex = 12;
            // 
            // comboBox3_station2
            // 
            this.comboBox3_station2.FormattingEnabled = true;
            this.comboBox3_station2.Location = new System.Drawing.Point(239, 412);
            this.comboBox3_station2.Name = "comboBox3_station2";
            this.comboBox3_station2.Size = new System.Drawing.Size(121, 24);
            this.comboBox3_station2.TabIndex = 13;
            // 
            // comboBox4_station3
            // 
            this.comboBox4_station3.FormattingEnabled = true;
            this.comboBox4_station3.Location = new System.Drawing.Point(239, 463);
            this.comboBox4_station3.Name = "comboBox4_station3";
            this.comboBox4_station3.Size = new System.Drawing.Size(121, 24);
            this.comboBox4_station3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Third Station";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Arrival Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Arrival Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Arrival Time";
            // 
            // comboBox5_at3
            // 
            this.comboBox5_at3.FormattingEnabled = true;
            this.comboBox5_at3.Location = new System.Drawing.Point(598, 463);
            this.comboBox5_at3.Name = "comboBox5_at3";
            this.comboBox5_at3.Size = new System.Drawing.Size(121, 24);
            this.comboBox5_at3.TabIndex = 21;
            // 
            // comboBox6_at2
            // 
            this.comboBox6_at2.FormattingEnabled = true;
            this.comboBox6_at2.Location = new System.Drawing.Point(598, 412);
            this.comboBox6_at2.Name = "comboBox6_at2";
            this.comboBox6_at2.Size = new System.Drawing.Size(121, 24);
            this.comboBox6_at2.TabIndex = 20;
            // 
            // comboBox7_at1
            // 
            this.comboBox7_at1.FormattingEnabled = true;
            this.comboBox7_at1.Location = new System.Drawing.Point(598, 359);
            this.comboBox7_at1.Name = "comboBox7_at1";
            this.comboBox7_at1.Size = new System.Drawing.Size(121, 24);
            this.comboBox7_at1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(805, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Price";
            // 
            // textBox3_price
            // 
            this.textBox3_price.Location = new System.Drawing.Point(909, 359);
            this.textBox3_price.Name = "textBox3_price";
            this.textBox3_price.Size = new System.Drawing.Size(124, 22);
            this.textBox3_price.TabIndex = 23;
            // 
            // button5_Logout
            // 
            this.button5_Logout.Location = new System.Drawing.Point(1047, 33);
            this.button5_Logout.Name = "button5_Logout";
            this.button5_Logout.Size = new System.Drawing.Size(103, 41);
            this.button5_Logout.TabIndex = 49;
            this.button5_Logout.Text = "Log Out";
            this.button5_Logout.UseVisualStyleBackColor = true;
            this.button5_Logout.Click += new System.EventHandler(this.button5_Logout_Click);
            // 
            // TracksDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 644);
            this.Controls.Add(this.button5_Logout);
            this.Controls.Add(this.textBox3_price);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox5_at3);
            this.Controls.Add(this.comboBox6_at2);
            this.Controls.Add(this.comboBox7_at1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4_station3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox3_station2);
            this.Controls.Add(this.comboBox2_station1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1_DT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2_trackID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2_addATrack);
            this.Controls.Add(this.textBox1_addStation);
            this.Controls.Add(this.button1_addstation);
            this.Name = "TracksDesigner";
            this.Text = "TracksDesigner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_addstation;
        private System.Windows.Forms.TextBox textBox1_addStation;
        private System.Windows.Forms.Button button2_addATrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2_trackID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1_DT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2_station1;
        private System.Windows.Forms.ComboBox comboBox3_station2;
        private System.Windows.Forms.ComboBox comboBox4_station3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox5_at3;
        private System.Windows.Forms.ComboBox comboBox6_at2;
        private System.Windows.Forms.ComboBox comboBox7_at1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3_price;
        private System.Windows.Forms.Button button5_Logout;
    }
}
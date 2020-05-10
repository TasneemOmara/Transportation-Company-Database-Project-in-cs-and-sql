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
            this.textBox2_addstation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1_LogOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_addstation
            // 
            this.button1_addstation.Location = new System.Drawing.Point(489, 27);
            this.button1_addstation.Margin = new System.Windows.Forms.Padding(2);
            this.button1_addstation.Name = "button1_addstation";
            this.button1_addstation.Size = new System.Drawing.Size(144, 63);
            this.button1_addstation.TabIndex = 0;
            this.button1_addstation.Text = "Add a Station";
            this.button1_addstation.UseVisualStyleBackColor = true;
            this.button1_addstation.Click += new System.EventHandler(this.button1_addstation_Click);
            // 
            // textBox1_addStation
            // 
            this.textBox1_addStation.Location = new System.Drawing.Point(143, 27);
            this.textBox1_addStation.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1_addStation.Name = "textBox1_addStation";
            this.textBox1_addStation.Size = new System.Drawing.Size(313, 20);
            this.textBox1_addStation.TabIndex = 1;
            // 
            // button2_addATrack
            // 
            this.button2_addATrack.Location = new System.Drawing.Point(19, 461);
            this.button2_addATrack.Margin = new System.Windows.Forms.Padding(2);
            this.button2_addATrack.Name = "button2_addATrack";
            this.button2_addATrack.Size = new System.Drawing.Size(342, 65);
            this.button2_addATrack.TabIndex = 2;
            this.button2_addATrack.Text = "Add a Track";
            this.button2_addATrack.UseVisualStyleBackColor = true;
            this.button2_addATrack.Click += new System.EventHandler(this.button2_addATrack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Track ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2_trackID
            // 
            this.textBox2_trackID.Location = new System.Drawing.Point(92, 73);
            this.textBox2_trackID.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2_trackID.Name = "textBox2_trackID";
            this.textBox2_trackID.Size = new System.Drawing.Size(144, 20);
            this.textBox2_trackID.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(127, 38);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Depature Date";
            // 
            // comboBox1_DT
            // 
            this.comboBox1_DT.FormattingEnabled = true;
            this.comboBox1_DT.Location = new System.Drawing.Point(127, 77);
            this.comboBox1_DT.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1_DT.Name = "comboBox1_DT";
            this.comboBox1_DT.Size = new System.Drawing.Size(215, 21);
            this.comboBox1_DT.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Departure Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Second Station";
            // 
            // comboBox2_station1
            // 
            this.comboBox2_station1.FormattingEnabled = true;
            this.comboBox2_station1.Location = new System.Drawing.Point(127, 33);
            this.comboBox2_station1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2_station1.Name = "comboBox2_station1";
            this.comboBox2_station1.Size = new System.Drawing.Size(215, 21);
            this.comboBox2_station1.TabIndex = 12;
            // 
            // comboBox3_station2
            // 
            this.comboBox3_station2.FormattingEnabled = true;
            this.comboBox3_station2.Location = new System.Drawing.Point(127, 76);
            this.comboBox3_station2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3_station2.Name = "comboBox3_station2";
            this.comboBox3_station2.Size = new System.Drawing.Size(215, 21);
            this.comboBox3_station2.TabIndex = 13;
            // 
            // comboBox4_station3
            // 
            this.comboBox4_station3.FormattingEnabled = true;
            this.comboBox4_station3.Location = new System.Drawing.Point(127, 117);
            this.comboBox4_station3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4_station3.Name = "comboBox4_station3";
            this.comboBox4_station3.Size = new System.Drawing.Size(215, 21);
            this.comboBox4_station3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Third Station";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Arrival Time";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(413, 79);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Arrival Time";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(413, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Arrival Time";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox5_at3
            // 
            this.comboBox5_at3.FormattingEnabled = true;
            this.comboBox5_at3.Location = new System.Drawing.Point(489, 117);
            this.comboBox5_at3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox5_at3.Name = "comboBox5_at3";
            this.comboBox5_at3.Size = new System.Drawing.Size(144, 21);
            this.comboBox5_at3.TabIndex = 21;
            this.comboBox5_at3.SelectedIndexChanged += new System.EventHandler(this.comboBox5_at3_SelectedIndexChanged);
            // 
            // comboBox6_at2
            // 
            this.comboBox6_at2.FormattingEnabled = true;
            this.comboBox6_at2.Location = new System.Drawing.Point(489, 76);
            this.comboBox6_at2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox6_at2.Name = "comboBox6_at2";
            this.comboBox6_at2.Size = new System.Drawing.Size(144, 21);
            this.comboBox6_at2.TabIndex = 20;
            this.comboBox6_at2.SelectedIndexChanged += new System.EventHandler(this.comboBox6_at2_SelectedIndexChanged);
            // 
            // comboBox7_at1
            // 
            this.comboBox7_at1.FormattingEnabled = true;
            this.comboBox7_at1.Location = new System.Drawing.Point(489, 33);
            this.comboBox7_at1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox7_at1.Name = "comboBox7_at1";
            this.comboBox7_at1.Size = new System.Drawing.Size(144, 21);
            this.comboBox7_at1.TabIndex = 19;
            this.comboBox7_at1.SelectedIndexChanged += new System.EventHandler(this.comboBox7_at1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Price";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox3_price
            // 
            this.textBox3_price.Location = new System.Drawing.Point(92, 33);
            this.textBox3_price.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3_price.Name = "textBox3_price";
            this.textBox3_price.Size = new System.Drawing.Size(144, 20);
            this.textBox3_price.TabIndex = 23;
            // 
            // textBox2_addstation
            // 
            this.textBox2_addstation.Location = new System.Drawing.Point(143, 70);
            this.textBox2_addstation.Name = "textBox2_addstation";
            this.textBox2_addstation.Size = new System.Drawing.Size(313, 20);
            this.textBox2_addstation.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "New Station Location";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "New Station Name";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1_DT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 121);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departure Date and Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1_addStation);
            this.groupBox2.Controls.Add(this.button1_addstation);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox2_addstation);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(19, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 114);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Station";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox7_at1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox6_at2);
            this.groupBox3.Controls.Add(this.comboBox4_station3);
            this.groupBox3.Controls.Add(this.comboBox5_at3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBox3_station2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBox2_station1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(19, 278);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(662, 161);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arrival Time and Track Stations";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3_price);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox2_trackID);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(416, 141);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(265, 121);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Departure Date and Time";
            // 
            // button1_LogOut
            // 
            this.button1_LogOut.Location = new System.Drawing.Point(435, 461);
            this.button1_LogOut.Margin = new System.Windows.Forms.Padding(2);
            this.button1_LogOut.Name = "button1_LogOut";
            this.button1_LogOut.Size = new System.Drawing.Size(217, 65);
            this.button1_LogOut.TabIndex = 29;
            this.button1_LogOut.Text = "Log Out";
            this.button1_LogOut.UseVisualStyleBackColor = true;
            // 
            // TracksDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 542);
            this.Controls.Add(this.button1_LogOut);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2_addATrack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TracksDesigner";
            this.Text = "TracksDesigner";
            this.Load += new System.EventHandler(this.TracksDesigner_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox2_addstation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1_LogOut;

    }
}
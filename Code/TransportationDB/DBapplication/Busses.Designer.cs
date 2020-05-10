namespace DBapplication
{
    partial class Busses
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
            this.ComboBox_Stations_ArrivalTime = new System.Windows.Forms.ComboBox();
            this.ComboBox_TrackID_AT = new System.Windows.Forms.ComboBox();
            this.Combobox_trackID_ReservedSeats = new System.Windows.Forms.ComboBox();
            this.ComboBox_BusNum_ReservedSeats = new System.Windows.Forms.ComboBox();
            this.ComboBox_TrackID_DT = new System.Windows.Forms.ComboBox();
            this.TracksInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1_Reset = new System.Windows.Forms.Button();
            this.dateTimePicker1AT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2DT = new System.Windows.Forms.DateTimePicker();
            this.button1_TrackBusses = new System.Windows.Forms.Button();
            this.button1_getBusses = new System.Windows.Forms.Button();
            this.button1_getstations = new System.Windows.Forms.Button();
            this.Departure = new System.Windows.Forms.Button();
            this.Arrival = new System.Windows.Forms.Button();
            this.ReservedSeats = new System.Windows.Forms.Button();
            this.textBox1_Reserved = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1_bus_lastmaintained = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1_lastmain = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button2_maintainer = new System.Windows.Forms.Button();
            this.textBox1_maintainer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_Stations_ArrivalTime
            // 
            this.ComboBox_Stations_ArrivalTime.FormattingEnabled = true;
            this.ComboBox_Stations_ArrivalTime.Location = new System.Drawing.Point(378, 500);
            this.ComboBox_Stations_ArrivalTime.Name = "ComboBox_Stations_ArrivalTime";
            this.ComboBox_Stations_ArrivalTime.Size = new System.Drawing.Size(156, 24);
            this.ComboBox_Stations_ArrivalTime.TabIndex = 3;
            // 
            // ComboBox_TrackID_AT
            // 
            this.ComboBox_TrackID_AT.FormattingEnabled = true;
            this.ComboBox_TrackID_AT.Location = new System.Drawing.Point(27, 500);
            this.ComboBox_TrackID_AT.Name = "ComboBox_TrackID_AT";
            this.ComboBox_TrackID_AT.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_TrackID_AT.TabIndex = 4;
            // 
            // Combobox_trackID_ReservedSeats
            // 
            this.Combobox_trackID_ReservedSeats.FormattingEnabled = true;
            this.Combobox_trackID_ReservedSeats.Location = new System.Drawing.Point(27, 413);
            this.Combobox_trackID_ReservedSeats.Name = "Combobox_trackID_ReservedSeats";
            this.Combobox_trackID_ReservedSeats.Size = new System.Drawing.Size(121, 24);
            this.Combobox_trackID_ReservedSeats.TabIndex = 6;
            // 
            // ComboBox_BusNum_ReservedSeats
            // 
            this.ComboBox_BusNum_ReservedSeats.FormattingEnabled = true;
            this.ComboBox_BusNum_ReservedSeats.Location = new System.Drawing.Point(378, 413);
            this.ComboBox_BusNum_ReservedSeats.Name = "ComboBox_BusNum_ReservedSeats";
            this.ComboBox_BusNum_ReservedSeats.Size = new System.Drawing.Size(156, 24);
            this.ComboBox_BusNum_ReservedSeats.TabIndex = 7;
            // 
            // ComboBox_TrackID_DT
            // 
            this.ComboBox_TrackID_DT.FormattingEnabled = true;
            this.ComboBox_TrackID_DT.Location = new System.Drawing.Point(27, 587);
            this.ComboBox_TrackID_DT.Name = "ComboBox_TrackID_DT";
            this.ComboBox_TrackID_DT.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_TrackID_DT.TabIndex = 11;
            // 
            // TracksInfo
            // 
            this.TracksInfo.Location = new System.Drawing.Point(38, 33);
            this.TracksInfo.Name = "TracksInfo";
            this.TracksInfo.Size = new System.Drawing.Size(285, 55);
            this.TracksInfo.TabIndex = 15;
            this.TracksInfo.Text = "Get All Tracks, Busses, Stations Information";
            this.TracksInfo.UseVisualStyleBackColor = true;
            this.TracksInfo.Click += new System.EventHandler(this.TracksInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 233);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(973, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reserved Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(984, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(973, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Departure Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Track ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Bus Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Track ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 567);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Track ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Stations Number";
            // 
            // button1_Reset
            // 
            this.button1_Reset.Location = new System.Drawing.Point(653, 33);
            this.button1_Reset.Name = "button1_Reset";
            this.button1_Reset.Size = new System.Drawing.Size(285, 55);
            this.button1_Reset.TabIndex = 25;
            this.button1_Reset.Text = "Reset Fields";
            this.button1_Reset.UseVisualStyleBackColor = true;
            this.button1_Reset.Click += new System.EventHandler(this.button1_Reset_Click);
            // 
            // dateTimePicker1AT
            // 
            this.dateTimePicker1AT.Location = new System.Drawing.Point(932, 500);
            this.dateTimePicker1AT.Name = "dateTimePicker1AT";
            this.dateTimePicker1AT.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1AT.TabIndex = 26;
            // 
            // dateTimePicker2DT
            // 
            this.dateTimePicker2DT.Location = new System.Drawing.Point(932, 589);
            this.dateTimePicker2DT.Name = "dateTimePicker2DT";
            this.dateTimePicker2DT.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2DT.TabIndex = 27;
            // 
            // button1_TrackBusses
            // 
            this.button1_TrackBusses.Location = new System.Drawing.Point(352, 33);
            this.button1_TrackBusses.Name = "button1_TrackBusses";
            this.button1_TrackBusses.Size = new System.Drawing.Size(285, 55);
            this.button1_TrackBusses.TabIndex = 28;
            this.button1_TrackBusses.Text = "Get All Tracks, Busses Information";
            this.button1_TrackBusses.UseVisualStyleBackColor = true;
            this.button1_TrackBusses.Click += new System.EventHandler(this.button1_TrackBusses_Click);
            // 
            // button1_getBusses
            // 
            this.button1_getBusses.Location = new System.Drawing.Point(170, 405);
            this.button1_getBusses.Name = "button1_getBusses";
            this.button1_getBusses.Size = new System.Drawing.Size(184, 39);
            this.button1_getBusses.TabIndex = 29;
            this.button1_getBusses.Text = "Get Busses In this Track";
            this.button1_getBusses.UseVisualStyleBackColor = true;
            this.button1_getBusses.Click += new System.EventHandler(this.button1_getBusses_Click);
            // 
            // button1_getstations
            // 
            this.button1_getstations.Location = new System.Drawing.Point(170, 494);
            this.button1_getstations.Name = "button1_getstations";
            this.button1_getstations.Size = new System.Drawing.Size(184, 39);
            this.button1_getstations.TabIndex = 30;
            this.button1_getstations.Text = "Get Stations In this Track";
            this.button1_getstations.UseVisualStyleBackColor = true;
            this.button1_getstations.Click += new System.EventHandler(this.button1_getstations_Click);
            // 
            // Departure
            // 
            this.Departure.Location = new System.Drawing.Point(576, 571);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(285, 55);
            this.Departure.TabIndex = 33;
            this.Departure.Text = "Departure Time of a Given Ride";
            this.Departure.UseVisualStyleBackColor = true;
            this.Departure.Click += new System.EventHandler(this.Departure_Click_1);
            // 
            // Arrival
            // 
            this.Arrival.Location = new System.Drawing.Point(576, 484);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(285, 55);
            this.Arrival.TabIndex = 32;
            this.Arrival.Text = "Arrival Time in a Station of a Given Ride";
            this.Arrival.UseVisualStyleBackColor = true;
            this.Arrival.Click += new System.EventHandler(this.Arrival_Click);
            // 
            // ReservedSeats
            // 
            this.ReservedSeats.Location = new System.Drawing.Point(576, 397);
            this.ReservedSeats.Name = "ReservedSeats";
            this.ReservedSeats.Size = new System.Drawing.Size(285, 55);
            this.ReservedSeats.TabIndex = 31;
            this.ReservedSeats.Text = "Reserved Seats in a given ride";
            this.ReservedSeats.UseVisualStyleBackColor = true;
            this.ReservedSeats.Click += new System.EventHandler(this.ReservedSeats_Click_1);
            // 
            // textBox1_Reserved
            // 
            this.textBox1_Reserved.Location = new System.Drawing.Point(932, 413);
            this.textBox1_Reserved.Name = "textBox1_Reserved";
            this.textBox1_Reserved.Size = new System.Drawing.Size(200, 22);
            this.textBox1_Reserved.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 645);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 54);
            this.button1.TabIndex = 35;
            this.button1.Text = "Get the Last Maintainence Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1_bus_lastmaintained
            // 
            this.comboBox1_bus_lastmaintained.FormattingEnabled = true;
            this.comboBox1_bus_lastmaintained.Location = new System.Drawing.Point(27, 653);
            this.comboBox1_bus_lastmaintained.Name = "comboBox1_bus_lastmaintained";
            this.comboBox1_bus_lastmaintained.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_bus_lastmaintained.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 633);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 37;
            this.label9.Text = "Bus Number";
            // 
            // dateTimePicker1_lastmain
            // 
            this.dateTimePicker1_lastmain.Location = new System.Drawing.Point(932, 658);
            this.dateTimePicker1_lastmain.Name = "dateTimePicker1_lastmain";
            this.dateTimePicker1_lastmain.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1_lastmain.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(961, 637);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Last Maintainence Date";
            // 
            // button2_maintainer
            // 
            this.button2_maintainer.Location = new System.Drawing.Point(170, 641);
            this.button2_maintainer.Name = "button2_maintainer";
            this.button2_maintainer.Size = new System.Drawing.Size(184, 39);
            this.button2_maintainer.TabIndex = 40;
            this.button2_maintainer.Text = "Get Maintainer";
            this.button2_maintainer.UseVisualStyleBackColor = true;
            this.button2_maintainer.Click += new System.EventHandler(this.button2_maintainer_Click);
            // 
            // textBox1_maintainer
            // 
            this.textBox1_maintainer.Location = new System.Drawing.Point(378, 653);
            this.textBox1_maintainer.Name = "textBox1_maintainer";
            this.textBox1_maintainer.Size = new System.Drawing.Size(156, 22);
            this.textBox1_maintainer.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 633);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Maintainer";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1000, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 55);
            this.button2.TabIndex = 43;
            this.button2.Text = "log out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Busses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 730);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1_maintainer);
            this.Controls.Add(this.button2_maintainer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1_lastmain);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1_bus_lastmaintained);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1_Reserved);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.Arrival);
            this.Controls.Add(this.ReservedSeats);
            this.Controls.Add(this.button1_getstations);
            this.Controls.Add(this.button1_getBusses);
            this.Controls.Add(this.button1_TrackBusses);
            this.Controls.Add(this.dateTimePicker2DT);
            this.Controls.Add(this.dateTimePicker1AT);
            this.Controls.Add(this.button1_Reset);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TracksInfo);
            this.Controls.Add(this.ComboBox_TrackID_DT);
            this.Controls.Add(this.ComboBox_BusNum_ReservedSeats);
            this.Controls.Add(this.Combobox_trackID_ReservedSeats);
            this.Controls.Add(this.ComboBox_TrackID_AT);
            this.Controls.Add(this.ComboBox_Stations_ArrivalTime);
            this.Name = "Busses";
            this.Text = "Busses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBox_Stations_ArrivalTime;
        private System.Windows.Forms.ComboBox ComboBox_TrackID_AT;
        private System.Windows.Forms.ComboBox Combobox_trackID_ReservedSeats;
        private System.Windows.Forms.ComboBox ComboBox_BusNum_ReservedSeats;
        private System.Windows.Forms.ComboBox ComboBox_TrackID_DT;
        private System.Windows.Forms.Button TracksInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1_Reset;
        private System.Windows.Forms.DateTimePicker dateTimePicker1AT;
        private System.Windows.Forms.DateTimePicker dateTimePicker2DT;
        private System.Windows.Forms.Button button1_TrackBusses;
        private System.Windows.Forms.Button button1_getBusses;
        private System.Windows.Forms.Button button1_getstations;
        private System.Windows.Forms.Button Departure;
        private System.Windows.Forms.Button Arrival;
        private System.Windows.Forms.Button ReservedSeats;
        private System.Windows.Forms.TextBox textBox1_Reserved;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1_bus_lastmaintained;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_lastmain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2_maintainer;
        private System.Windows.Forms.TextBox textBox1_maintainer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
    }
}
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
            this.ReservedSeats = new System.Windows.Forms.Button();
            this.Arrival = new System.Windows.Forms.Button();
            this.Departure = new System.Windows.Forms.Button();
            this.ComboBox_Stations_ArrivalTime = new System.Windows.Forms.ComboBox();
            this.ComboBox_TrackID_AT = new System.Windows.Forms.ComboBox();
            this.TextAT = new System.Windows.Forms.TextBox();
            this.Combobox_trackID_ReservedSeats = new System.Windows.Forms.ComboBox();
            this.ComboBox_BusNum_ReservedSeats = new System.Windows.Forms.ComboBox();
            this.TextReserved = new System.Windows.Forms.TextBox();
            this.ComboBox_TrackID_DT = new System.Windows.Forms.ComboBox();
            this.TextDepart = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservedSeats
            // 
            this.ReservedSeats.Location = new System.Drawing.Point(69, 421);
            this.ReservedSeats.Name = "ReservedSeats";
            this.ReservedSeats.Size = new System.Drawing.Size(285, 55);
            this.ReservedSeats.TabIndex = 0;
            this.ReservedSeats.Text = "Reserved Seats in a given ride";
            this.ReservedSeats.UseVisualStyleBackColor = true;
            this.ReservedSeats.Click += new System.EventHandler(this.ReservedSeats_Click);
            // 
            // Arrival
            // 
            this.Arrival.Location = new System.Drawing.Point(69, 508);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(285, 55);
            this.Arrival.TabIndex = 1;
            this.Arrival.Text = "Arrival Time in a Station of a Given Ride";
            this.Arrival.UseVisualStyleBackColor = true;
            this.Arrival.Click += new System.EventHandler(this.Arrival_Click);
            // 
            // Departure
            // 
            this.Departure.Location = new System.Drawing.Point(69, 595);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(285, 55);
            this.Departure.TabIndex = 2;
            this.Departure.Text = "Departure Time of a Given Ride";
            this.Departure.UseVisualStyleBackColor = true;
            this.Departure.Click += new System.EventHandler(this.Departure_Click);
            // 
            // ComboBox_Stations_ArrivalTime
            // 
            this.ComboBox_Stations_ArrivalTime.FormattingEnabled = true;
            this.ComboBox_Stations_ArrivalTime.Location = new System.Drawing.Point(581, 524);
            this.ComboBox_Stations_ArrivalTime.Name = "ComboBox_Stations_ArrivalTime";
            this.ComboBox_Stations_ArrivalTime.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Stations_ArrivalTime.TabIndex = 3;
            // 
            // ComboBox_TrackID_AT
            // 
            this.ComboBox_TrackID_AT.FormattingEnabled = true;
            this.ComboBox_TrackID_AT.Location = new System.Drawing.Point(413, 524);
            this.ComboBox_TrackID_AT.Name = "ComboBox_TrackID_AT";
            this.ComboBox_TrackID_AT.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_TrackID_AT.TabIndex = 4;
            // 
            // TextAT
            // 
            this.TextAT.Location = new System.Drawing.Point(832, 524);
            this.TextAT.Name = "TextAT";
            this.TextAT.Size = new System.Drawing.Size(165, 22);
            this.TextAT.TabIndex = 5;
            // 
            // Combobox_trackID_ReservedSeats
            // 
            this.Combobox_trackID_ReservedSeats.FormattingEnabled = true;
            this.Combobox_trackID_ReservedSeats.Location = new System.Drawing.Point(413, 437);
            this.Combobox_trackID_ReservedSeats.Name = "Combobox_trackID_ReservedSeats";
            this.Combobox_trackID_ReservedSeats.Size = new System.Drawing.Size(121, 24);
            this.Combobox_trackID_ReservedSeats.TabIndex = 6;
            // 
            // ComboBox_BusNum_ReservedSeats
            // 
            this.ComboBox_BusNum_ReservedSeats.FormattingEnabled = true;
            this.ComboBox_BusNum_ReservedSeats.Location = new System.Drawing.Point(581, 437);
            this.ComboBox_BusNum_ReservedSeats.Name = "ComboBox_BusNum_ReservedSeats";
            this.ComboBox_BusNum_ReservedSeats.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_BusNum_ReservedSeats.TabIndex = 7;
            // 
            // TextReserved
            // 
            this.TextReserved.Location = new System.Drawing.Point(832, 437);
            this.TextReserved.Name = "TextReserved";
            this.TextReserved.Size = new System.Drawing.Size(165, 22);
            this.TextReserved.TabIndex = 8;
            // 
            // ComboBox_TrackID_DT
            // 
            this.ComboBox_TrackID_DT.FormattingEnabled = true;
            this.ComboBox_TrackID_DT.Location = new System.Drawing.Point(413, 611);
            this.ComboBox_TrackID_DT.Name = "ComboBox_TrackID_DT";
            this.ComboBox_TrackID_DT.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_TrackID_DT.TabIndex = 11;
            // 
            // TextDepart
            // 
            this.TextDepart.Location = new System.Drawing.Point(832, 611);
            this.TextDepart.Name = "TextDepart";
            this.TextDepart.Size = new System.Drawing.Size(165, 22);
            this.TextDepart.TabIndex = 12;
            // 
            // TracksInfo
            // 
            this.TracksInfo.Location = new System.Drawing.Point(69, 33);
            this.TracksInfo.Name = "TracksInfo";
            this.TracksInfo.Size = new System.Drawing.Size(285, 55);
            this.TracksInfo.TabIndex = 15;
            this.TracksInfo.Text = "Tracks Information";
            this.TracksInfo.UseVisualStyleBackColor = true;
            this.TracksInfo.Click += new System.EventHandler(this.TracksInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 266);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Reserved Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(866, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Departure Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Track ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Bus Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Track ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 591);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Track ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bus Number";
            // 
            // button1_Reset
            // 
            this.button1_Reset.Location = new System.Drawing.Point(712, 33);
            this.button1_Reset.Name = "button1_Reset";
            this.button1_Reset.Size = new System.Drawing.Size(285, 55);
            this.button1_Reset.TabIndex = 25;
            this.button1_Reset.Text = "Reset Fields";
            this.button1_Reset.UseVisualStyleBackColor = true;
            this.button1_Reset.Click += new System.EventHandler(this.button1_Reset_Click);
            // 
            // Busses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 730);
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
            this.Controls.Add(this.TextDepart);
            this.Controls.Add(this.ComboBox_TrackID_DT);
            this.Controls.Add(this.TextReserved);
            this.Controls.Add(this.ComboBox_BusNum_ReservedSeats);
            this.Controls.Add(this.Combobox_trackID_ReservedSeats);
            this.Controls.Add(this.TextAT);
            this.Controls.Add(this.ComboBox_TrackID_AT);
            this.Controls.Add(this.ComboBox_Stations_ArrivalTime);
            this.Controls.Add(this.Departure);
            this.Controls.Add(this.Arrival);
            this.Controls.Add(this.ReservedSeats);
            this.Name = "Busses";
            this.Text = "Busses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReservedSeats;
        private System.Windows.Forms.Button Arrival;
        private System.Windows.Forms.Button Departure;
        private System.Windows.Forms.ComboBox ComboBox_Stations_ArrivalTime;
        private System.Windows.Forms.ComboBox ComboBox_TrackID_AT;
        private System.Windows.Forms.TextBox TextAT;
        private System.Windows.Forms.ComboBox Combobox_trackID_ReservedSeats;
        private System.Windows.Forms.ComboBox ComboBox_BusNum_ReservedSeats;
        private System.Windows.Forms.TextBox TextReserved;
        private System.Windows.Forms.ComboBox ComboBox_TrackID_DT;
        private System.Windows.Forms.TextBox TextDepart;
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
    }
}
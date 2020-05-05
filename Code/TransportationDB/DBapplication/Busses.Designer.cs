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
            this.StationsComboBoxAT = new System.Windows.Forms.ComboBox();
            this.TrackID_AT_ComboBox = new System.Windows.Forms.ComboBox();
            this.AT = new System.Windows.Forms.TextBox();
            this.TrackID_RS_ComboBox = new System.Windows.Forms.ComboBox();
            this.BusNum_RS_ComboBox = new System.Windows.Forms.ComboBox();
            this.Reserved = new System.Windows.Forms.TextBox();
            this.TrackID_DT_ComboBox = new System.Windows.Forms.ComboBox();
            this.Depart = new System.Windows.Forms.TextBox();
            this.TracksInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReservedSeats
            // 
            this.ReservedSeats.Location = new System.Drawing.Point(69, 402);
            this.ReservedSeats.Name = "ReservedSeats";
            this.ReservedSeats.Size = new System.Drawing.Size(285, 55);
            this.ReservedSeats.TabIndex = 0;
            this.ReservedSeats.Text = "Reserved Seats in a given ride";
            this.ReservedSeats.UseVisualStyleBackColor = true;
            this.ReservedSeats.Click += new System.EventHandler(this.ReservedSeats_Click);
            // 
            // Arrival
            // 
            this.Arrival.Location = new System.Drawing.Point(69, 489);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(285, 55);
            this.Arrival.TabIndex = 1;
            this.Arrival.Text = "Arrival Time in a Station of a Given Ride";
            this.Arrival.UseVisualStyleBackColor = true;
            this.Arrival.Click += new System.EventHandler(this.Arrival_Click);
            // 
            // Departure
            // 
            this.Departure.Location = new System.Drawing.Point(69, 576);
            this.Departure.Name = "Departure";
            this.Departure.Size = new System.Drawing.Size(285, 55);
            this.Departure.TabIndex = 2;
            this.Departure.Text = "Departure Time of a Given Ride";
            this.Departure.UseVisualStyleBackColor = true;
            this.Departure.Click += new System.EventHandler(this.Departure_Click);
            // 
            // StationsComboBoxAT
            // 
            this.StationsComboBoxAT.FormattingEnabled = true;
            this.StationsComboBoxAT.Location = new System.Drawing.Point(413, 505);
            this.StationsComboBoxAT.Name = "StationsComboBoxAT";
            this.StationsComboBoxAT.Size = new System.Drawing.Size(121, 24);
            this.StationsComboBoxAT.TabIndex = 3;
            // 
            // TrackID_AT_ComboBox
            // 
            this.TrackID_AT_ComboBox.FormattingEnabled = true;
            this.TrackID_AT_ComboBox.Location = new System.Drawing.Point(581, 505);
            this.TrackID_AT_ComboBox.Name = "TrackID_AT_ComboBox";
            this.TrackID_AT_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.TrackID_AT_ComboBox.TabIndex = 4;
            // 
            // AT
            // 
            this.AT.Location = new System.Drawing.Point(832, 505);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(165, 22);
            this.AT.TabIndex = 5;
            // 
            // TrackID_RS_ComboBox
            // 
            this.TrackID_RS_ComboBox.FormattingEnabled = true;
            this.TrackID_RS_ComboBox.Location = new System.Drawing.Point(413, 418);
            this.TrackID_RS_ComboBox.Name = "TrackID_RS_ComboBox";
            this.TrackID_RS_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.TrackID_RS_ComboBox.TabIndex = 6;
            // 
            // BusNum_RS_ComboBox
            // 
            this.BusNum_RS_ComboBox.FormattingEnabled = true;
            this.BusNum_RS_ComboBox.Location = new System.Drawing.Point(581, 418);
            this.BusNum_RS_ComboBox.Name = "BusNum_RS_ComboBox";
            this.BusNum_RS_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.BusNum_RS_ComboBox.TabIndex = 7;
            // 
            // Reserved
            // 
            this.Reserved.Location = new System.Drawing.Point(832, 418);
            this.Reserved.Name = "Reserved";
            this.Reserved.Size = new System.Drawing.Size(165, 22);
            this.Reserved.TabIndex = 8;
            // 
            // TrackID_DT_ComboBox
            // 
            this.TrackID_DT_ComboBox.FormattingEnabled = true;
            this.TrackID_DT_ComboBox.Location = new System.Drawing.Point(413, 592);
            this.TrackID_DT_ComboBox.Name = "TrackID_DT_ComboBox";
            this.TrackID_DT_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.TrackID_DT_ComboBox.TabIndex = 11;
            // 
            // Depart
            // 
            this.Depart.Location = new System.Drawing.Point(832, 592);
            this.Depart.Name = "Depart";
            this.Depart.Size = new System.Drawing.Size(165, 22);
            this.Depart.TabIndex = 12;
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
            // Busses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TracksInfo);
            this.Controls.Add(this.Depart);
            this.Controls.Add(this.TrackID_DT_ComboBox);
            this.Controls.Add(this.Reserved);
            this.Controls.Add(this.BusNum_RS_ComboBox);
            this.Controls.Add(this.TrackID_RS_ComboBox);
            this.Controls.Add(this.AT);
            this.Controls.Add(this.TrackID_AT_ComboBox);
            this.Controls.Add(this.StationsComboBoxAT);
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
        private System.Windows.Forms.ComboBox StationsComboBoxAT;
        private System.Windows.Forms.ComboBox TrackID_AT_ComboBox;
        private System.Windows.Forms.TextBox AT;
        private System.Windows.Forms.ComboBox TrackID_RS_ComboBox;
        private System.Windows.Forms.ComboBox BusNum_RS_ComboBox;
        private System.Windows.Forms.TextBox Reserved;
        private System.Windows.Forms.ComboBox TrackID_DT_ComboBox;
        private System.Windows.Forms.TextBox Depart;
        private System.Windows.Forms.Button TracksInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
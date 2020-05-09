namespace DBapplication
{
    partial class Customer
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1_pickUp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2_dropOff = new System.Windows.Forms.ComboBox();
            this.button1_avTracks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3_trackID = new System.Windows.Forms.ComboBox();
            this.button2_book = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_boardingPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1_tracksByDate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1_pickUp
            // 
            this.comboBox1_pickUp.FormattingEnabled = true;
            this.comboBox1_pickUp.Location = new System.Drawing.Point(63, 21);
            this.comboBox1_pickUp.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1_pickUp.Name = "comboBox1_pickUp";
            this.comboBox1_pickUp.Size = new System.Drawing.Size(129, 21);
            this.comboBox1_pickUp.TabIndex = 1;
            this.comboBox1_pickUp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_pickUp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drop off ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2_dropOff
            // 
            this.comboBox2_dropOff.FormattingEnabled = true;
            this.comboBox2_dropOff.Location = new System.Drawing.Point(63, 54);
            this.comboBox2_dropOff.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2_dropOff.Name = "comboBox2_dropOff";
            this.comboBox2_dropOff.Size = new System.Drawing.Size(129, 21);
            this.comboBox2_dropOff.TabIndex = 3;
            this.comboBox2_dropOff.SelectedIndexChanged += new System.EventHandler(this.comboBox2_dropOff_SelectedIndexChanged);
            // 
            // button1_avTracks
            // 
            this.button1_avTracks.Location = new System.Drawing.Point(7, 85);
            this.button1_avTracks.Margin = new System.Windows.Forms.Padding(2);
            this.button1_avTracks.Name = "button1_avTracks";
            this.button1_avTracks.Size = new System.Drawing.Size(186, 24);
            this.button1_avTracks.TabIndex = 4;
            this.button1_avTracks.Text = "Get Available Tracks by location";
            this.button1_avTracks.UseVisualStyleBackColor = true;
            this.button1_avTracks.Click += new System.EventHandler(this.button1_avTracks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 64);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(445, 364);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select the Desired Track ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox3_trackID
            // 
            this.comboBox3_trackID.FormattingEnabled = true;
            this.comboBox3_trackID.Location = new System.Drawing.Point(166, 262);
            this.comboBox3_trackID.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3_trackID.Name = "comboBox3_trackID";
            this.comboBox3_trackID.Size = new System.Drawing.Size(92, 21);
            this.comboBox3_trackID.TabIndex = 8;
            this.comboBox3_trackID.SelectedIndexChanged += new System.EventHandler(this.comboBox3_trackID_SelectedIndexChanged);
            // 
            // button2_book
            // 
            this.button2_book.Location = new System.Drawing.Point(19, 332);
            this.button2_book.Margin = new System.Windows.Forms.Padding(2);
            this.button2_book.Name = "button2_book";
            this.button2_book.Size = new System.Drawing.Size(170, 96);
            this.button2_book.TabIndex = 9;
            this.button2_book.Text = "Book Ride";
            this.button2_book.UseVisualStyleBackColor = true;
            this.button2_book.Click += new System.EventHandler(this.button2_book_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 473);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Boarding Pass";
            // 
            // textBox1_boardingPass
            // 
            this.textBox1_boardingPass.Location = new System.Drawing.Point(233, 470);
            this.textBox1_boardingPass.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1_boardingPass.Name = "textBox1_boardingPass";
            this.textBox1_boardingPass.Size = new System.Drawing.Size(76, 20);
            this.textBox1_boardingPass.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tracks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select Trip Day";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1_tracksByDate
            // 
            this.button1_tracksByDate.Location = new System.Drawing.Point(6, 85);
            this.button1_tracksByDate.Margin = new System.Windows.Forms.Padding(2);
            this.button1_tracksByDate.Name = "button1_tracksByDate";
            this.button1_tracksByDate.Size = new System.Drawing.Size(188, 24);
            this.button1_tracksByDate.TabIndex = 17;
            this.button1_tracksByDate.Text = "Get Available Tracks by Date";
            this.button1_tracksByDate.UseVisualStyleBackColor = true;
            this.button1_tracksByDate.Click += new System.EventHandler(this.button1_tracksByDate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(130, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Use New Promo-Code";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(10, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(149, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Use Previous Promo-Code";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(233, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 103);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promo-Code";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Welcome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Phone No.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1_tracksByDate);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(10, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search By Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1_pickUp);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox2_dropOff);
            this.groupBox3.Controls.Add(this.button1_avTracks);
            this.groupBox3.Location = new System.Drawing.Point(213, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 117);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Narrow Down Results By Stations";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 529);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1_boardingPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2_book);
            this.Controls.Add(this.comboBox3_trackID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1_pickUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2_dropOff;
        private System.Windows.Forms.Button button1_avTracks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3_trackID;
        private System.Windows.Forms.Button button2_book;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_boardingPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1_tracksByDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}
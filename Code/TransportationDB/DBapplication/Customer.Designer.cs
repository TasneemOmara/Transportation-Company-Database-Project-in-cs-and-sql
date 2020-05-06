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
            this.button3_promo = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_boardingPass = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1_tracksByDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick Up";
            // 
            // comboBox1_pickUp
            // 
            this.comboBox1_pickUp.FormattingEnabled = true;
            this.comboBox1_pickUp.Location = new System.Drawing.Point(131, 92);
            this.comboBox1_pickUp.Name = "comboBox1_pickUp";
            this.comboBox1_pickUp.Size = new System.Drawing.Size(121, 24);
            this.comboBox1_pickUp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drop off ";
            // 
            // comboBox2_dropOff
            // 
            this.comboBox2_dropOff.FormattingEnabled = true;
            this.comboBox2_dropOff.Location = new System.Drawing.Point(131, 139);
            this.comboBox2_dropOff.Name = "comboBox2_dropOff";
            this.comboBox2_dropOff.Size = new System.Drawing.Size(121, 24);
            this.comboBox2_dropOff.TabIndex = 3;
            // 
            // button1_avTracks
            // 
            this.button1_avTracks.Location = new System.Drawing.Point(25, 189);
            this.button1_avTracks.Name = "button1_avTracks";
            this.button1_avTracks.Size = new System.Drawing.Size(227, 30);
            this.button1_avTracks.TabIndex = 4;
            this.button1_avTracks.Text = "Get Available Tracks by location";
            this.button1_avTracks.UseVisualStyleBackColor = true;
            this.button1_avTracks.Click += new System.EventHandler(this.button1_avTracks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(583, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 448);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Track ID";
            // 
            // comboBox3_trackID
            // 
            this.comboBox3_trackID.FormattingEnabled = true;
            this.comboBox3_trackID.Location = new System.Drawing.Point(215, 329);
            this.comboBox3_trackID.Name = "comboBox3_trackID";
            this.comboBox3_trackID.Size = new System.Drawing.Size(121, 24);
            this.comboBox3_trackID.TabIndex = 8;
            // 
            // button2_book
            // 
            this.button2_book.Location = new System.Drawing.Point(73, 386);
            this.button2_book.Name = "button2_book";
            this.button2_book.Size = new System.Drawing.Size(158, 30);
            this.button2_book.TabIndex = 9;
            this.button2_book.Text = "Book Ride";
            this.button2_book.UseVisualStyleBackColor = true;
            this.button2_book.Click += new System.EventHandler(this.button2_book_Click);
            // 
            // button3_promo
            // 
            this.button3_promo.Location = new System.Drawing.Point(93, 532);
            this.button3_promo.Name = "button3_promo";
            this.button3_promo.Size = new System.Drawing.Size(279, 30);
            this.button3_promo.TabIndex = 10;
            this.button3_promo.Text = "Retrieve Promo Code if Available";
            this.button3_promo.UseVisualStyleBackColor = true;
            this.button3_promo.Click += new System.EventHandler(this.button3_promo_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(300, 395);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Use Promo Code";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Boarding Pass";
            // 
            // textBox1_boardingPass
            // 
            this.textBox1_boardingPass.Location = new System.Drawing.Point(272, 436);
            this.textBox1_boardingPass.Name = "textBox1_boardingPass";
            this.textBox1_boardingPass.Size = new System.Drawing.Size(100, 22);
            this.textBox1_boardingPass.TabIndex = 13;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(392, 116);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(846, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tracks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Date";
            // 
            // button1_tracksByDate
            // 
            this.button1_tracksByDate.Location = new System.Drawing.Point(355, 189);
            this.button1_tracksByDate.Name = "button1_tracksByDate";
            this.button1_tracksByDate.Size = new System.Drawing.Size(158, 30);
            this.button1_tracksByDate.TabIndex = 17;
            this.button1_tracksByDate.Text = "Get Available Tracks by Date";
            this.button1_tracksByDate.UseVisualStyleBackColor = true;
            this.button1_tracksByDate.Click += new System.EventHandler(this.button1_tracksByDate_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 651);
            this.Controls.Add(this.button1_tracksByDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.textBox1_boardingPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3_promo);
            this.Controls.Add(this.button2_book);
            this.Controls.Add(this.comboBox3_trackID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_avTracks);
            this.Controls.Add(this.comboBox2_dropOff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1_pickUp);
            this.Controls.Add(this.label1);
            this.Name = "Customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button button3_promo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_boardingPass;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1_tracksByDate;
    }
}
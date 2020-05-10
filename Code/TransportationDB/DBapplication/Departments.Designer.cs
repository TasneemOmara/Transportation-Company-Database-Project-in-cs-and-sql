namespace DBapplication
{
    partial class Departments
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
            this.button1_getDepInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2_logOut = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1_Mngr = new System.Windows.Forms.ComboBox();
            this.button3_add = new System.Windows.Forms.Button();
            this.button4_get = new System.Windows.Forms.Button();
            this.comboBox2_nameUpdate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5_update = new System.Windows.Forms.Button();
            this.button1_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_getDepInfo
            // 
            this.button1_getDepInfo.Location = new System.Drawing.Point(65, 12);
            this.button1_getDepInfo.Name = "button1_getDepInfo";
            this.button1_getDepInfo.Size = new System.Drawing.Size(211, 63);
            this.button1_getDepInfo.TabIndex = 0;
            this.button1_getDepInfo.Text = "Get Departments Information";
            this.button1_getDepInfo.UseVisualStyleBackColor = true;
            this.button1_getDepInfo.Click += new System.EventHandler(this.button1_getDepInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2_logOut
            // 
            this.button2_logOut.Location = new System.Drawing.Point(757, 12);
            this.button2_logOut.Name = "button2_logOut";
            this.button2_logOut.Size = new System.Drawing.Size(149, 63);
            this.button2_logOut.TabIndex = 2;
            this.button2_logOut.Text = "Log Out";
            this.button2_logOut.UseVisualStyleBackColor = true;
            this.button2_logOut.Click += new System.EventHandler(this.button2_logOut_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department Name";
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Location = new System.Drawing.Point(255, 344);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(194, 22);
            this.textBox2_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Manager";
            // 
            // comboBox1_Mngr
            // 
            this.comboBox1_Mngr.FormattingEnabled = true;
            this.comboBox1_Mngr.Location = new System.Drawing.Point(255, 396);
            this.comboBox1_Mngr.Name = "comboBox1_Mngr";
            this.comboBox1_Mngr.Size = new System.Drawing.Size(194, 24);
            this.comboBox1_Mngr.TabIndex = 8;
            // 
            // button3_add
            // 
            this.button3_add.Location = new System.Drawing.Point(24, 523);
            this.button3_add.Name = "button3_add";
            this.button3_add.Size = new System.Drawing.Size(211, 63);
            this.button3_add.TabIndex = 9;
            this.button3_add.Text = "Add Department";
            this.button3_add.UseVisualStyleBackColor = true;
            this.button3_add.Click += new System.EventHandler(this.button3_add_Click);
            // 
            // button4_get
            // 
            this.button4_get.Location = new System.Drawing.Point(295, 523);
            this.button4_get.Name = "button4_get";
            this.button4_get.Size = new System.Drawing.Size(211, 63);
            this.button4_get.TabIndex = 10;
            this.button4_get.Text = "Get Department";
            this.button4_get.UseVisualStyleBackColor = true;
            this.button4_get.Click += new System.EventHandler(this.button4_get_Click);
            // 
            // comboBox2_nameUpdate
            // 
            this.comboBox2_nameUpdate.FormattingEnabled = true;
            this.comboBox2_nameUpdate.Location = new System.Drawing.Point(521, 562);
            this.comboBox2_nameUpdate.Name = "comboBox2_nameUpdate";
            this.comboBox2_nameUpdate.Size = new System.Drawing.Size(194, 24);
            this.comboBox2_nameUpdate.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department Name";
            // 
            // button5_update
            // 
            this.button5_update.Location = new System.Drawing.Point(730, 523);
            this.button5_update.Name = "button5_update";
            this.button5_update.Size = new System.Drawing.Size(211, 63);
            this.button5_update.TabIndex = 13;
            this.button5_update.Text = "Update";
            this.button5_update.UseVisualStyleBackColor = true;
            this.button5_update.Click += new System.EventHandler(this.button5_update_Click);
            // 
            // button1_reset
            // 
            this.button1_reset.Location = new System.Drawing.Point(597, 345);
            this.button1_reset.Name = "button1_reset";
            this.button1_reset.Size = new System.Drawing.Size(211, 63);
            this.button1_reset.TabIndex = 14;
            this.button1_reset.Text = "Reset Fields";
            this.button1_reset.UseVisualStyleBackColor = true;
            this.button1_reset.Click += new System.EventHandler(this.button1_reset_Click);
            // 
            // Departments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 656);
            this.Controls.Add(this.button1_reset);
            this.Controls.Add(this.button5_update);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2_nameUpdate);
            this.Controls.Add(this.button4_get);
            this.Controls.Add(this.button3_add);
            this.Controls.Add(this.comboBox1_Mngr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2_logOut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1_getDepInfo);
            this.Name = "Departments";
            this.Text = "Departments";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_getDepInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2_logOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1_Mngr;
        private System.Windows.Forms.Button button3_add;
        private System.Windows.Forms.Button button4_get;
        private System.Windows.Forms.ComboBox comboBox2_nameUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5_update;
        private System.Windows.Forms.Button button1_reset;
    }
}
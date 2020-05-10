namespace DBapplication
{
    partial class Employees
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
            this.EmployeesInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.textBox1_SSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_FN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_LN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1_Dep = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4_Salary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2_SSSN = new System.Windows.Forms.ComboBox();
            this.textBox6_address = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.comboBox3_update_SSN = new System.Windows.Forms.ComboBox();
            this.comboBox4_delete_SSN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4_gender = new System.Windows.Forms.ComboBox();
            this.button1_update = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1_deletenow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesInfo
            // 
            this.EmployeesInfo.Location = new System.Drawing.Point(400, 12);
            this.EmployeesInfo.Name = "EmployeesInfo";
            this.EmployeesInfo.Size = new System.Drawing.Size(217, 51);
            this.EmployeesInfo.TabIndex = 0;
            this.EmployeesInfo.Text = "Get Employees Information";
            this.EmployeesInfo.UseVisualStyleBackColor = true;
            this.EmployeesInfo.Click += new System.EventHandler(this.EmployeesInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(70, 575);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(171, 49);
            this.add.TabIndex = 2;
            this.add.Text = "Add Employee";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textBox1_SSN
            // 
            this.textBox1_SSN.Location = new System.Drawing.Point(182, 335);
            this.textBox1_SSN.Name = "textBox1_SSN";
            this.textBox1_SSN.Size = new System.Drawing.Size(167, 22);
            this.textBox1_SSN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // textBox2_FN
            // 
            this.textBox2_FN.Location = new System.Drawing.Point(182, 396);
            this.textBox2_FN.Name = "textBox2_FN";
            this.textBox2_FN.Size = new System.Drawing.Size(167, 22);
            this.textBox2_FN.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // textBox3_LN
            // 
            this.textBox3_LN.Location = new System.Drawing.Point(182, 458);
            this.textBox3_LN.Name = "textBox3_LN";
            this.textBox3_LN.Size = new System.Drawing.Size(167, 22);
            this.textBox3_LN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Manager SSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department";
            // 
            // comboBox1_Dep
            // 
            this.comboBox1_Dep.FormattingEnabled = true;
            this.comboBox1_Dep.Location = new System.Drawing.Point(544, 366);
            this.comboBox1_Dep.Name = "comboBox1_Dep";
            this.comboBox1_Dep.Size = new System.Drawing.Size(130, 24);
            this.comboBox1_Dep.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(749, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Salary";
            // 
            // textBox4_Salary
            // 
            this.textBox4_Salary.Location = new System.Drawing.Point(832, 335);
            this.textBox4_Salary.Name = "textBox4_Salary";
            this.textBox4_Salary.Size = new System.Drawing.Size(167, 22);
            this.textBox4_Salary.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address";
            // 
            // comboBox2_SSSN
            // 
            this.comboBox2_SSSN.FormattingEnabled = true;
            this.comboBox2_SSSN.Location = new System.Drawing.Point(544, 421);
            this.comboBox2_SSSN.Name = "comboBox2_SSSN";
            this.comboBox2_SSSN.Size = new System.Drawing.Size(130, 24);
            this.comboBox2_SSSN.TabIndex = 18;
            // 
            // textBox6_address
            // 
            this.textBox6_address.Location = new System.Drawing.Point(832, 453);
            this.textBox6_address.Name = "textBox6_address";
            this.textBox6_address.Size = new System.Drawing.Size(167, 22);
            this.textBox6_address.TabIndex = 20;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(503, 540);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(171, 49);
            this.update.TabIndex = 21;
            this.update.Text = "Retrieve Employee to get Updated";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(503, 661);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(171, 49);
            this.delete.TabIndex = 22;
            this.delete.Text = "Retrieve Employee to get deleted";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(259, 575);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(171, 49);
            this.reset.TabIndex = 23;
            this.reset.Text = "Reset Data";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // comboBox3_update_SSN
            // 
            this.comboBox3_update_SSN.FormattingEnabled = true;
            this.comboBox3_update_SSN.Location = new System.Drawing.Point(778, 565);
            this.comboBox3_update_SSN.Name = "comboBox3_update_SSN";
            this.comboBox3_update_SSN.Size = new System.Drawing.Size(130, 24);
            this.comboBox3_update_SSN.TabIndex = 24;
            // 
            // comboBox4_delete_SSN
            // 
            this.comboBox4_delete_SSN.FormattingEnabled = true;
            this.comboBox4_delete_SSN.Location = new System.Drawing.Point(778, 686);
            this.comboBox4_delete_SSN.Name = "comboBox4_delete_SSN";
            this.comboBox4_delete_SSN.Size = new System.Drawing.Size(130, 24);
            this.comboBox4_delete_SSN.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(733, 540);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Select the Employee to be Updated";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(733, 661);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Select the Employee to be Deleted";
            // 
            // comboBox4_gender
            // 
            this.comboBox4_gender.FormattingEnabled = true;
            this.comboBox4_gender.Location = new System.Drawing.Point(832, 394);
            this.comboBox4_gender.Name = "comboBox4_gender";
            this.comboBox4_gender.Size = new System.Drawing.Size(167, 24);
            this.comboBox4_gender.TabIndex = 28;
            // 
            // button1_update
            // 
            this.button1_update.Location = new System.Drawing.Point(933, 566);
            this.button1_update.Name = "button1_update";
            this.button1_update.Size = new System.Drawing.Size(75, 23);
            this.button1_update.TabIndex = 29;
            this.button1_update.Text = "Update";
            this.button1_update.UseVisualStyleBackColor = true;
            this.button1_update.Click += new System.EventHandler(this.button1_update_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(952, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 41);
            this.button5.TabIndex = 43;
            this.button5.Text = "Log Out";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1_deletenow
            // 
            this.button1_deletenow.Location = new System.Drawing.Point(933, 686);
            this.button1_deletenow.Name = "button1_deletenow";
            this.button1_deletenow.Size = new System.Drawing.Size(75, 23);
            this.button1_deletenow.TabIndex = 44;
            this.button1_deletenow.Text = "Delete";
            this.button1_deletenow.UseVisualStyleBackColor = true;
            this.button1_deletenow.Click += new System.EventHandler(this.button1_deletenow_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 760);
            this.Controls.Add(this.button1_deletenow);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1_update);
            this.Controls.Add(this.comboBox4_gender);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox4_delete_SSN);
            this.Controls.Add(this.comboBox3_update_SSN);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBox6_address);
            this.Controls.Add(this.comboBox2_SSSN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4_Salary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1_Dep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3_LN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2_FN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_SSN);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EmployeesInfo);
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeesInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textBox1_SSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_FN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3_LN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1_Dep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4_Salary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2_SSSN;
        private System.Windows.Forms.TextBox textBox6_address;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox comboBox3_update_SSN;
        private System.Windows.Forms.ComboBox comboBox4_delete_SSN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4_gender;
        private System.Windows.Forms.Button button1_update;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1_deletenow;
    }
}
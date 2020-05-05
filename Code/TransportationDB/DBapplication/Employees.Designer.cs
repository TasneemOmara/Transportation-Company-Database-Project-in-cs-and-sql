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
            this.textBox5_gender = new System.Windows.Forms.TextBox();
            this.textBox6_address = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.comboBox3_update_SSN = new System.Windows.Forms.ComboBox();
            this.comboBox4_delete_SSN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesInfo
            // 
            this.EmployeesInfo.Location = new System.Drawing.Point(402, 33);
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
            this.dataGridView1.Location = new System.Drawing.Point(74, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 236);
            this.dataGridView1.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(84, 575);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(171, 49);
            this.add.TabIndex = 2;
            this.add.Text = "Add Employee";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textBox1_SSN
            // 
            this.textBox1_SSN.Location = new System.Drawing.Point(182, 369);
            this.textBox1_SSN.Name = "textBox1_SSN";
            this.textBox1_SSN.Size = new System.Drawing.Size(167, 22);
            this.textBox1_SSN.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First Name";
            // 
            // textBox2_FN
            // 
            this.textBox2_FN.Location = new System.Drawing.Point(182, 430);
            this.textBox2_FN.Name = "textBox2_FN";
            this.textBox2_FN.Size = new System.Drawing.Size(167, 22);
            this.textBox2_FN.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // textBox3_LN
            // 
            this.textBox3_LN.Location = new System.Drawing.Point(182, 492);
            this.textBox3_LN.Name = "textBox3_LN";
            this.textBox3_LN.Size = new System.Drawing.Size(167, 22);
            this.textBox3_LN.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Manager SSN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(749, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Department";
            // 
            // comboBox1_Dep
            // 
            this.comboBox1_Dep.FormattingEnabled = true;
            this.comboBox1_Dep.Location = new System.Drawing.Point(544, 400);
            this.comboBox1_Dep.Name = "comboBox1_Dep";
            this.comboBox1_Dep.Size = new System.Drawing.Size(130, 24);
            this.comboBox1_Dep.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(749, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Salary";
            // 
            // textBox4_Salary
            // 
            this.textBox4_Salary.Location = new System.Drawing.Point(832, 369);
            this.textBox4_Salary.Name = "textBox4_Salary";
            this.textBox4_Salary.Size = new System.Drawing.Size(167, 22);
            this.textBox4_Salary.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 492);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address";
            // 
            // comboBox2_SSSN
            // 
            this.comboBox2_SSSN.FormattingEnabled = true;
            this.comboBox2_SSSN.Location = new System.Drawing.Point(544, 455);
            this.comboBox2_SSSN.Name = "comboBox2_SSSN";
            this.comboBox2_SSSN.Size = new System.Drawing.Size(130, 24);
            this.comboBox2_SSSN.TabIndex = 18;
            // 
            // textBox5_gender
            // 
            this.textBox5_gender.Location = new System.Drawing.Point(832, 432);
            this.textBox5_gender.Name = "textBox5_gender";
            this.textBox5_gender.Size = new System.Drawing.Size(167, 22);
            this.textBox5_gender.TabIndex = 19;
            // 
            // textBox6_address
            // 
            this.textBox6_address.Location = new System.Drawing.Point(832, 487);
            this.textBox6_address.Name = "textBox6_address";
            this.textBox6_address.Size = new System.Drawing.Size(167, 22);
            this.textBox6_address.TabIndex = 20;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(656, 540);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(171, 49);
            this.update.TabIndex = 21;
            this.update.Text = "Update Employee";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(656, 630);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(171, 49);
            this.delete.TabIndex = 22;
            this.delete.Text = "Delete Employee";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(380, 575);
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
            this.comboBox3_update_SSN.Location = new System.Drawing.Point(869, 553);
            this.comboBox3_update_SSN.Name = "comboBox3_update_SSN";
            this.comboBox3_update_SSN.Size = new System.Drawing.Size(130, 24);
            this.comboBox3_update_SSN.TabIndex = 24;
            // 
            // comboBox4_delete_SSN
            // 
            this.comboBox4_delete_SSN.FormattingEnabled = true;
            this.comboBox4_delete_SSN.Location = new System.Drawing.Point(869, 643);
            this.comboBox4_delete_SSN.Name = "comboBox4_delete_SSN";
            this.comboBox4_delete_SSN.Size = new System.Drawing.Size(130, 24);
            this.comboBox4_delete_SSN.TabIndex = 25;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 710);
            this.Controls.Add(this.comboBox4_delete_SSN);
            this.Controls.Add(this.comboBox3_update_SSN);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBox6_address);
            this.Controls.Add(this.textBox5_gender);
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
        private System.Windows.Forms.TextBox textBox5_gender;
        private System.Windows.Forms.TextBox textBox6_address;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.ComboBox comboBox3_update_SSN;
        private System.Windows.Forms.ComboBox comboBox4_delete_SSN;
    }
}
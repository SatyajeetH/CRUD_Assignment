namespace Employee_DB
{
    partial class Employee_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_Department = new System.Windows.Forms.ComboBox();
            this.txt_Age = new System.Windows.Forms.NumericUpDown();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.txt_Salary = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.data_Grid = new System.Windows.Forms.DataGridView();
            this.btn_ViewAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.Location = new System.Drawing.Point(391, 9);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(263, 51);
            this.lbl_Heading.TabIndex = 0;
            this.lbl_Heading.Text = "EMPLOYEE DETAILS";
            this.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.txt_Department);
            this.groupBox1.Controls.Add(this.txt_Age);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Create);
            this.groupBox1.Controls.Add(this.btn_Read);
            this.groupBox1.Controls.Add(this.txt_Salary);
            this.groupBox1.Controls.Add(this.txt_Name);
            this.groupBox1.Controls.Add(this.txt_Id);
            this.groupBox1.Controls.Add(this.lbl_Salary);
            this.groupBox1.Controls.Add(this.lbl_Department);
            this.groupBox1.Controls.Add(this.lbl_Age);
            this.groupBox1.Controls.Add(this.lbl_Name);
            this.groupBox1.Controls.Add(this.lbl_Id);
            this.groupBox1.Location = new System.Drawing.Point(44, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(353, 273);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(76, 25);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_Department
            // 
            this.txt_Department.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Department.FormattingEnabled = true;
            this.txt_Department.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Automation",
            "R&D"});
            this.txt_Department.Location = new System.Drawing.Point(198, 161);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(173, 28);
            this.txt_Department.TabIndex = 2;
            // 
            // txt_Age
            // 
            this.txt_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Age.Location = new System.Drawing.Point(198, 116);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(88, 26);
            this.txt_Age.TabIndex = 1;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(245, 273);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(90, 25);
            this.btn_Delete.TabIndex = 6;
            this.btn_Delete.Text = "DELETE";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(133, 273);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(92, 25);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Create.Location = new System.Drawing.Point(30, 273);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(88, 25);
            this.btn_Create.TabIndex = 4;
            this.btn_Create.Text = "CREATE";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.Location = new System.Drawing.Point(301, 28);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(70, 25);
            this.btn_Read.TabIndex = 8;
            this.btn_Read.Text = "READ";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // txt_Salary
            // 
            this.txt_Salary.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Salary.Location = new System.Drawing.Point(198, 207);
            this.txt_Salary.Name = "txt_Salary";
            this.txt_Salary.Size = new System.Drawing.Size(231, 27);
            this.txt_Salary.TabIndex = 3;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(198, 72);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(173, 27);
            this.txt_Name.TabIndex = 0;
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(198, 27);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(88, 27);
            this.txt_Id.TabIndex = 11;
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.Location = new System.Drawing.Point(26, 207);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(150, 25);
            this.lbl_Salary.TabIndex = 4;
            this.lbl_Salary.Text = "Emp_Salary";
            this.lbl_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Department
            // 
            this.lbl_Department.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.Location = new System.Drawing.Point(26, 162);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(166, 25);
            this.lbl_Department.TabIndex = 3;
            this.lbl_Department.Text = "Emp_Department";
            this.lbl_Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Age
            // 
            this.lbl_Age.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(26, 115);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(150, 25);
            this.lbl_Age.TabIndex = 2;
            this.lbl_Age.Text = "Emp_Age";
            this.lbl_Age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(26, 72);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(150, 25);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Emp_Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Id
            // 
            this.lbl_Id.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id.Location = new System.Drawing.Point(26, 34);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(150, 25);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Emp_Id";
            this.lbl_Id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // data_Grid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.data_Grid.Location = new System.Drawing.Point(525, 133);
            this.data_Grid.Name = "data_Grid";
            this.data_Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data_Grid.RowHeadersWidth = 62;
            this.data_Grid.RowTemplate.Height = 28;
            this.data_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Grid.Size = new System.Drawing.Size(464, 292);
            this.data_Grid.TabIndex = 10;
            this.data_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Grid_CellClick);
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewAll.Location = new System.Drawing.Point(705, 102);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Size = new System.Drawing.Size(108, 25);
            this.btn_ViewAll.TabIndex = 9;
            this.btn_ViewAll.Text = "VIEW ALL";
            this.btn_ViewAll.UseVisualStyleBackColor = true;
            this.btn_ViewAll.Click += new System.EventHandler(this.btn_ViewAll_Click);
            // 
            // Employee_Details
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1017, 463);
            this.Controls.Add(this.btn_ViewAll);
            this.Controls.Add(this.data_Grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_Heading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee_Details";
            this.Load += new System.EventHandler(this.Employee_Details_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Heading;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Salary;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.ComboBox txt_Department;
        private System.Windows.Forms.NumericUpDown txt_Age;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridView data_Grid;
        private System.Windows.Forms.Button btn_ViewAll;
    }
}


namespace LookingGlass
{
    partial class ApplicationMaintenanceForm
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
            this.dgvApplication = new System.Windows.Forms.DataGridView();
            this.dSLookingGlass = new LookingGlass.DSLookingGlass();
            this.txtApplicationDescription = new System.Windows.Forms.TextBox();
            this.lblApplicationDescription = new System.Windows.Forms.Label();
            this.txtApplicationEmName = new System.Windows.Forms.TextBox();
            this.txtApplicationSalary = new System.Windows.Forms.TextBox();
            this.txtCandidateFullName = new System.Windows.Forms.TextBox();
            this.lblApplicationEmName = new System.Windows.Forms.Label();
            this.lblApplicationSalary = new System.Windows.Forms.Label();
            this.lblCandidateFullName = new System.Windows.Forms.Label();
            this.btnApplicationReturn = new System.Windows.Forms.Button();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.btnDeleteApplication = new System.Windows.Forms.Button();
            this.pnlAddApplication = new System.Windows.Forms.Panel();
            this.cboAMVacancyDescription = new System.Windows.Forms.ComboBox();
            this.cboAMVacancyID = new System.Windows.Forms.ComboBox();
            this.lblAMVacancy = new System.Windows.Forms.Label();
            this.cboAMCandidateName = new System.Windows.Forms.ComboBox();
            this.cboAMCandidateID = new System.Windows.Forms.ComboBox();
            this.btnAddACancel = new System.Windows.Forms.Button();
            this.btnSaveApplication = new System.Windows.Forms.Button();
            this.lblAMCandidate = new System.Windows.Forms.Label();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.lblEmployerID = new System.Windows.Forms.Label();
            this.lblCandidateID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLookingGlass)).BeginInit();
            this.pnlAddApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvApplication
            // 
            this.dgvApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApplication.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.Location = new System.Drawing.Point(26, 32);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.RowHeadersVisible = false;
            this.dgvApplication.RowHeadersWidth = 10;
            this.dgvApplication.Size = new System.Drawing.Size(185, 249);
            this.dgvApplication.TabIndex = 29;
            // 
            // dSLookingGlass
            // 
            this.dSLookingGlass.DataSetName = "DSLookingGlass";
            this.dSLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtApplicationDescription
            // 
            this.txtApplicationDescription.Location = new System.Drawing.Point(333, 42);
            this.txtApplicationDescription.Name = "txtApplicationDescription";
            this.txtApplicationDescription.ReadOnly = true;
            this.txtApplicationDescription.Size = new System.Drawing.Size(196, 20);
            this.txtApplicationDescription.TabIndex = 79;
            // 
            // lblApplicationDescription
            // 
            this.lblApplicationDescription.AutoSize = true;
            this.lblApplicationDescription.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblApplicationDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApplicationDescription.Location = new System.Drawing.Point(261, 44);
            this.lblApplicationDescription.Name = "lblApplicationDescription";
            this.lblApplicationDescription.Size = new System.Drawing.Size(70, 15);
            this.lblApplicationDescription.TabIndex = 78;
            this.lblApplicationDescription.Text = "Description:";
            // 
            // txtApplicationEmName
            // 
            this.txtApplicationEmName.Location = new System.Drawing.Point(333, 82);
            this.txtApplicationEmName.Name = "txtApplicationEmName";
            this.txtApplicationEmName.ReadOnly = true;
            this.txtApplicationEmName.Size = new System.Drawing.Size(196, 20);
            this.txtApplicationEmName.TabIndex = 77;
            // 
            // txtApplicationSalary
            // 
            this.txtApplicationSalary.Location = new System.Drawing.Point(333, 123);
            this.txtApplicationSalary.Name = "txtApplicationSalary";
            this.txtApplicationSalary.ReadOnly = true;
            this.txtApplicationSalary.Size = new System.Drawing.Size(98, 20);
            this.txtApplicationSalary.TabIndex = 76;
            // 
            // txtCandidateFullName
            // 
            this.txtCandidateFullName.Location = new System.Drawing.Point(333, 168);
            this.txtCandidateFullName.Name = "txtCandidateFullName";
            this.txtCandidateFullName.ReadOnly = true;
            this.txtCandidateFullName.Size = new System.Drawing.Size(196, 20);
            this.txtCandidateFullName.TabIndex = 74;
            // 
            // lblApplicationEmName
            // 
            this.lblApplicationEmName.AutoSize = true;
            this.lblApplicationEmName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblApplicationEmName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApplicationEmName.Location = new System.Drawing.Point(242, 84);
            this.lblApplicationEmName.Name = "lblApplicationEmName";
            this.lblApplicationEmName.Size = new System.Drawing.Size(89, 15);
            this.lblApplicationEmName.TabIndex = 73;
            this.lblApplicationEmName.Text = "Employer Name:";
            // 
            // lblApplicationSalary
            // 
            this.lblApplicationSalary.AutoSize = true;
            this.lblApplicationSalary.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblApplicationSalary.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApplicationSalary.Location = new System.Drawing.Point(287, 125);
            this.lblApplicationSalary.Name = "lblApplicationSalary";
            this.lblApplicationSalary.Size = new System.Drawing.Size(44, 15);
            this.lblApplicationSalary.TabIndex = 72;
            this.lblApplicationSalary.Text = "Salary:";
            // 
            // lblCandidateFullName
            // 
            this.lblCandidateFullName.AutoSize = true;
            this.lblCandidateFullName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblCandidateFullName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCandidateFullName.Location = new System.Drawing.Point(217, 168);
            this.lblCandidateFullName.Name = "lblCandidateFullName";
            this.lblCandidateFullName.Size = new System.Drawing.Size(114, 15);
            this.lblCandidateFullName.TabIndex = 71;
            this.lblCandidateFullName.Text = "Candidate Full Name:";
            // 
            // btnApplicationReturn
            // 
            this.btnApplicationReturn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnApplicationReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnApplicationReturn.Location = new System.Drawing.Point(432, 319);
            this.btnApplicationReturn.Name = "btnApplicationReturn";
            this.btnApplicationReturn.Size = new System.Drawing.Size(137, 30);
            this.btnApplicationReturn.TabIndex = 75;
            this.btnApplicationReturn.Text = "Return";
            this.btnApplicationReturn.UseVisualStyleBackColor = true;
            this.btnApplicationReturn.Click += new System.EventHandler(this.btnApplicationReturn_Click);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnAddApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddApplication.Location = new System.Drawing.Point(278, 270);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(133, 30);
            this.btnAddApplication.TabIndex = 70;
            this.btnAddApplication.Text = "Add Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnDeleteApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteApplication.Location = new System.Drawing.Point(432, 270);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(137, 30);
            this.btnDeleteApplication.TabIndex = 69;
            this.btnDeleteApplication.Text = "Delete Application";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // pnlAddApplication
            // 
            this.pnlAddApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddApplication.Controls.Add(this.cboAMVacancyDescription);
            this.pnlAddApplication.Controls.Add(this.cboAMVacancyID);
            this.pnlAddApplication.Controls.Add(this.lblAMVacancy);
            this.pnlAddApplication.Controls.Add(this.cboAMCandidateName);
            this.pnlAddApplication.Controls.Add(this.cboAMCandidateID);
            this.pnlAddApplication.Controls.Add(this.btnAddACancel);
            this.pnlAddApplication.Controls.Add(this.btnSaveApplication);
            this.pnlAddApplication.Controls.Add(this.lblAMCandidate);
            this.pnlAddApplication.Location = new System.Drawing.Point(220, 12);
            this.pnlAddApplication.Name = "pnlAddApplication";
            this.pnlAddApplication.Size = new System.Drawing.Size(360, 240);
            this.pnlAddApplication.TabIndex = 80;
            this.pnlAddApplication.Visible = false;
            // 
            // cboAMVacancyDescription
            // 
            this.cboAMVacancyDescription.FormattingEnabled = true;
            this.cboAMVacancyDescription.Location = new System.Drawing.Point(186, 72);
            this.cboAMVacancyDescription.Name = "cboAMVacancyDescription";
            this.cboAMVacancyDescription.Size = new System.Drawing.Size(133, 21);
            this.cboAMVacancyDescription.TabIndex = 63;
            this.cboAMVacancyDescription.Text = "Description";
            // 
            // cboAMVacancyID
            // 
            this.cboAMVacancyID.FormattingEnabled = true;
            this.cboAMVacancyID.Location = new System.Drawing.Point(123, 72);
            this.cboAMVacancyID.Name = "cboAMVacancyID";
            this.cboAMVacancyID.Size = new System.Drawing.Size(56, 21);
            this.cboAMVacancyID.TabIndex = 62;
            this.cboAMVacancyID.Text = "ID";
            // 
            // lblAMVacancy
            // 
            this.lblAMVacancy.AutoSize = true;
            this.lblAMVacancy.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblAMVacancy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAMVacancy.Location = new System.Drawing.Point(60, 73);
            this.lblAMVacancy.Name = "lblAMVacancy";
            this.lblAMVacancy.Size = new System.Drawing.Size(53, 15);
            this.lblAMVacancy.TabIndex = 61;
            this.lblAMVacancy.Text = "Vacancy:";
            // 
            // cboAMCandidateName
            // 
            this.cboAMCandidateName.FormattingEnabled = true;
            this.cboAMCandidateName.Location = new System.Drawing.Point(186, 117);
            this.cboAMCandidateName.Name = "cboAMCandidateName";
            this.cboAMCandidateName.Size = new System.Drawing.Size(133, 21);
            this.cboAMCandidateName.TabIndex = 60;
            this.cboAMCandidateName.Text = "Name";
            // 
            // cboAMCandidateID
            // 
            this.cboAMCandidateID.FormattingEnabled = true;
            this.cboAMCandidateID.Location = new System.Drawing.Point(123, 117);
            this.cboAMCandidateID.Name = "cboAMCandidateID";
            this.cboAMCandidateID.Size = new System.Drawing.Size(56, 21);
            this.cboAMCandidateID.TabIndex = 59;
            this.cboAMCandidateID.Text = "ID";
            // 
            // btnAddACancel
            // 
            this.btnAddACancel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnAddACancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddACancel.Location = new System.Drawing.Point(215, 188);
            this.btnAddACancel.Name = "btnAddACancel";
            this.btnAddACancel.Size = new System.Drawing.Size(122, 30);
            this.btnAddACancel.TabIndex = 58;
            this.btnAddACancel.Text = "Cancel";
            this.btnAddACancel.UseVisualStyleBackColor = true;
            this.btnAddACancel.Click += new System.EventHandler(this.btnAddACancel_Click);
            // 
            // btnSaveApplication
            // 
            this.btnSaveApplication.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnSaveApplication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveApplication.Location = new System.Drawing.Point(21, 188);
            this.btnSaveApplication.Name = "btnSaveApplication";
            this.btnSaveApplication.Size = new System.Drawing.Size(114, 30);
            this.btnSaveApplication.TabIndex = 57;
            this.btnSaveApplication.Text = "Save Application";
            this.btnSaveApplication.UseVisualStyleBackColor = true;
            this.btnSaveApplication.Click += new System.EventHandler(this.btnSaveApplication_Click);
            // 
            // lblAMCandidate
            // 
            this.lblAMCandidate.AutoSize = true;
            this.lblAMCandidate.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblAMCandidate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAMCandidate.Location = new System.Drawing.Point(60, 118);
            this.lblAMCandidate.Name = "lblAMCandidate";
            this.lblAMCandidate.Size = new System.Drawing.Size(61, 15);
            this.lblAMCandidate.TabIndex = 48;
            this.lblAMCandidate.Text = "Candidate:";
            this.lblAMCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblVacancyID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVacancyID.Location = new System.Drawing.Point(359, 44);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(67, 15);
            this.lblVacancyID.TabIndex = 81;
            this.lblVacancyID.Text = "VacancyID:";
            this.lblVacancyID.TextChanged += new System.EventHandler(this.lblVacancyID_TextChanged);
            // 
            // lblEmployerID
            // 
            this.lblEmployerID.AutoSize = true;
            this.lblEmployerID.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblEmployerID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEmployerID.Location = new System.Drawing.Point(355, 87);
            this.lblEmployerID.Name = "lblEmployerID";
            this.lblEmployerID.Size = new System.Drawing.Size(71, 15);
            this.lblEmployerID.TabIndex = 82;
            this.lblEmployerID.Text = "EmployerID:";
            this.lblEmployerID.TextChanged += new System.EventHandler(this.lblEmployerID_TextChanged);
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lblCandidateID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCandidateID.Location = new System.Drawing.Point(369, 173);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(75, 15);
            this.lblCandidateID.TabIndex = 83;
            this.lblCandidateID.Text = "CandidateID:";
            this.lblCandidateID.TextChanged += new System.EventHandler(this.lblCandidateID_TextChanged);
            // 
            // ApplicationMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.pnlAddApplication);
            this.Controls.Add(this.txtApplicationDescription);
            this.Controls.Add(this.lblApplicationDescription);
            this.Controls.Add(this.txtApplicationEmName);
            this.Controls.Add(this.txtApplicationSalary);
            this.Controls.Add(this.txtCandidateFullName);
            this.Controls.Add(this.lblApplicationEmName);
            this.Controls.Add(this.lblApplicationSalary);
            this.Controls.Add(this.lblCandidateFullName);
            this.Controls.Add(this.btnApplicationReturn);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.btnDeleteApplication);
            this.Controls.Add(this.dgvApplication);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.lblEmployerID);
            this.Controls.Add(this.lblCandidateID);
            this.Name = "ApplicationMaintenanceForm";
            this.Text = "ApplicationMaintenanceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLookingGlass)).EndInit();
            this.pnlAddApplication.ResumeLayout(false);
            this.pnlAddApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplication;
        private DSLookingGlass dSLookingGlass;
        private System.Windows.Forms.TextBox txtApplicationDescription;
        private System.Windows.Forms.Label lblApplicationDescription;
        private System.Windows.Forms.TextBox txtApplicationEmName;
        private System.Windows.Forms.TextBox txtApplicationSalary;
        private System.Windows.Forms.TextBox txtCandidateFullName;
        private System.Windows.Forms.Label lblApplicationEmName;
        private System.Windows.Forms.Label lblApplicationSalary;
        private System.Windows.Forms.Label lblCandidateFullName;
        private System.Windows.Forms.Button btnApplicationReturn;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Button btnDeleteApplication;
        private System.Windows.Forms.Panel pnlAddApplication;
        private System.Windows.Forms.ComboBox cboAMVacancyDescription;
        private System.Windows.Forms.ComboBox cboAMVacancyID;
        private System.Windows.Forms.Label lblAMVacancy;
        private System.Windows.Forms.ComboBox cboAMCandidateName;
        private System.Windows.Forms.ComboBox cboAMCandidateID;
        private System.Windows.Forms.Button btnAddACancel;
        private System.Windows.Forms.Button btnSaveApplication;
        private System.Windows.Forms.Label lblAMCandidate;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.Label lblEmployerID;
        private System.Windows.Forms.Label lblCandidateID;
    }
}
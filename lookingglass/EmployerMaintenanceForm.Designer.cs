namespace LookingGlass
{
    partial class EmployerMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployerMaintenanceForm));
            this.lstEmployers = new System.Windows.Forms.ListBox();
            this.btnEmPrevious = new System.Windows.Forms.Button();
            this.lblEmployerID = new System.Windows.Forms.Label();
            this.lblEmployerName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuberb = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmployerID = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnEmReturn = new System.Windows.Forms.Button();
            this.btnDeleteEmployer = new System.Windows.Forms.Button();
            this.btnEmNext = new System.Windows.Forms.Button();
            this.btnUpdateEmployer = new System.Windows.Forms.Button();
            this.btnAddEmployer = new System.Windows.Forms.Button();
            this.pnlAddEmployer = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnSaveEmployer = new System.Windows.Forms.Button();
            this.txtAddEmployerPN = new System.Windows.Forms.TextBox();
            this.txtAddEmployerSuburb = new System.Windows.Forms.TextBox();
            this.txtAddEmployerSA = new System.Windows.Forms.TextBox();
            this.txtAddEmployerName = new System.Windows.Forms.TextBox();
            this.lblAddEmployerPN = new System.Windows.Forms.Label();
            this.lblAddEmployerSuburb = new System.Windows.Forms.Label();
            this.lblAddEmployerSA = new System.Windows.Forms.Label();
            this.lblAddEmployerName = new System.Windows.Forms.Label();
            this.pnlUpdateEmployer = new System.Windows.Forms.Panel();
            this.btnUpdateEmCancel = new System.Windows.Forms.Button();
            this.btnUpdateEmSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateEmployerPN = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployerSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployerSA = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployerName = new System.Windows.Forms.TextBox();
            this.txtUpdateEmployerID = new System.Windows.Forms.TextBox();
            this.lblUpdateEmployerPN = new System.Windows.Forms.Label();
            this.lblUpdateEmployerSuburb = new System.Windows.Forms.Label();
            this.lblUpdateEmployerSA = new System.Windows.Forms.Label();
            this.lblUpdateEmployerName = new System.Windows.Forms.Label();
            this.lblUpdateEmployerID = new System.Windows.Forms.Label();
            this.pnlAddEmployer.SuspendLayout();
            this.pnlUpdateEmployer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEmployers
            // 
            this.lstEmployers.FormattingEnabled = true;
            resources.ApplyResources(this.lstEmployers, "lstEmployers");
            this.lstEmployers.Name = "lstEmployers";
            // 
            // btnEmPrevious
            // 
            resources.ApplyResources(this.btnEmPrevious, "btnEmPrevious");
            this.btnEmPrevious.Name = "btnEmPrevious";
            this.btnEmPrevious.UseVisualStyleBackColor = true;
            this.btnEmPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // lblEmployerID
            // 
            resources.ApplyResources(this.lblEmployerID, "lblEmployerID");
            this.lblEmployerID.Name = "lblEmployerID";
            // 
            // lblEmployerName
            // 
            resources.ApplyResources(this.lblEmployerName, "lblEmployerName");
            this.lblEmployerName.Name = "lblEmployerName";
            // 
            // lblStreetAddress
            // 
            resources.ApplyResources(this.lblStreetAddress, "lblStreetAddress");
            this.lblStreetAddress.Name = "lblStreetAddress";
            // 
            // lblSuberb
            // 
            resources.ApplyResources(this.lblSuberb, "lblSuberb");
            this.lblSuberb.Name = "lblSuberb";
            // 
            // lblPhoneNumber
            // 
            resources.ApplyResources(this.lblPhoneNumber, "lblPhoneNumber");
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            // 
            // txtEmployerID
            // 
            resources.ApplyResources(this.txtEmployerID, "txtEmployerID");
            this.txtEmployerID.Name = "txtEmployerID";
            this.txtEmployerID.ReadOnly = true;
            // 
            // txtEmployerName
            // 
            resources.ApplyResources(this.txtEmployerName, "txtEmployerName");
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.ReadOnly = true;
            // 
            // txtStreetAddress
            // 
            resources.ApplyResources(this.txtStreetAddress, "txtStreetAddress");
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            // 
            // txtSuburb
            // 
            resources.ApplyResources(this.txtSuburb, "txtSuburb");
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(this.txtPhoneNumber, "txtPhoneNumber");
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            // 
            // btnEmReturn
            // 
            resources.ApplyResources(this.btnEmReturn, "btnEmReturn");
            this.btnEmReturn.Name = "btnEmReturn";
            this.btnEmReturn.UseVisualStyleBackColor = true;
            this.btnEmReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteEmployer
            // 
            resources.ApplyResources(this.btnDeleteEmployer, "btnDeleteEmployer");
            this.btnDeleteEmployer.Name = "btnDeleteEmployer";
            this.btnDeleteEmployer.UseVisualStyleBackColor = true;
            this.btnDeleteEmployer.Click += new System.EventHandler(this.btnDeleteEmployer_Click);
            // 
            // btnEmNext
            // 
            resources.ApplyResources(this.btnEmNext, "btnEmNext");
            this.btnEmNext.Name = "btnEmNext";
            this.btnEmNext.UseVisualStyleBackColor = true;
            this.btnEmNext.Click += new System.EventHandler(this.btnNext);
            // 
            // btnUpdateEmployer
            // 
            resources.ApplyResources(this.btnUpdateEmployer, "btnUpdateEmployer");
            this.btnUpdateEmployer.Name = "btnUpdateEmployer";
            this.btnUpdateEmployer.UseVisualStyleBackColor = true;
            this.btnUpdateEmployer.Click += new System.EventHandler(this.btnUpdateEmployer_Click);
            // 
            // btnAddEmployer
            // 
            resources.ApplyResources(this.btnAddEmployer, "btnAddEmployer");
            this.btnAddEmployer.Name = "btnAddEmployer";
            this.btnAddEmployer.UseVisualStyleBackColor = true;
            this.btnAddEmployer.Click += new System.EventHandler(this.btnAddEmployer_Click);
            // 
            // pnlAddEmployer
            // 
            this.pnlAddEmployer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddEmployer.Controls.Add(this.btnAddCancel);
            this.pnlAddEmployer.Controls.Add(this.btnSaveEmployer);
            this.pnlAddEmployer.Controls.Add(this.txtAddEmployerPN);
            this.pnlAddEmployer.Controls.Add(this.txtAddEmployerSuburb);
            this.pnlAddEmployer.Controls.Add(this.txtAddEmployerSA);
            this.pnlAddEmployer.Controls.Add(this.txtAddEmployerName);
            this.pnlAddEmployer.Controls.Add(this.lblAddEmployerPN);
            this.pnlAddEmployer.Controls.Add(this.lblAddEmployerSuburb);
            this.pnlAddEmployer.Controls.Add(this.lblAddEmployerSA);
            this.pnlAddEmployer.Controls.Add(this.lblAddEmployerName);
            resources.ApplyResources(this.pnlAddEmployer, "pnlAddEmployer");
            this.pnlAddEmployer.Name = "pnlAddEmployer";
            // 
            // btnAddCancel
            // 
            resources.ApplyResources(this.btnAddCancel, "btnAddCancel");
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEmployer
            // 
            resources.ApplyResources(this.btnSaveEmployer, "btnSaveEmployer");
            this.btnSaveEmployer.Name = "btnSaveEmployer";
            this.btnSaveEmployer.UseVisualStyleBackColor = true;
            this.btnSaveEmployer.Click += new System.EventHandler(this.btnSaveEmployer_Click);
            // 
            // txtAddEmployerPN
            // 
            resources.ApplyResources(this.txtAddEmployerPN, "txtAddEmployerPN");
            this.txtAddEmployerPN.Name = "txtAddEmployerPN";
            // 
            // txtAddEmployerSuburb
            // 
            resources.ApplyResources(this.txtAddEmployerSuburb, "txtAddEmployerSuburb");
            this.txtAddEmployerSuburb.Name = "txtAddEmployerSuburb";
            // 
            // txtAddEmployerSA
            // 
            resources.ApplyResources(this.txtAddEmployerSA, "txtAddEmployerSA");
            this.txtAddEmployerSA.Name = "txtAddEmployerSA";
            // 
            // txtAddEmployerName
            // 
            resources.ApplyResources(this.txtAddEmployerName, "txtAddEmployerName");
            this.txtAddEmployerName.Name = "txtAddEmployerName";
            // 
            // lblAddEmployerPN
            // 
            resources.ApplyResources(this.lblAddEmployerPN, "lblAddEmployerPN");
            this.lblAddEmployerPN.Name = "lblAddEmployerPN";
            // 
            // lblAddEmployerSuburb
            // 
            resources.ApplyResources(this.lblAddEmployerSuburb, "lblAddEmployerSuburb");
            this.lblAddEmployerSuburb.Name = "lblAddEmployerSuburb";
            // 
            // lblAddEmployerSA
            // 
            resources.ApplyResources(this.lblAddEmployerSA, "lblAddEmployerSA");
            this.lblAddEmployerSA.Name = "lblAddEmployerSA";
            // 
            // lblAddEmployerName
            // 
            resources.ApplyResources(this.lblAddEmployerName, "lblAddEmployerName");
            this.lblAddEmployerName.Name = "lblAddEmployerName";
            // 
            // pnlUpdateEmployer
            // 
            this.pnlUpdateEmployer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateEmployer.Controls.Add(this.btnUpdateEmCancel);
            this.pnlUpdateEmployer.Controls.Add(this.btnUpdateEmSaveChanges);
            this.pnlUpdateEmployer.Controls.Add(this.txtUpdateEmployerPN);
            this.pnlUpdateEmployer.Controls.Add(this.txtUpdateEmployerSuburb);
            this.pnlUpdateEmployer.Controls.Add(this.txtUpdateEmployerSA);
            this.pnlUpdateEmployer.Controls.Add(this.txtUpdateEmployerName);
            this.pnlUpdateEmployer.Controls.Add(this.txtUpdateEmployerID);
            this.pnlUpdateEmployer.Controls.Add(this.lblUpdateEmployerPN);
            this.pnlUpdateEmployer.Controls.Add(this.lblUpdateEmployerSuburb);
            this.pnlUpdateEmployer.Controls.Add(this.lblUpdateEmployerSA);
            this.pnlUpdateEmployer.Controls.Add(this.lblUpdateEmployerName);
            this.pnlUpdateEmployer.Controls.Add(this.lblUpdateEmployerID);
            resources.ApplyResources(this.pnlUpdateEmployer, "pnlUpdateEmployer");
            this.pnlUpdateEmployer.Name = "pnlUpdateEmployer";
            // 
            // btnUpdateEmCancel
            // 
            resources.ApplyResources(this.btnUpdateEmCancel, "btnUpdateEmCancel");
            this.btnUpdateEmCancel.Name = "btnUpdateEmCancel";
            this.btnUpdateEmCancel.UseVisualStyleBackColor = true;
            this.btnUpdateEmCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdateEmSaveChanges
            // 
            resources.ApplyResources(this.btnUpdateEmSaveChanges, "btnUpdateEmSaveChanges");
            this.btnUpdateEmSaveChanges.Name = "btnUpdateEmSaveChanges";
            this.btnUpdateEmSaveChanges.UseVisualStyleBackColor = true;
            this.btnUpdateEmSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtUpdateEmployerPN
            // 
            resources.ApplyResources(this.txtUpdateEmployerPN, "txtUpdateEmployerPN");
            this.txtUpdateEmployerPN.Name = "txtUpdateEmployerPN";
            // 
            // txtUpdateEmployerSuburb
            // 
            resources.ApplyResources(this.txtUpdateEmployerSuburb, "txtUpdateEmployerSuburb");
            this.txtUpdateEmployerSuburb.Name = "txtUpdateEmployerSuburb";
            // 
            // txtUpdateEmployerSA
            // 
            resources.ApplyResources(this.txtUpdateEmployerSA, "txtUpdateEmployerSA");
            this.txtUpdateEmployerSA.Name = "txtUpdateEmployerSA";
            // 
            // txtUpdateEmployerName
            // 
            resources.ApplyResources(this.txtUpdateEmployerName, "txtUpdateEmployerName");
            this.txtUpdateEmployerName.Name = "txtUpdateEmployerName";
            this.txtUpdateEmployerName.TextChanged += new System.EventHandler(this.txtUpdateEmployerName_TextChanged);
            // 
            // txtUpdateEmployerID
            // 
            resources.ApplyResources(this.txtUpdateEmployerID, "txtUpdateEmployerID");
            this.txtUpdateEmployerID.Name = "txtUpdateEmployerID";
            this.txtUpdateEmployerID.ReadOnly = true;
            // 
            // lblUpdateEmployerPN
            // 
            resources.ApplyResources(this.lblUpdateEmployerPN, "lblUpdateEmployerPN");
            this.lblUpdateEmployerPN.Name = "lblUpdateEmployerPN";
            // 
            // lblUpdateEmployerSuburb
            // 
            resources.ApplyResources(this.lblUpdateEmployerSuburb, "lblUpdateEmployerSuburb");
            this.lblUpdateEmployerSuburb.Name = "lblUpdateEmployerSuburb";
            // 
            // lblUpdateEmployerSA
            // 
            resources.ApplyResources(this.lblUpdateEmployerSA, "lblUpdateEmployerSA");
            this.lblUpdateEmployerSA.Name = "lblUpdateEmployerSA";
            // 
            // lblUpdateEmployerName
            // 
            resources.ApplyResources(this.lblUpdateEmployerName, "lblUpdateEmployerName");
            this.lblUpdateEmployerName.Name = "lblUpdateEmployerName";
            // 
            // lblUpdateEmployerID
            // 
            resources.ApplyResources(this.lblUpdateEmployerID, "lblUpdateEmployerID");
            this.lblUpdateEmployerID.Name = "lblUpdateEmployerID";
            // 
            // EmployerMaintenanceForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlAddEmployer);
            this.Controls.Add(this.pnlUpdateEmployer);
            this.Controls.Add(this.btnAddEmployer);
            this.Controls.Add(this.btnUpdateEmployer);
            this.Controls.Add(this.btnEmNext);
            this.Controls.Add(this.btnDeleteEmployer);
            this.Controls.Add(this.btnEmReturn);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtEmployerID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblSuberb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblEmployerName);
            this.Controls.Add(this.lblEmployerID);
            this.Controls.Add(this.btnEmPrevious);
            this.Controls.Add(this.lstEmployers);
            this.Name = "EmployerMaintenanceForm";
            this.pnlAddEmployer.ResumeLayout(false);
            this.pnlAddEmployer.PerformLayout();
            this.pnlUpdateEmployer.ResumeLayout(false);
            this.pnlUpdateEmployer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployers;
        private System.Windows.Forms.Button btnEmPrevious;
        private System.Windows.Forms.Label lblEmployerID;
        private System.Windows.Forms.Label lblEmployerName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuberb;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEmployerID;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnEmReturn;
        private System.Windows.Forms.Button btnDeleteEmployer;
        private System.Windows.Forms.Button btnEmNext;
        private System.Windows.Forms.Button btnUpdateEmployer;
        private System.Windows.Forms.Button btnAddEmployer;
        private System.Windows.Forms.Panel pnlAddEmployer;
        private System.Windows.Forms.TextBox txtAddEmployerPN;
        private System.Windows.Forms.TextBox txtAddEmployerSuburb;
        private System.Windows.Forms.TextBox txtAddEmployerSA;
        private System.Windows.Forms.TextBox txtAddEmployerName;
        private System.Windows.Forms.Label lblAddEmployerPN;
        private System.Windows.Forms.Label lblAddEmployerSuburb;
        private System.Windows.Forms.Label lblAddEmployerSA;
        private System.Windows.Forms.Label lblAddEmployerName;
        private System.Windows.Forms.Button btnSaveEmployer;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Panel pnlUpdateEmployer;
        private System.Windows.Forms.Button btnUpdateEmCancel;
        private System.Windows.Forms.Button btnUpdateEmSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateEmployerPN;
        private System.Windows.Forms.TextBox txtUpdateEmployerSuburb;
        private System.Windows.Forms.TextBox txtUpdateEmployerSA;
        private System.Windows.Forms.TextBox txtUpdateEmployerName;
        private System.Windows.Forms.TextBox txtUpdateEmployerID;
        private System.Windows.Forms.Label lblUpdateEmployerPN;
        private System.Windows.Forms.Label lblUpdateEmployerSuburb;
        private System.Windows.Forms.Label lblUpdateEmployerSA;
        private System.Windows.Forms.Label lblUpdateEmployerName;
        private System.Windows.Forms.Label lblUpdateEmployerID;
    }
}
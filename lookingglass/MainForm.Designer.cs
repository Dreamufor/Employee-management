namespace LookingGlass
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnASTCandidate = new System.Windows.Forms.Button();
            this.btnASTVacancy = new System.Windows.Forms.Button();
            this.btnVacancy = new System.Windows.Forms.Button();
            this.btnCandidateM = new System.Windows.Forms.Button();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.grpReporting = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnVacancies = new System.Windows.Forms.Button();
            this.grpMaintenance.SuspendLayout();
            this.grpReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnApplication);
            this.grpMaintenance.Controls.Add(this.btnASTCandidate);
            this.grpMaintenance.Controls.Add(this.btnASTVacancy);
            this.grpMaintenance.Controls.Add(this.btnVacancy);
            this.grpMaintenance.Controls.Add(this.btnCandidateM);
            this.grpMaintenance.Controls.Add(this.btnEmployer);
            this.grpMaintenance.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMaintenance.Location = new System.Drawing.Point(50, 30);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(220, 285);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnApplication
            // 
            this.btnApplication.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplication.Location = new System.Drawing.Point(20, 240);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(180, 30);
            this.btnApplication.TabIndex = 5;
            this.btnApplication.Text = "Application Maintenance";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnASTCandidate
            // 
            this.btnASTCandidate.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASTCandidate.Location = new System.Drawing.Point(20, 195);
            this.btnASTCandidate.Name = "btnASTCandidate";
            this.btnASTCandidate.Size = new System.Drawing.Size(180, 30);
            this.btnASTCandidate.TabIndex = 4;
            this.btnASTCandidate.Text = "Assign Skill to a Candidate";
            this.btnASTCandidate.UseVisualStyleBackColor = true;
            this.btnASTCandidate.Click += new System.EventHandler(this.btnASTCandidate_Click);
            // 
            // btnASTVacancy
            // 
            this.btnASTVacancy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnASTVacancy.Location = new System.Drawing.Point(20, 150);
            this.btnASTVacancy.Name = "btnASTVacancy";
            this.btnASTVacancy.Size = new System.Drawing.Size(180, 30);
            this.btnASTVacancy.TabIndex = 3;
            this.btnASTVacancy.Text = "Assign Skill to a Vacancy";
            this.btnASTVacancy.UseVisualStyleBackColor = true;
            this.btnASTVacancy.Click += new System.EventHandler(this.btnASTVacancy_Click);
            // 
            // btnVacancy
            // 
            this.btnVacancy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacancy.Location = new System.Drawing.Point(20, 105);
            this.btnVacancy.Name = "btnVacancy";
            this.btnVacancy.Size = new System.Drawing.Size(180, 30);
            this.btnVacancy.TabIndex = 2;
            this.btnVacancy.Text = "Vacancy Maintenance";
            this.btnVacancy.UseVisualStyleBackColor = true;
            this.btnVacancy.Click += new System.EventHandler(this.btnVacancy_Click);
            // 
            // btnCandidateM
            // 
            this.btnCandidateM.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidateM.Location = new System.Drawing.Point(20, 60);
            this.btnCandidateM.Name = "btnCandidateM";
            this.btnCandidateM.Size = new System.Drawing.Size(180, 30);
            this.btnCandidateM.TabIndex = 1;
            this.btnCandidateM.Text = "Candidate Maintenance";
            this.btnCandidateM.UseVisualStyleBackColor = true;
            this.btnCandidateM.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEmployer
            // 
            this.btnEmployer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployer.Location = new System.Drawing.Point(20, 15);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(180, 30);
            this.btnEmployer.TabIndex = 0;
            this.btnEmployer.Text = "Employer Maintenance";
            this.btnEmployer.UseVisualStyleBackColor = true;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click_1);
            // 
            // grpReporting
            // 
            this.grpReporting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpReporting.BackColor = System.Drawing.SystemColors.Window;
            this.grpReporting.Controls.Add(this.btnExit);
            this.grpReporting.Controls.Add(this.btnCandidates);
            this.grpReporting.Controls.Add(this.btnVacancies);
            this.grpReporting.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReporting.Location = new System.Drawing.Point(320, 30);
            this.grpReporting.Name = "grpReporting";
            this.grpReporting.Size = new System.Drawing.Size(220, 285);
            this.grpReporting.TabIndex = 1;
            this.grpReporting.TabStop = false;
            this.grpReporting.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(20, 240);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnCandidates
            // 
            this.btnCandidates.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCandidates.Location = new System.Drawing.Point(20, 60);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(180, 30);
            this.btnCandidates.TabIndex = 7;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = true;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // btnVacancies
            // 
            this.btnVacancies.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVacancies.Location = new System.Drawing.Point(20, 15);
            this.btnVacancies.Name = "btnVacancies";
            this.btnVacancies.Size = new System.Drawing.Size(180, 30);
            this.btnVacancies.TabIndex = 8;
            this.btnVacancies.Text = "Vacancies";
            this.btnVacancies.UseVisualStyleBackColor = true;
            this.btnVacancies.Click += new System.EventHandler(this.btnVacancies_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.grpReporting);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnASTCandidate;
        private System.Windows.Forms.Button btnASTVacancy;
        private System.Windows.Forms.Button btnVacancy;
        private System.Windows.Forms.Button btnCandidateM;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.GroupBox grpReporting;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnVacancies;
    }
}


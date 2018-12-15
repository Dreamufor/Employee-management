namespace LookingGlass
{
    partial class AssignSkillToVacancyForm
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
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.dSLookingGlass = new LookingGlass.DSLookingGlass();
            this.dgvVancancySkill = new System.Windows.Forms.DataGridView();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.btnASTVReturn = new System.Windows.Forms.Button();
            this.lblSkillYears = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLookingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVancancySkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVacancy
            // 
            this.dgvVacancy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVacancy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Location = new System.Drawing.Point(54, 12);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.RowHeadersVisible = false;
            this.dgvVacancy.RowHeadersWidth = 10;
            this.dgvVacancy.Size = new System.Drawing.Size(468, 150);
            this.dgvVacancy.TabIndex = 0;
            // 
            // dSLookingGlass
            // 
            this.dSLookingGlass.DataSetName = "DSLookingGlass";
            this.dSLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvVancancySkill
            // 
            this.dgvVancancySkill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVancancySkill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVancancySkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVancancySkill.Location = new System.Drawing.Point(12, 168);
            this.dgvVancancySkill.Name = "dgvVancancySkill";
            this.dgvVancancySkill.RowHeadersVisible = false;
            this.dgvVancancySkill.RowHeadersWidth = 10;
            this.dgvVancancySkill.Size = new System.Drawing.Size(210, 150);
            this.dgvVancancySkill.TabIndex = 1;
            // 
            // dgvSkill
            // 
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Location = new System.Drawing.Point(348, 168);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.RowHeadersVisible = false;
            this.dgvSkill.Size = new System.Drawing.Size(224, 150);
            this.dgvSkill.TabIndex = 2;
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnRemoveSkill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveSkill.Location = new System.Drawing.Point(228, 288);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(114, 30);
            this.btnRemoveSkill.TabIndex = 24;
            this.btnRemoveSkill.Text = "Remove Skill";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnAssignSkill.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAssignSkill.Location = new System.Drawing.Point(228, 168);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(114, 30);
            this.btnAssignSkill.TabIndex = 23;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            this.btnAssignSkill.Click += new System.EventHandler(this.btnAssignSkill_Click);
            // 
            // btnASTVReturn
            // 
            this.btnASTVReturn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnASTVReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnASTVReturn.Location = new System.Drawing.Point(450, 324);
            this.btnASTVReturn.Name = "btnASTVReturn";
            this.btnASTVReturn.Size = new System.Drawing.Size(122, 30);
            this.btnASTVReturn.TabIndex = 22;
            this.btnASTVReturn.Text = "Return";
            this.btnASTVReturn.UseVisualStyleBackColor = true;
            this.btnASTVReturn.Click += new System.EventHandler(this.btnASTVReturn_Click);
            // 
            // lblSkillYears
            // 
            this.lblSkillYears.AutoSize = true;
            this.lblSkillYears.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillYears.Location = new System.Drawing.Point(246, 235);
            this.lblSkillYears.Name = "lblSkillYears";
            this.lblSkillYears.Size = new System.Drawing.Size(48, 17);
            this.lblSkillYears.TabIndex = 25;
            this.lblSkillYears.Text = "Years: ";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(294, 234);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(42, 20);
            this.txtYears.TabIndex = 26;
            // 
            // AssignSkillToVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblSkillYears);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.btnASTVReturn);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.dgvVancancySkill);
            this.Controls.Add(this.dgvVacancy);
            this.Name = "AssignSkillToVacancyForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLookingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVancancySkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVacancy;
        private DSLookingGlass dSLookingGlass;
        private System.Windows.Forms.DataGridView dgvVancancySkill;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.Button btnASTVReturn;
        private System.Windows.Forms.Label lblSkillYears;
        private System.Windows.Forms.TextBox txtYears;
    }
}
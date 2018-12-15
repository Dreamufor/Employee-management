namespace LookingGlass
{
    partial class AssignSkillToCandidateForm
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
            this.txtYearsC = new System.Windows.Forms.TextBox();
            this.lblSkillYearsC = new System.Windows.Forms.Label();
            this.btnRemoveSkillC = new System.Windows.Forms.Button();
            this.btnAssignSkillC = new System.Windows.Forms.Button();
            this.btnASTVReturn = new System.Windows.Forms.Button();
            this.dgvCSkill = new System.Windows.Forms.DataGridView();
            this.dSLookingGlass = new LookingGlass.DSLookingGlass();
            this.dgvCandidateSkill = new System.Windows.Forms.DataGridView();
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLookingGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYearsC
            // 
            this.txtYearsC.Location = new System.Drawing.Point(294, 231);
            this.txtYearsC.Name = "txtYearsC";
            this.txtYearsC.Size = new System.Drawing.Size(42, 20);
            this.txtYearsC.TabIndex = 34;
            // 
            // lblSkillYearsC
            // 
            this.lblSkillYearsC.AutoSize = true;
            this.lblSkillYearsC.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillYearsC.Location = new System.Drawing.Point(246, 232);
            this.lblSkillYearsC.Name = "lblSkillYearsC";
            this.lblSkillYearsC.Size = new System.Drawing.Size(48, 17);
            this.lblSkillYearsC.TabIndex = 33;
            this.lblSkillYearsC.Text = "Years: ";
            // 
            // btnRemoveSkillC
            // 
            this.btnRemoveSkillC.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnRemoveSkillC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRemoveSkillC.Location = new System.Drawing.Point(228, 285);
            this.btnRemoveSkillC.Name = "btnRemoveSkillC";
            this.btnRemoveSkillC.Size = new System.Drawing.Size(114, 30);
            this.btnRemoveSkillC.TabIndex = 32;
            this.btnRemoveSkillC.Text = "Remove Skill";
            this.btnRemoveSkillC.UseVisualStyleBackColor = true;
            this.btnRemoveSkillC.Click += new System.EventHandler(this.btnRemoveSkillC_Click);
            // 
            // btnAssignSkillC
            // 
            this.btnAssignSkillC.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnAssignSkillC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAssignSkillC.Location = new System.Drawing.Point(228, 165);
            this.btnAssignSkillC.Name = "btnAssignSkillC";
            this.btnAssignSkillC.Size = new System.Drawing.Size(114, 30);
            this.btnAssignSkillC.TabIndex = 31;
            this.btnAssignSkillC.Text = "Assign Skill";
            this.btnAssignSkillC.UseVisualStyleBackColor = true;
            this.btnAssignSkillC.Click += new System.EventHandler(this.btnAssignSkillC_Click);
            // 
            // btnASTVReturn
            // 
            this.btnASTVReturn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnASTVReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnASTVReturn.Location = new System.Drawing.Point(450, 321);
            this.btnASTVReturn.Name = "btnASTVReturn";
            this.btnASTVReturn.Size = new System.Drawing.Size(122, 30);
            this.btnASTVReturn.TabIndex = 30;
            this.btnASTVReturn.Text = "Return";
            this.btnASTVReturn.UseVisualStyleBackColor = true;
            this.btnASTVReturn.Click += new System.EventHandler(this.btnASTVReturn_Click);
            // 
            // dgvCSkill
            // 
            this.dgvCSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCSkill.Location = new System.Drawing.Point(348, 165);
            this.dgvCSkill.Name = "dgvCSkill";
            this.dgvCSkill.RowHeadersVisible = false;
            this.dgvCSkill.Size = new System.Drawing.Size(224, 150);
            this.dgvCSkill.TabIndex = 29;
            // 
            // dSLookingGlass
            // 
            this.dSLookingGlass.DataSetName = "DSLookingGlass";
            this.dSLookingGlass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvCandidateSkill
            // 
            this.dgvCandidateSkill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCandidateSkill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCandidateSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateSkill.Location = new System.Drawing.Point(4, 165);
            this.dgvCandidateSkill.Name = "dgvCandidateSkill";
            this.dgvCandidateSkill.RowHeadersVisible = false;
            this.dgvCandidateSkill.RowHeadersWidth = 10;
            this.dgvCandidateSkill.Size = new System.Drawing.Size(218, 150);
            this.dgvCandidateSkill.TabIndex = 28;
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCandidate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Location = new System.Drawing.Point(34, 9);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.RowHeadersVisible = false;
            this.dgvCandidate.RowHeadersWidth = 10;
            this.dgvCandidate.Size = new System.Drawing.Size(519, 150);
            this.dgvCandidate.TabIndex = 27;
            // 
            // AssignSkillToCandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.txtYearsC);
            this.Controls.Add(this.lblSkillYearsC);
            this.Controls.Add(this.btnRemoveSkillC);
            this.Controls.Add(this.btnAssignSkillC);
            this.Controls.Add(this.btnASTVReturn);
            this.Controls.Add(this.dgvCSkill);
            this.Controls.Add(this.dgvCandidateSkill);
            this.Controls.Add(this.dgvCandidate);
            this.Name = "AssignSkillToCandidateForm";
            this.Text = "AssignSkillToCandidateForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLookingGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYearsC;
        private System.Windows.Forms.Label lblSkillYearsC;
        private System.Windows.Forms.Button btnRemoveSkillC;
        private System.Windows.Forms.Button btnAssignSkillC;
        private System.Windows.Forms.Button btnASTVReturn;
        private System.Windows.Forms.DataGridView dgvCSkill;
        private DSLookingGlass dSLookingGlass;
        private System.Windows.Forms.DataGridView dgvCandidateSkill;
        private System.Windows.Forms.DataGridView dgvCandidate;
    }
}
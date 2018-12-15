namespace LookingGlass
{
    partial class VacanciesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacanciesReportForm));
            this.btnPrintVacancies = new System.Windows.Forms.Button();
            this.btnVacanciesReportReturn = new System.Windows.Forms.Button();
            this.printVacancies = new System.Drawing.Printing.PrintDocument();
            this.prvVacancy = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintVacancies
            // 
            this.btnPrintVacancies.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnPrintVacancies.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintVacancies.Location = new System.Drawing.Point(42, 67);
            this.btnPrintVacancies.Name = "btnPrintVacancies";
            this.btnPrintVacancies.Size = new System.Drawing.Size(133, 30);
            this.btnPrintVacancies.TabIndex = 72;
            this.btnPrintVacancies.Text = "Print Vacancies";
            this.btnPrintVacancies.UseVisualStyleBackColor = true;
            this.btnPrintVacancies.Click += new System.EventHandler(this.btnPrintVacancies_Click);
            // 
            // btnVacanciesReportReturn
            // 
            this.btnVacanciesReportReturn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnVacanciesReportReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVacanciesReportReturn.Location = new System.Drawing.Point(204, 67);
            this.btnVacanciesReportReturn.Name = "btnVacanciesReportReturn";
            this.btnVacanciesReportReturn.Size = new System.Drawing.Size(137, 30);
            this.btnVacanciesReportReturn.TabIndex = 71;
            this.btnVacanciesReportReturn.Text = "Return";
            this.btnVacanciesReportReturn.UseVisualStyleBackColor = true;
            this.btnVacanciesReportReturn.Click += new System.EventHandler(this.btnVacanciesReportReturn_Click);
            // 
            // printVacancies
            // 
            this.printVacancies.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printVacancies_PrintPage);
            // 
            // prvVacancy
            // 
            this.prvVacancy.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvVacancy.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvVacancy.ClientSize = new System.Drawing.Size(400, 300);
            this.prvVacancy.Document = this.printVacancies;
            this.prvVacancy.Enabled = true;
            this.prvVacancy.Icon = ((System.Drawing.Icon)(resources.GetObject("prvVacancy.Icon")));
            this.prvVacancy.Name = "prvVacancy";
            this.prvVacancy.Visible = false;
            // 
            // VacanciesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnPrintVacancies);
            this.Controls.Add(this.btnVacanciesReportReturn);
            this.Name = "VacanciesReportForm";
            this.Text = "VacanciesReportForm";
            this.Load += new System.EventHandler(this.VacanciesReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrintVacancies;
        private System.Windows.Forms.Button btnVacanciesReportReturn;
        private System.Drawing.Printing.PrintDocument printVacancies;
        private System.Windows.Forms.PrintPreviewDialog prvVacancy;
    }
}
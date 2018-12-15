namespace LookingGlass
{
    partial class CandidateReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateReportForm));
            this.btnPrintCandidates = new System.Windows.Forms.Button();
            this.btnCandidatesReportReturn = new System.Windows.Forms.Button();
            this.printCandidates = new System.Drawing.Printing.PrintDocument();
            this.prvCandidates = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnPrintCandidates
            // 
            this.btnPrintCandidates.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnPrintCandidates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrintCandidates.Location = new System.Drawing.Point(43, 65);
            this.btnPrintCandidates.Name = "btnPrintCandidates";
            this.btnPrintCandidates.Size = new System.Drawing.Size(133, 30);
            this.btnPrintCandidates.TabIndex = 74;
            this.btnPrintCandidates.Text = "Print Candidates";
            this.btnPrintCandidates.UseVisualStyleBackColor = true;
            this.btnPrintCandidates.Click += new System.EventHandler(this.btnPrintCandidates_Click);
            // 
            // btnCandidatesReportReturn
            // 
            this.btnCandidatesReportReturn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.btnCandidatesReportReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCandidatesReportReturn.Location = new System.Drawing.Point(205, 65);
            this.btnCandidatesReportReturn.Name = "btnCandidatesReportReturn";
            this.btnCandidatesReportReturn.Size = new System.Drawing.Size(137, 30);
            this.btnCandidatesReportReturn.TabIndex = 73;
            this.btnCandidatesReportReturn.Text = "Return";
            this.btnCandidatesReportReturn.UseVisualStyleBackColor = true;
            this.btnCandidatesReportReturn.Click += new System.EventHandler(this.btnCandidatesReportReturn_Click);
            // 
            // printCandidates
            // 
            this.printCandidates.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCandidates_PrintPage);
            // 
            // prvCandidates
            // 
            this.prvCandidates.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvCandidates.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvCandidates.ClientSize = new System.Drawing.Size(400, 300);
            this.prvCandidates.Document = this.printCandidates;
            this.prvCandidates.Enabled = true;
            this.prvCandidates.Icon = ((System.Drawing.Icon)(resources.GetObject("prvCandidates.Icon")));
            this.prvCandidates.Name = "prvCandidates";
            this.prvCandidates.Visible = false;
            // 
            // CandidateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.btnPrintCandidates);
            this.Controls.Add(this.btnCandidatesReportReturn);
            this.Name = "CandidateReportForm";
            this.Text = "CandidateReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintCandidates;
        private System.Windows.Forms.Button btnCandidatesReportReturn;
        private System.Drawing.Printing.PrintDocument printCandidates;
        private System.Windows.Forms.PrintPreviewDialog prvCandidates;
    }
}
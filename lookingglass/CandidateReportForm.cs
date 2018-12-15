using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlass
{

    public partial class CandidateReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfCandidatesPrinted, pagesAmountExpected;
        private DataRow[] candidatesForPrint;

        public CandidateReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void btnCandidatesReportReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrintCandidates_Click(object sender, EventArgs e)
        {
            amountOfCandidatesPrinted = 0;
            candidatesForPrint = DM.dtCandidate.Select();
            pagesAmountExpected = candidatesForPrint.Length;
            prvCandidates.Show();
        }

        private void printCandidates_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 15, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 15, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 15, FontStyle.Bold);
            Font headingFont = new Font("Arial", 15, FontStyle.Bold);

            DataRow drCandidate = candidatesForPrint[amountOfCandidatesPrinted];
            CurrencyManager cmApplication;
            CurrencyManager cmSkill;
            CurrencyManager cmCandidateSkill;
            CurrencyManager cmVacancy;

            cmApplication = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Application"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Skill"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "CandidateSkill"];
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Vacancy"];
            //Margins
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            //Heading
            g.DrawString("Candidate ID:             " + drCandidate["CandidateID"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin);
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString(drCandidate["FirstName"].ToString()+" "+ drCandidate["LastName"].ToString() + " ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString(drCandidate["StreetAddress"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString(drCandidate["Suburb"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drCandidateSkill = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["Candidate_CandidateSkill"]);
            if (drCandidateSkill.Length == 0)
            {
                g.DrawString("No skills have been allocated to this candidate", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                g.DrawString("Skills: ", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;

                int SkillCount = 0;//Declare a int for output multiple rows
                foreach (DataRow drCandidateS in drCandidateSkill)
                {
                    //Get related skill records via SkillID
                    int aSkillID = Convert.ToInt32(drCandidateS["SkillID"].ToString());
                    cmSkill.Position = DM.skillView.Find(aSkillID);
                    DataRow drSkill = DM.dtSkill.Rows[cmSkill.Position];
                    if (drCandidateS["Years"].ToString() == "1")
                    {
                        g.DrawString(drSkill["Description"] + ":     " + drCandidateS["Years"] + "  year", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    }
                    else
                    {
                        g.DrawString(drSkill["Description"] + ":     " + drCandidateS["Years"] + "  years", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    }
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    SkillCount++;
                }

            }
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drApplication = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["Candidate_Application"]);
            if (drApplication.Length == 0)
            {
                g.DrawString("No applications have been made by this candidate", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                g.DrawString("Current Vacancy Applications:", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;

                int ApplicationCount = 0;
                foreach (DataRow drCandidateA in drApplication)
                {
                    //Get related Vacancy records via VacancyID
                    int aVacancyID = Convert.ToInt32(drCandidateA["VacancyID"].ToString());
                    cmVacancy.Position = DM.vacancyView.Find(aVacancyID);
                    DataRow drVacancy = DM.dtVacancy.Rows[cmVacancy.Position];

                    g.DrawString("Vacancy ID: "+ drCandidateA["VacancyID"] + "  " + drVacancy["Description"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));

                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    ApplicationCount++;
                }

            }
            amountOfCandidatesPrinted++;
            if (!(amountOfCandidatesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

        private void CandidateReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}

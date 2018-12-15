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
    public partial class VacanciesReportForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfVacanciesPrinted, pagesAmountExpected;
        private DataRow[] vacanciesForPrint;


        public VacanciesReportForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
        }

        private void VacanciesReportForm_Load(object sender, EventArgs e)
        {

        }

        private void btnVacanciesReportReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printVacancies_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 15, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 15, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 15, FontStyle.Bold);
            Font headingFont = new Font("Arial", 15, FontStyle.Bold);
            
            DataRow drVacancy = vacanciesForPrint[amountOfVacanciesPrinted];
            CurrencyManager cmEmployer;
            CurrencyManager cmSkill;
            CurrencyManager cmVacancySkill;
            //Binding data
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Employer"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass,"Skill"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VacancySkill"];
            //Margins
            Brush brush = new SolidBrush(Color.Black);
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            //Heading
            g.DrawString("Vacancy ID:             " + drVacancy["VacancyID"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin);
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Description:            " + drVacancy["Description"].ToString(), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            //Get related Employer records via EmployerID
            int aEMployerID = Convert.ToInt32(drVacancy["EmployerID"].ToString());
            cmEmployer.Position = DM.employerView.Find(aEMployerID);
            DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];

            g.DrawString("Employer Name:     " + drEmployer["EmployerName"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Status:                     " + drVacancy["Status"], headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Salary:                      NZ$" + string.Format("{0:###,000.00}", drVacancy["Salary"]), headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drVacancySkill = drVacancy.GetChildRows(DM.dtVacancy.ChildRelations["VACANCY_VACANCYSKILL"]);
            if (drVacancySkill.Length == 0)
            {
                g.DrawString("No skills have been allocated to this vacancy", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                g.DrawString("Skills", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;

                int SkillCount = 0;
                foreach (DataRow drVacancyS in drVacancySkill)
                {
                    //Get related skill records via SkillID
                    int aSkillID = Convert.ToInt32(drVacancyS["SkillID"].ToString());
                    cmSkill.Position = DM.skillView.Find(aSkillID);
                    DataRow drSkill = DM.dtSkill.Rows[cmSkill.Position];
                    if(drVacancyS["Years"].ToString() == "1")//To decide whether display year or years
                    {
                        g.DrawString(drSkill["Description"] + ":     " + drVacancyS["Years"] + "  year", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    }
                    else
                    {
                        g.DrawString(drSkill["Description"] + ":     " + drVacancyS["Years"] + "  years", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                    }
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    linesSoFarHeading++;
                    SkillCount++;
                }
                
            }
            amountOfVacanciesPrinted++;
            if(!(amountOfVacanciesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }

        }

        private void btnPrintVacancies_Click(object sender, EventArgs e)
        {
            amountOfVacanciesPrinted = 0;
            vacanciesForPrint = DM.dtVacancy.Select();
            pagesAmountExpected = vacanciesForPrint.Length;
            prvVacancy.Show();
        }
    }
}

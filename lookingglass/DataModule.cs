using System.Data.OleDb;
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
    public partial class DataModule : Form
    {   
        //connect data as a transit station
        public DataTable dtEmployer;
        public DataTable dtCandidate;
        public DataTable dtVacancy;
        public DataTable dtSkill;
        public DataTable dtCandidateSkill;
        public DataTable dtApplication;
        public DataTable dtVacancySkill;
        public DataView employerView;
        public DataView candidateView;
        public DataView vacancyView;
        public DataView skillView;
        public DataView candidateSkillView;
        public DataView vacancySkillView;
        public DataView applicationView;


        public DataModule()
        {
            InitializeComponent();
            dsLookingGlass.EnforceConstraints = false;
            daEmployer.Fill(dsLookingGlass);
            daApplication.Fill(dsLookingGlass);
            daCandidate.Fill(dsLookingGlass);
            daCandidateSkill.Fill(dsLookingGlass);
            daSkill.Fill(dsLookingGlass);
            daVacancy.Fill(dsLookingGlass);
            daVacancySkill.Fill(dsLookingGlass);
            //Binding data from dslookingglass
            dtEmployer = dsLookingGlass.Tables["Employer"];
            dtApplication = dsLookingGlass.Tables["Application"];
            dtCandidate = dsLookingGlass.Tables["Candidate"];
            dtCandidateSkill = dsLookingGlass.Tables["CandidateSkill"];
            dtSkill = dsLookingGlass.Tables["Skill"];
            dtVacancy = dsLookingGlass.Tables["Vacancy"];
            dtVacancySkill = dsLookingGlass.Tables["VacancySkill"];
            dsLookingGlass.EnforceConstraints = true;

            employerView = new DataView(dtEmployer);
            employerView.Sort = "EmployerID";

            candidateView = new DataView(dtCandidate);
            candidateView.Sort = "CandidateID";

            vacancyView = new DataView(dtVacancy);
            vacancyView.Sort = "VacancyID";

            skillView = new DataView(dtSkill);
            skillView.Sort = "SkillID";

            candidateSkillView = new DataView(dtCandidateSkill);
            candidateSkillView.Sort = "CandidateID";

            vacancySkillView = new DataView(dtVacancySkill);
            vacancySkillView.Sort = "VacancyID";

        }
        public void UpdateEmployer()
        {
            daEmployer.Update(dtEmployer);
        }
        public void UpdateCandidate()
        {
            daCandidate.Update(dtCandidate);
        }
        public void UpdateVacancy()
        {
            daVacancy.Update(dtVacancy);
        }
        public void UpdateVacancySkill()
        {
            daVacancySkill.Update(dtVacancySkill);
        }
        public void UpdateCandidateSkill()
        {
            daCandidateSkill.Update(dtCandidateSkill);
        }
        public void UpdateApplicationl()
        {
            daApplication.Update(dtApplication);
        }
        private void DataModule_Load(object sender, EventArgs e)
        {

        }

        private void oleDbDataAdapter1_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void oleDbDataAdapter1_RowUpdated_1(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void daEmployer_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }

        private void daEmployer_FillError(object sender, FillErrorEventArgs e)
        {

        }
    }
}

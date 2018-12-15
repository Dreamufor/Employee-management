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
    public partial class MainForm : Form  
    {
        private DataModule DM; //the reference to the data component form

        //the reference to each child form of the main form
        private EmployerMaintenanceForm frmEmployerMaintenance;
        private CandidateMaintenanceForm frmCandidateMaintenance;
        private VacancyMaintenanceForm frmVacancyMaintenance;
        private AssignSkillToVacancyForm frmASTV;
        private AssignSkillToCandidateForm frmASTC;
        private ApplicationMaintenanceForm frmAM;
        private VacanciesReportForm frmVR;
        private CandidateReportForm frmCR;
        
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();//create the data module and load the dataset
        }
      
        private void button5_Click(object sender, EventArgs e)
        {
            if (frmCandidateMaintenance == null)
            {
                frmCandidateMaintenance = new CandidateMaintenanceForm(DM, this);//load Candidate Maintenance Form
            }
            frmCandidateMaintenance.ShowDialog();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnEmployer_Click_1(object sender, EventArgs e)
        {
            if (frmEmployerMaintenance == null)
            {
                frmEmployerMaintenance = new EmployerMaintenanceForm(DM, this);//load Employer Maintenance Form
            }
            frmEmployerMaintenance.ShowDialog();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();//exit the main form 
        }

        private void btnVacancy_Click(object sender, EventArgs e)
        {
            if (frmVacancyMaintenance == null)
            {
                frmVacancyMaintenance = new VacancyMaintenanceForm(DM, this);//load vacancy Maintenance Form
            }
            frmVacancyMaintenance.ShowDialog();
        }

        private void btnASTVacancy_Click(object sender, EventArgs e)
        {
            if (frmASTV == null)
            {
                frmASTV = new AssignSkillToVacancyForm(DM, this);//load Assign skill to vacancy Form
            }
            frmASTV.ShowDialog();
        }

        private void btnASTCandidate_Click(object sender, EventArgs e)
        {
            if (frmASTC == null)
            {
                frmASTC = new AssignSkillToCandidateForm(DM, this);//load Assign skill to candidate Form;
            }
            frmASTC.ShowDialog();
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            if (frmAM == null)
            {
                frmAM = new ApplicationMaintenanceForm(DM, this);//load Application Form
            }
            frmAM.ShowDialog();
        }

        private void btnVacancies_Click(object sender, EventArgs e)
        {
            if (frmVR == null)
            {
                frmVR = new VacanciesReportForm(DM, this); //load vacancy report form 
            }
            frmVR.ShowDialog();
        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            if (frmCR == null)
            {
                frmCR = new CandidateReportForm(DM, this);//load candidate report form
            }
            frmCR.ShowDialog();
        }
    }
}

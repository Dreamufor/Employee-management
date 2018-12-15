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
    public partial class ApplicationMaintenanceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmApplication;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmEmployer;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmCandidateSkill;
        private Boolean canSave = false; //To deside if eath loop meet the condition

        public ApplicationMaintenanceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            pnlAddApplication.Left = 220;
            pnlAddApplication.Top = 25;
            cmApplication = (CurrencyManager)this.BindingContext[DM.dsLookingGlass,"Application"];
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Vacancy"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Employer"];
            cmCandidate = (CurrencyManager)this.BindingContext[DM.dsLookingGlass,"Candidate"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VacancySkill"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "CandidateSkill"];
            BindControls();
        }
        public void BindControls()
        {
            dgvApplication.DataSource = DM.dsLookingGlass;
            dgvApplication.DataMember = "Application";
            lblVacancyID.DataBindings.Add("Text", DM.dsLookingGlass, "Application.VacancyID");
            lblCandidateID.DataBindings.Add("Text", DM.dsLookingGlass, "Application.CandidateID");
            lblEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.EmployerID");
        }

        private void LoadApplication()
        {
            //load the data in combo boxes
            cboAMCandidateID.DataSource = DM.dsLookingGlass;
            cboAMCandidateID.DisplayMember = "Candidate.CandidateID";
            cboAMCandidateID.ValueMember = "Candidate.CandidateID";
            cboAMCandidateName.DataSource = DM.dsLookingGlass;
            cboAMCandidateName.DisplayMember = "Candidate.LastName";
            cboAMCandidateName.ValueMember = "Candidate.LastName";
            cboAMVacancyID.DataSource = DM.dsLookingGlass;
            cboAMVacancyID.DisplayMember = "Vacancy.VacancyID";
            cboAMVacancyID.ValueMember = "Vacancy.VacancyID";
            cboAMVacancyDescription.DataSource = DM.dsLookingGlass;
            cboAMVacancyDescription.DisplayMember = "Vacancy.Description";
            cboAMVacancyDescription.ValueMember = "Vacancy.Description";
        }

        private void btnApplicationReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            dgvApplication.Visible = false;
            btnDeleteApplication.Enabled = false;
            btnApplicationReturn.Enabled = false;
            pnlAddApplication.Show();
            LoadApplication();
        }

        private void btnAddACancel_Click(object sender, EventArgs e)
        {
            pnlAddApplication.Hide();
            dgvApplication.Visible = true;
            btnDeleteApplication.Enabled = true;
            btnApplicationReturn.Enabled = true;

        }

        private void lblVacancyID_TextChanged(object sender, EventArgs e)//Use textchange event to display data in related table
        {
            if(lblVacancyID.Text == "")
            {
                txtApplicationDescription.Text = "";
                txtApplicationSalary.Text = "";
            }
            else
            {
                int aVacancyID = Convert.ToInt32(lblVacancyID.Text);
                cmVacancy.Position = DM.vacancyView.Find(aVacancyID);
                DataRow drVacancy = DM.dtVacancy.Rows[cmVacancy.Position];
                txtApplicationDescription.Text = drVacancy["Description"].ToString();
                txtApplicationSalary.Text = drVacancy["Salary"].ToString();
            }
        }

        private void lblEmployerID_TextChanged(object sender, EventArgs e)//Use textchange event to display data in related table
        {
            if (lblEmployerID.Text == "EmployerID:")
            {
                txtApplicationEmName.Text = "";
            }
            else
            {
                int aEmployerID = Convert.ToInt32(lblEmployerID.Text);//Change the data type
                cmEmployer.Position = DM.employerView.Find(aEmployerID);
                DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
                txtApplicationEmName.Text = drEmployer["EmployerName"].ToString();//Binding the data
        }
        }

        private void lblCandidateID_TextChanged(object sender, EventArgs e)
        {
            if (lblCandidateID.Text == "")
            {
                txtCandidateFullName.Text = "";
            }
            else
            {
                int aCandidateID = Convert.ToInt32(lblCandidateID.Text);
                cmCandidate.Position = DM.candidateView.Find(aCandidateID);
                DataRow drCandidate = DM.dtCandidate.Rows[cmCandidate.Position];
                txtCandidateFullName.Text = drCandidate["FirstName"].ToString() + " " + drCandidate["LastName"].ToString();
                
            }
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            DataRow deleteApplicationRow = DM.dtApplication.Rows[cmApplication.Position];

            if (MessageBox.Show("Are you sure you want to delete this application record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteApplicationRow.Delete();
                DM.UpdateEmployer();
                MessageBox.Show("Application deleted successfully");
            }
            else
            {
                return;
            }
        }

        private void btnSaveApplication_Click(object sender, EventArgs e)
        {
            DataRow newApplicationRow = DM.dtApplication.NewRow();//Create a new row for data to be added into
            DataRow drCandidate = DM.dtCandidate.Rows[cmCandidate.Position];
            DataRow drVancancy = DM.dtVacancy.Rows[cmVacancy.Position];

            DataRow[] drCandidateSkills = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["Candidate_CandidateSkill"]);
            DataRow[] drVacancySkills = drVancancy.GetChildRows(DM.dtVacancy.ChildRelations["Vacancy_VacancySkill"]);

            DataRow[] checkConfirmedRow = DM.dtVacancy.Select("VacancyID = " + cboAMVacancyID.Text);//To check vacancy status 

            if (checkConfirmedRow[0].ItemArray[2].ToString() == "filled")//locate the status in the third row of table
            {
                MessageBox.Show("Candidates can only apply to current vacancies", "Warning");
                return;
            }
            else
            {
                foreach (DataRow drVacancySkill in drVacancySkills)//Find all the related skill in VacancySkill
                {

                    foreach (DataRow drCandidateSkill in drCandidateSkills)//Find all the related skill in CandidateSkill
                    {
                        canSave = false;
                        //Get the skill from two table
                        int vsSkill = Convert.ToInt32(drVacancySkill["SkillID"].ToString());//Cannot compare with two object!!!
                        int csSkill = Convert.ToInt32(drCandidateSkill["SkillID"].ToString());//Must be converted
                        if (vsSkill == csSkill)//Check if the Candidate have the same skill of Vacancy.
                        {
                            //Converted the data type
                            int vsYears = Convert.ToInt32(drVacancySkill["Years"].ToString());
                            int csYears = Convert.ToInt32(drCandidateSkill["Years"].ToString());
                            if (vsYears <= csYears)//Check if the year meet the condition
                            {
                                canSave = true;
                                break;//break and jump to next loop and compare next skill
                            }
                        }
                    }
                    if (!canSave)
                    {
                        break;
                    }
                }
                if (canSave)
                {
                    //Add new row in the table
                    newApplicationRow["VacancyID"] = cboAMVacancyID.Text;
                    newApplicationRow["CandidateID"] = cboAMCandidateID.Text;
                    DM.dtApplication.Rows.Add(newApplicationRow);
                    MessageBox.Show("Application added successfully", "Success");
                    DM.UpdateApplicationl();
                }
                else
                {
                    MessageBox.Show("The candidate does not have the experience to apply for the vacancy");
                }
                return;
            }
        }
    }
}

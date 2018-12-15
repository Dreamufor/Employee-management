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
    public partial class VacancyMaintenanceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmEmployer;

        public VacancyMaintenanceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddVacancy.Left = 210;
            pnlAddVacancy.Top = 20;
            pnlUpdateVacancy.Left = 210;
            pnlUpdateVacancy.Top = 20;
        }

        public void BindControls()
        {
            lstVacancyDescription.DataSource = DM.dsLookingGlass;
            lstVacancyDescription.DisplayMember = "Vacancy.Description";
            lstVacancyDescription.ValueMember = "Vacancy.Description";
            lblVacancyEmID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.EmployerID");
            txtVacancyID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.VacancyID");
            txtVacancyDescription.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Description");
            txtVacancyStatus.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Status");
            txtVacancySalary.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Salary");
            txtVacancyEmID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.EmployerID");
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VACANCY"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
        }

        private void LoadEmployer()
        {
            cboEmID.DataSource = DM.dsLookingGlass;
            cboEmID.DisplayMember = "Employer.EmployerID";
            cboEmID.ValueMember = "Employer.EmployerID";
            cboEmName.DataSource = DM.dsLookingGlass;
            cboEmName.DisplayMember = "Employer.EmployerName";
            cboEmName.ValueMember = "Employer.EmployerID";
        }
        private void VacancyMaintenanceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnVacancyPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnVacancyNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnVacancyReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            lstVacancyDescription.Visible = false;
            lblVEm.Enabled = false;
            lblVEm.Visible = false;
            btnVacancyPrevious.Enabled = false;
            btnVacancyNext.Enabled = false;
            btnUpdateVacancy.Enabled = false;
            btnVacancyReturn.Enabled = false;
            btnDeleteVacancy.Enabled = false;
            btnVacancyMVAF.Enabled = false;
            pnlAddVacancy.Show();
            LoadEmployer();
        }

        private void btnSaveVacancy_Click(object sender, EventArgs e)
        {
            //Create a new row that variables will be added into
            DataRow newVacancyRow = DM.dtVacancy.NewRow();
            //If the salary isn't fulfill the condition then do not write data and return;
            if ((txtAddVacancyDescription.Text == "") || (txtAddVacancySalary.Text == ""))
            {
                MessageBox.Show("You must type a value for each of the text fields", "Error");
                return;
            }
            //transfer the object then it can compare with number .
            int x = Convert.ToInt32(this.txtAddVacancySalary.Text);
            if (x < 30000 || x > 200000)
            {
                MessageBox.Show("The salary must meet the condition of between 30000 and 200000", "Error");
                return;
            }
            else
            {
                newVacancyRow["Description"] = txtAddVacancyDescription.Text;
                newVacancyRow["Salary"] = txtAddVacancySalary.Text;
                newVacancyRow["Status"] = "current";
                newVacancyRow["EmployerID"] = cboEmID.Text;
                DM.dtVacancy.Rows.Add(newVacancyRow);
                DM.UpdateVacancy();
                MessageBox.Show("Vacancy added successfully", "Success");
            }
            return;
        }

        private void btnAddVacancyCancel_Click(object sender, EventArgs e)
        {
            pnlAddVacancy.Hide();
            lstVacancyDescription.Enabled = true;
            lstVacancyDescription.Visible = true;
            btnVacancyPrevious.Enabled = true;
            btnVacancyNext.Enabled = true;
            btnUpdateVacancy.Enabled = true;
            btnDeleteVacancy.Enabled = true;
            btnVacancyMVAF.Enabled = true;
            btnVacancyReturn.Enabled = true;
            lblVEm.Enabled = true;
            lblVEm.Visible = true;
        }

        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            lstVacancyDescription.Visible = false;
            lstVacancyDescription.Enabled = false;
            lstVacancyDescription.SelectedItem = false;
            lblVEm.Enabled = false;
            lblVEm.Visible = false;
            btnVacancyPrevious.Enabled = false;
            btnVacancyNext.Enabled = false;
            btnAddVacancy.Enabled = false;
            btnVacancyReturn.Enabled = false;
            btnDeleteVacancy.Enabled = false;
            btnVacancyMVAF.Enabled = false;
            pnlUpdateVacancy.Show();
            txtUpdateVacancyDescription.Text = txtVacancyDescription.Text;
            txtUpdateVacancySalary.Text = txtVacancySalary.Text;
            txtUpdateVacancyID.Text = txtVacancyID.Text;
            txtUpdateVacancyStatus.Text = txtVacancyStatus.Text;
            txtUpdateVacancyEmName.Text = txtVacancyEmName.Text;

        }

        private void btnUpdateVSaveChanges_Click(object sender, EventArgs e)
        {
            //Create a new row that variables will be added into;
            DataRow updateVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];

            //Determine if the textboxs are empty then return.
            if ((txtUpdateVacancyDescription.Text == "")||(txtUpdateVacancySalary.Text == ""))
            {
                MessageBox.Show("You must type in Vacancy's description or salary", "Error");
                return;
            }
            else
            {
                //Add the text to the new Row.
                updateVacancyRow["Description"] = txtUpdateVacancyDescription.Text;
                updateVacancyRow["Salary"] = txtUpdateVacancySalary.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateVacancy();
                MessageBox.Show("Vacancy updated successfully", "Success");
            }
            return;
        }

        private void btnUpdateVCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateVacancy.Hide();
            lstVacancyDescription.Enabled = true;
            lstVacancyDescription.Visible = true;
            btnVacancyPrevious.Enabled = true;
            btnVacancyNext.Enabled = true;
            btnAddVacancy.Enabled = true;
            btnUpdateVacancy.Enabled = true;
            btnDeleteVacancy.Enabled = true;
            btnVacancyMVAF.Enabled = true;
            btnVacancyReturn.Enabled = true;
            lblVEm.Enabled = true;
            lblVEm.Visible = true;
        }

        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            CurrencyManager cmVacancySkill;
            cmVacancySkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VacancySkill"];
            //Select the related data.
            int aVacancyID = Convert.ToInt32(txtVacancyID.Text);
            cmVacancySkill.Position = DM.vacancySkillView.Find(aVacancyID);
            DataRow[] VacanciSkillRow = DM.dtVacancySkill.Select("VacancyID =" + aVacancyID);
           //Create new row for delete 
            DataRow deleteVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            DataRow[] drApplication = deleteVacancyRow.GetChildRows(DM.dtVacancy.ChildRelations["VACANCY_APPLICATION"]);//Get the position of the determined table
            if (drApplication.Length == 0)//determine if existed or not
            {
                if (MessageBox.Show("Are you sure you want to delete this vacancy record?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    foreach (DataRow dvs in VacanciSkillRow)//delete all the records in VacancySKill
                    {
                        dvs.Delete();
                    }
                    deleteVacancyRow.Delete();
                    //update row
                    DM.UpdateVacancySkill();
                    DM.UpdateVacancy();
                    MessageBox.Show("Vacancy deleted successfully","Success");
                    MessageBox.Show("Vacancy Skills deleted successfully","Success");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete Vacancies who have no applications", "Error");
            }
            return;
        }

        private void lblVacancyEmID_TextChanged(object sender, EventArgs e)//Show related data in another table
        {
            if(lblVacancyEmID.Text == "EmployerID:")
            {
                txtVacancyEmName.Text = "";
            }
            else
            {
                int aEmployerID = Convert.ToInt32(lblVacancyEmID.Text); // use foreign key to find the position
                cmEmployer.Position = DM.employerView.Find(aEmployerID);
                DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
                txtVacancyEmName.Text = drEmployer["EmployerName"].ToString();
            }
        }

        private void btnVacancyMVAF_Click(object sender, EventArgs e)
        {
            DataRow updateVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            if (txtVacancyStatus.Text == "filled")
            {
                MessageBox.Show("The vacancy is already filled","Error");
            }
            else
            {
                updateVacancyRow["Status"] = "filled";//change the row
                currencyManager.EndCurrentEdit();
                DM.UpdateVacancy();
                MessageBox.Show("Vacancy marked as filled","Success");
            }
        }
    }
}

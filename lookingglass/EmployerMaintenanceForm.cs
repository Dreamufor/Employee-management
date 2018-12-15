using System;
using System.Data;
using System.Windows.Forms;

namespace LookingGlass
{
    public partial class EmployerMaintenanceForm : Form
    {
        //Add references to the DataModule and MainForm objects,add reference for a currencyManager
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public EmployerMaintenanceForm(DataModule dm, MainForm mnu)
        {
            //Add reference for a currencyManager and change the constructor to accept the DataModule and Mainform Reference
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddEmployer.Left = 200;
            pnlAddEmployer.Top = 40;
            pnlUpdateEmployer.Left = 200;
            pnlUpdateEmployer.Top = 40;
        }
        public void BindControls()
        {
            //Binding data of each component;
            lstEmployers.DataSource = DM.dsLookingGlass;
            lstEmployers.DisplayMember = "Employer.EmployerName"; 
            lstEmployers.ValueMember = "Employer.EmployerName";
            txtEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerID");
            txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Street Address");
            txtSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.PhoneNumber");
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            //display panel and make some components enabled
            lstEmployers.Visible = false;
            btnEmPrevious.Enabled = false;
            btnEmNext.Enabled = false;
            btnUpdateEmployer.Enabled = false;
            btnEmReturn.Enabled = false;
            btnDeleteEmployer.Enabled = false;
            pnlAddEmployer.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {   
            //Back to main form,and enable the previous display
            pnlAddEmployer.Hide();
            lstEmployers.Enabled = true;
            lstEmployers.Visible = true;
            lblEmployerID.Enabled = true;
            lblEmployerID.Visible = true;
            btnEmPrevious.Enabled = true;
            btnEmNext.Enabled = true;
            btnUpdateEmployer.Enabled = true;
            btnEmReturn.Enabled = true;
            btnDeleteEmployer.Enabled = true;

        }

        private void btnSaveEmployer_Click(object sender, EventArgs e)
        {
            //Create a new row that variables will be added into
            DataRow newEmployerRow = DM.dtEmployer.NewRow();
            if ((txtAddEmployerName.Text == "") || (txtAddEmployerPN.Text == "") || (txtAddEmployerSuburb.Text == "") || (txtAddEmployerSA.Text == ""))
            {
                MessageBox.Show("You must type a value for each of the text fields", "Error");
                return;
            }
            else
            {   
                //Update rows
                newEmployerRow["EmployerName"] = txtAddEmployerName.Text;
                newEmployerRow["Street Address"] = txtAddEmployerSA.Text;
                newEmployerRow["Suburb"] = txtAddEmployerSuburb.Text;
                newEmployerRow["PhoneNumber"] = txtAddEmployerPN.Text;

                DM.dtEmployer.Rows.Add(newEmployerRow);
                MessageBox.Show("Employer added successfully", "Success");
                //Update tables
                DM.UpdateEmployer();
            }
            return;    
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            DataRow deleteEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
            DataRow[] drVacancy = deleteEmployerRow.GetChildRows(DM.dtEmployer.ChildRelations["EMPLOYER_VACANCY"]);//Find the related position
            if (drVacancy.Length == 0)//Compare if exist or not
            {
                if (MessageBox.Show("Are you sure you want to delete this employer record?","Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteEmployerRow.Delete();
                    DM.UpdateEmployer();//update table after delete row
                    MessageBox.Show("Employer deleted successfully");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete employers who have no vacancies", "Error");
            }
            return;
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //Back to main employer form
            pnlAddEmployer.Hide();
            pnlUpdateEmployer.Hide();
            lstEmployers.Enabled = true;
            lstEmployers.Visible = true;
            lblEmployerID.Enabled = true;
            btnEmPrevious.Enabled = true;
            btnEmNext.Enabled = true;
            btnUpdateEmployer.Enabled = true;
            btnAddEmployer.Enabled = true;
            btnEmReturn.Enabled = true;
            btnDeleteEmployer.Enabled = true;
        }

        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            //display update panel
            lstEmployers.Visible = false;
            lstEmployers.Enabled = false;
            lstEmployers.SelectedItem = false;
            btnEmPrevious.Enabled = false;
            btnEmNext.Enabled = false;
            btnAddEmployer.Enabled = false;
            btnEmReturn.Enabled = false;
            btnDeleteEmployer.Enabled = false;
            pnlUpdateEmployer.Show();
            lblUpdateEmployerID.Visible = true;
            txtUpdateEmployerID.Enabled = false;
            txtUpdateEmployerID.Visible = true;
            txtUpdateEmployerID.Text = txtEmployerID.Text;
            txtUpdateEmployerName.Text = txtEmployerName.Text;
            txtUpdateEmployerSA.Text = txtStreetAddress.Text;
            txtUpdateEmployerSuburb.Text = txtSuburb.Text;
            txtUpdateEmployerPN.Text = txtPhoneNumber.Text;


        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];

            if (txtUpdateEmployerName.Text == "")
            {
                MessageBox.Show("You must type in a employer name", "Error");
                return;
            }
            else
            {
                //update rows
                updateEmployerRow["EmployerName"] = txtUpdateEmployerName.Text;
                updateEmployerRow["Street Address"] = txtUpdateEmployerSA.Text;
                updateEmployerRow["Suburb"] = txtUpdateEmployerSuburb.Text;
                updateEmployerRow["PhoneNumber"] = txtUpdateEmployerPN.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateEmployer();
                MessageBox.Show("Employer updated successfully", "Success");
            }
            return; 
        }

        private void txtUpdateEmployerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNext(object sender, EventArgs e)
        {
         if (currencyManager.Position >= 0)
            {
                ++currencyManager.Position;
            }
        }
    }
}

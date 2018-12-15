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
    public partial class CandidateMaintenanceForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public CandidateMaintenanceForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            pnlAddCandidate.Left = 210;
            pnlAddCandidate.Top = 25;
            pnlUpdateCandidate.Left = 210;
            pnlUpdateCandidate.Top = 25;
        }
        public void BindControls()
        {
            lstCandidates.DataSource = DM.dsLookingGlass;
            lstCandidates.DisplayMember = "Candidate.LastName";
            lstCandidates.ValueMember = "Candidate.LastName";
            txtCandidateID.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.CandidateID");
            txtCandidateLastName.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.LastName");
            txtCandidateFirstName.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.FirstName");
            txtCandidateStreetAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.StreetAddress");
            txtCandidateSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.Suburb");
            txtCandidatePhoneNumber.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.PhoneNumber");
            txtCandidateID.Enabled = false;
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "CANDIDATE"];
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void CandidateMaintenanceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCandidatePrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        private void btnCandidateNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        private void btnCandidateReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAddCandidate.Hide();
            lstCandidates.Enabled = true;
            lstCandidates.Visible = true;
            btnCandidatePrevious.Enabled = true;
            btnCandidateNext.Enabled = true;
            btnUpdateCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
            btnCandidateReturn.Enabled = true;
            btnAddCandidate.Enabled = true;

        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            lstCandidates.Visible = false;
            btnCandidatePrevious.Enabled = false;
            btnCandidateNext.Enabled = false;
            btnUpdateCandidate.Enabled = false;
            btnDeleteCandidate.Enabled = false;
            btnCandidateReturn.Enabled = false;
            pnlAddCandidate.Show();
        }

        private void btnSaveCandidate_Click(object sender, EventArgs e)
        {
            //Create a new row that variables will be added into
            DataRow newCandidateRow = DM.dtCandidate.NewRow();
            if((txtAddCandidateLN.Text == "") || (txtAddCandidateFN.Text == "") || (txtAddCandidateSA.Text == "") || (txtAddCandidateSuburb.Text == "") || (txtAddCandidatePN.Text == ""))
            {
                MessageBox.Show("You must type a value for each of the text fields", "Error");
                return;
            }
            else
            {
                newCandidateRow["LastName"] = txtAddCandidateLN.Text;
                newCandidateRow["FirstName"] = txtAddCandidateFN.Text;
                newCandidateRow["StreetAddress"] = txtAddCandidateSA.Text;
                newCandidateRow["Suburb"] = txtAddCandidateSuburb.Text;
                newCandidateRow["PhoneNumber"] = txtAddCandidatePN.Text;
                DM.dtCandidate.Rows.Add(newCandidateRow);
                MessageBox.Show("Candidate added successfully", "Success");
                DM.UpdateCandidate();
            }
            return;
        }

        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            lstCandidates.Visible = false;
            btnCandidatePrevious.Enabled = false;
            btnCandidateNext.Enabled = false;
            btnAddCandidate.Enabled = false;
            btnDeleteCandidate.Enabled = false;
            btnCandidateReturn.Enabled = false;
            txtUpdateCandidateID.Text = txtCandidateID.Text;
            txtUpdateCandidateLN.Text = txtCandidateLastName.Text;
            txtUpdateCandidateFN.Text = txtCandidateFirstName.Text;
            txtUpdateCandidateSA.Text = txtCandidateStreetAddress.Text;
            txtUpdateCandidateSuburb.Text = txtCandidateSuburb.Text;
            txtUpdateCandidatePN.Text = txtCandidatePhoneNumber.Text;
            pnlUpdateCandidate.Show();

        }

        private void btnUpdateCdCancel_Click(object sender, EventArgs e)
        {
            pnlUpdateCandidate.Hide();
            lstCandidates.Enabled = true;
            lstCandidates.Visible = true;
            btnCandidatePrevious.Enabled = true;
            btnCandidateNext.Enabled = true;
            btnUpdateCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
            btnCandidateReturn.Enabled = true;
            btnAddCandidate.Enabled = true;
        }

        private void btnUpdateCdSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];

            if ((txtUpdateCandidateLN.Text == " ") || (txtUpdateCandidateFN.Text == " ") || (txtUpdateCandidateSA.Text == " ")
                 || (txtUpdateCandidateSuburb.Text == " ") || (txtUpdateCandidatePN.Text == " "))
            {
                MessageBox.Show("You must type in a value for each of the text fields", "Error");
                return;
            }
            else
            {
                updateCandidateRow["LastName"] = txtUpdateCandidateLN.Text;
                updateCandidateRow["FirstName"] = txtUpdateCandidateFN.Text;
                updateCandidateRow["StreetAddress"] = txtUpdateCandidateSA.Text;
                updateCandidateRow["Suburb"] = txtUpdateCandidateSuburb.Text;                                       
                updateCandidateRow["PhoneNumber"] = txtUpdateCandidatePN.Text;
                currencyManager.EndCurrentEdit();
                DM.UpdateCandidate();
                MessageBox.Show("Candidate updated successfully", "Success");
            }  
                return;
        }

        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            CurrencyManager cmCandidateSkill;
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "CandidateSkill"];
            int aCandidateID = Convert.ToInt32(txtCandidateID.Text);
            cmCandidateSkill.Position = DM.candidateSkillView.Find(aCandidateID);
            DataRow[] CandidateSkillRow = DM.dtCandidateSkill.Select("CandidateID = " + aCandidateID);

            DataRow deleteCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];
            DataRow[] ApplicationRow = deleteCandidateRow.GetChildRows(DM.dtCandidate.ChildRelations["Candidate_Application"]);

            if (ApplicationRow.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this candidate record?", "Warning",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {   
                    foreach (DataRow dcr in CandidateSkillRow)//use loop to delete multiple row
                    {
                        dcr.Delete();
                    }
                    deleteCandidateRow.Delete();
                    //Update two table.
                    DM.UpdateCandidateSkill();
                    DM.UpdateCandidate();
                    MessageBox.Show("Candidate deleted successfully","Success");
                    MessageBox.Show("Candidate Skills deleted successfully","Success");
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("You may only delete candidates who have no applications", "Error");
            }
            return; 
        }
    }
}

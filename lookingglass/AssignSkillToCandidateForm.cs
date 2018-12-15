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
    public partial class AssignSkillToCandidateForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmCandidateSkill;
        private CurrencyManager cmSkill;
        private CurrencyManager cmCCS;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public AssignSkillToCandidateForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmCandidate = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Candidate"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "CandidateSkill"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Skill"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmCCS = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Candidate.Candidate_CandidateSkill"];
            BindControls();
        }

        public void BindControls()
        {
            //Binding data to datagridview
            dgvCandidate.DataSource = DM.dsLookingGlass;
            dgvCandidate.DataMember = "Candidate";

            dgvCandidateSkill.DataSource = DM.dsLookingGlass;
            dgvCandidateSkill.DataMember = "Candidate.Candidate_CandidateSkill";

            dgvCSkill.DataSource = DM.dsLookingGlass;
            dgvCSkill.DataMember = "Skill";
        }

        private void btnASTVReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAssignSkillC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYearsC.Text == "")//if user didn't type in any number,return
                {
                    MessageBox.Show("You must type a valid number", "Error");
                }
                else if (DM.dtSkill.Rows[cmSkill.Position]["SkillID"] != DM.dtCandidateSkill.Rows[cmCandidateSkill.Position]["SkillID"])
                {
                    DataRow newCandidateSkill = DM.dtCandidateSkill.NewRow();
                    newCandidateSkill["CandidateID"] = dgvCandidate["CandidateID", cmCandidate.Position].Value;
                    newCandidateSkill["Years"] = Convert.ToInt32(this.txtYearsC.Text);
                    newCandidateSkill["SkillID"] = dgvCSkill["SkillID", cmSkill.Position].Value;

                    DM.dsLookingGlass.Tables["CandidateSkill"].Rows.Add(newCandidateSkill);
                    DM.UpdateCandidateSkill();
                    MessageBox.Show("Skill assigned successfully", "Success");
                }
            }
            catch
            {
                MessageBox.Show("This skill has already been assigned to this candidate");
            }
        }

        private void btnRemoveSkillC_Click(object sender, EventArgs e)
        {
            string CandidateID = DM.dtCandidate.Rows[cmCandidate.Position]["CandidateID"].ToString();
            string SkillID = dgvCandidateSkill.Rows[cmCCS.Position].Cells[1].Value.ToString();//Locate the skill in the table;


            int row = 0;
            for (int i = 0; i < DM.dtCandidateSkill.Rows.Count; i++)
            {
                string cID = DM.dtCandidateSkill.Rows[i]["CandidateID"].ToString();
                string sID = DM.dtCandidateSkill.Rows[i]["SkillID"].ToString();

                if ((CandidateID == cID) && (SkillID == sID))
                {
                    row = i;
                }
            }
            if (MessageBox.Show("Are you sure you want to remove this candidate skill record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRow dr = DM.dsLookingGlass.Tables["CandidateSkill"].Rows[row];
                dr.Delete();
                DM.UpdateCandidateSkill();
                MessageBox.Show("Skill removed successfully", "Success");
            }
            else
            {
                return;
            }
        }
    }
}

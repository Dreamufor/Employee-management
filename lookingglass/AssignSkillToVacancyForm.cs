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
    public partial class AssignSkillToVacancyForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmSkill;
        private CurrencyManager cmVVS;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        public AssignSkillToVacancyForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Vacancy"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VacancySkill"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Skill"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmVVS = (CurrencyManager)this.BindingContext[DM.dsLookingGlass,"Vacancy.Vacancy_VacancySkill"];
            BindControls();
        }

        public void BindControls()
        {
            dgvVacancy.DataSource = DM.dsLookingGlass;
            dgvVacancy.DataMember = "Vacancy";

            dgvVancancySkill.DataSource = DM.dsLookingGlass;
            dgvVancancySkill.DataMember = "Vacancy.Vacancy_VacancySkill";

            dgvSkill.DataSource = DM.dsLookingGlass;
            dgvSkill.DataMember = "Skill";
        }

        private void btnASTVReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYears.Text == "")
                {
                    MessageBox.Show("You must type a valid number", "Error");
                }
                else if (DM.dtSkill.Rows[cmSkill.Position]["SkillID"] != DM.dtVacancySkill.Rows[cmVacancySkill.Position]["SkillID"])
                {
                    DataRow newVacancySkill = DM.dtVacancySkill.NewRow();
                    newVacancySkill["VacancyID"] = dgvVacancy["VacancyID", cmVacancy.Position].Value;
                    newVacancySkill["Years"] = Convert.ToInt32(this.txtYears.Text);
                    newVacancySkill["SkillID"] = dgvSkill["SkillID", cmSkill.Position].Value;

                    DM.dsLookingGlass.Tables["VacancySkill"].Rows.Add(newVacancySkill);
                    DM.UpdateVacancySkill();
                    MessageBox.Show("Skill assigned successfully", "Success");
                }
            }
            catch
            {
                MessageBox.Show("This skill has already been assigned to this vacancy");
            }
           
       }

        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {   

            string VacancyID = DM.dtVacancy.Rows[cmVacancy.Position]["VacancyID"].ToString();
            string SkillID = dgvVancancySkill.Rows[cmVVS.Position].Cells[1].Value.ToString();


            int row = 0;
            for (int i = 0;i < DM.dtVacancySkill.Rows.Count; i++)
            {
                string vID = DM.dtVacancySkill.Rows[i]["VacancyID"].ToString();
                string sID = DM.dtVacancySkill.Rows[i]["SkillID"].ToString();

                if((VacancyID == vID) && (SkillID == sID))
                {
                    row = i;
                }
            }
            if (MessageBox.Show("Are you sure you want to remove this vacancy skill record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                DataRow dr = DM.dsLookingGlass.Tables["VacancySkill"].Rows[row];
                dr.Delete();
                DM.UpdateVacancySkill();
                MessageBox.Show("Skill removed successfully", "Success");
            }
            else
            {
                return;
            }
        }
    }
}

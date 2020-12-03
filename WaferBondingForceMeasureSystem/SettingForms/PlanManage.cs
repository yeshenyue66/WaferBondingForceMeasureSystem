using System;
using System.Collections.Generic;
using System.Windows.Forms;

using WaferBondingForceMeasureSystem.Util.String;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.PlanConmmon;
using WaferBondingForceMeasureSystem.Models.Plan;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class PlanManage : Form
    {
        delegate string PlanDescription(string planModel);
        PlanAppend planAppend = null;
        public delegate void MyDelegate(object sender, EventArgs e);
        public event MyDelegate MyEvent;
        public PlanManage()
        {
            InitializeComponent();

            planAppend = new PlanAppend();
            planAppend.MyEvent += new PlanAppend.MyDelegate(PlanManage_Load);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PlanDescription planDescription = new PlanDescription(WBFMSystem.GetPlanModel);
            planDescription(this.TextBoxPlanDescription.Text);
            MyEvent?.Invoke(sender, e);
            this.Close();
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<PlanModel> planModels;
        private void PlanManage_Load(object sender, EventArgs e)
        {
            this.ComBoxPlan.Items.Clear();
            planModels = new PlanBLL().ReadPlanData(new PlanBLL().PlanAddress());
            foreach (PlanModel planModel in planModels)
            {
                this.ComBoxPlan.Items.Add(planModel.Name);
            }
        }

        private void PanelMenuAdd_Click(object sender, EventArgs e)
        {
            planAppend.ShowDialog();
        }

        private void ComBoxPlan_TextChanged(object sender, EventArgs e)
        {
            foreach (PlanModel planModel in planModels)
            {
                if(this.ComBoxPlan.Text == planModel.Name)
                {
                    this.CheckBoxSite1.Checked = planModel.IsSetSite1;
                    this.CheckBoxSite2.Checked = planModel.IsSetSite2;
                    this.CheckBoxSite3.Checked = planModel.IsSetSite3;
                    this.CheckBoxSite4.Checked = planModel.IsSetSite4;
                    this.CheckBoxSite5.Checked = planModel.IsSetSite5;
                    this.CheckBoxSite6.Checked = planModel.IsSetSite6;
                    this.CheckBoxSite7.Checked = planModel.IsSetSite7;

                    this.TextBoxPlanDescription.Text = Str.RemoveFineMark(planModel.Description);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new PlanAppend().ShowDialog();
        }
    }
}

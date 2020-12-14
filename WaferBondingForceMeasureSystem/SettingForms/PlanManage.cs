using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.PlanConmmon;
using WaferBondingForceMeasureSystem.ApplicationModule.EventHandler;
using WaferBondingForceMeasureSystem.Models.Plan;
using WaferBondingForceMeasureSystem.Util.String;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class PlanManage : Form
    {
        static PlanManage planManage;
        private PlanManage()
        {
            InitializeComponent();
            UIBLL.CustomizeMove<Panel, Label>(this.PanelTopic, this.LabelTopic, this);
        }

        public static PlanManage Singleton()
        {
            if(planManage == null)
            {
                planManage = new PlanManage();
            }
            return planManage;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            PlanEventHandler planEventHandler = new PlanEventHandler();
            planEventHandler.PlanConfirm += WBFMSystem.Singleton().LabelPlan_Add;
            planEventHandler.PlanShow(this.TextBoxPlanDescription.Text);

            this.Close();
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        List<PlanModel> planModels;

        public void ReadPlan(object sender,PlanEventHandler.PlanConfirmEventArgs e)
        {
            this.ComBoxPlan.Items.Clear();
            planModels = new PlanBLL().ReadPlanData(new PlanBLL().PlanAddress());
            foreach (PlanModel planModel in planModels)
            {
                this.ComBoxPlan.Items.Add(planModel.Name);
            }
        }
        
        private void PlanManage_Load(object sender, EventArgs e)
        {
            this.ComBoxPlan.Items.Clear();
            planModels = new PlanBLL().ReadPlanData(new PlanBLL().PlanAddress());
            foreach (PlanModel planModel in planModels)
            {
                this.ComBoxPlan.Items.Add(planModel.Name);
            }
        }

        private void ComBoxPlan_TextChanged(object sender, EventArgs e)
        {
            foreach (PlanModel planModel in planModels)
            {
                if (this.ComBoxPlan.Text == planModel.Name)
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

        private void PanelMenuAdd_Click(object sender, EventArgs e)
        {
            new PlanAppend().ShowDialog();
        }

        private void LabelAdd_Click(object sender, EventArgs e)
        {
            new PlanAppend().ShowDialog();
        }

        private void PicBoxAdd_Click(object sender, EventArgs e)
        {
            new PlanAppend().ShowDialog();
        }

        private void LabelRevise_Click(object sender, EventArgs e)
        {
            string planName = this.ComBoxPlan.Text;
            PlanAppend planAppend = new PlanAppend();
            planAppend.PlanName = planName;
            planAppend.ShowDialog();
        }

        private void PicBoxRevise_Click(object sender, EventArgs e)
        {
            string planName = this.ComBoxPlan.Text;
            PlanAppend planAppend = new PlanAppend();
            planAppend.PlanName = planName;
            planAppend.ShowDialog();
        }

        private void PanelMenuRevise_Click(object sender, EventArgs e)
        {
            string planName = this.ComBoxPlan.Text;
            PlanAppend planAppend = new PlanAppend();
            planAppend.PlanName = planName;
            planAppend.ShowDialog();
        }

        private void LabelDelete_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            sb.Append(new PlanBLL().PlanAddress());
            new PlanBLL().DeletePlanData(sb.ToString(), this.ComBoxPlan.Text);
            this.ComBoxPlan.Items.Clear();
            planModels = new PlanBLL().ReadPlanData(new PlanBLL().PlanAddress());
            foreach (PlanModel planModel in planModels)
            {
                this.ComBoxPlan.Items.Add(planModel.Name);
            }
            this.ComBoxPlan.Text = "default";
            this.TextBoxPlanDescription.Text = string.Empty;
            this.CheckBoxSite1.Checked = false;
            this.CheckBoxSite2.Checked = false;
            this.CheckBoxSite3.Checked = false;
            this.CheckBoxSite4.Checked = false;
            this.CheckBoxSite5.Checked = false;
            this.CheckBoxSite6.Checked = false;
            this.CheckBoxSite7.Checked = false;
            //foreach(CheckBox checkBox in this.Controls)
            //{
            //    checkBox.Checked = false;
            //}
        }

        private void PlanManage_Activated(object sender, EventArgs e)
        {
            ComBoxPlan_TextChanged(sender, e);
        }
    }
}

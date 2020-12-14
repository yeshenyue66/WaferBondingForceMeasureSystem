using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.PlanConmmon;
using WaferBondingForceMeasureSystem.ApplicationModule.EventHandler;
using WaferBondingForceMeasureSystem.Models.Plan;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class PlanAppend : Form
    {
        private string planName;

        public string PlanName { get => planName; set => planName = value; }
        List<PlanModel> planModels;

        public PlanAppend()
        {
            InitializeComponent();
            UIBLL.CustomizeMove<Panel, Label>(this.PanelTopic, this.LabelTopic, this);
        }

        private void PlanAppend_Load(object sender, EventArgs e)
        {
            if(planName != string.Empty)
            {
                this.TextBoxPlanName.Text = PlanName;
                planModels = new PlanBLL().ReadPlanData(new PlanBLL().PlanAddress());
                foreach (PlanModel planModel in planModels)
                {
                    if(planModel.Name == this.TextBoxPlanName.Text)
                    {
                        this.CheckBoxSite1.Checked = planModel.IsSetSite1;
                        this.CheckBoxSite2.Checked = planModel.IsSetSite2;
                        this.CheckBoxSite3.Checked = planModel.IsSetSite3;
                        this.CheckBoxSite4.Checked = planModel.IsSetSite4;
                        this.CheckBoxSite5.Checked = planModel.IsSetSite5;
                        this.CheckBoxSite6.Checked = planModel.IsSetSite6;
                        this.CheckBoxSite7.Checked = planModel.IsSetSite7;
                    }
                }
            }
        }

        private void BtnAppend_Click(object sender, EventArgs e)
        {
            PlanModel planModel = new PlanModel
            {
                Name = this.TextBoxPlanName.Text,
                IsSetSite1 = this.CheckBoxSite1.Checked,
                IsSetSite2 = this.CheckBoxSite2.Checked,
                IsSetSite3 = this.CheckBoxSite3.Checked,
                IsSetSite4 = this.CheckBoxSite4.Checked,
                IsSetSite5 = this.CheckBoxSite5.Checked,
                IsSetSite6 = this.CheckBoxSite6.Checked,
                IsSetSite7 = this.CheckBoxSite7.Checked
            };

            StringBuilder info_delete = new StringBuilder();
            info_delete.Append(AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            info_delete.Append(new PlanBLL().PlanAddress());
            StringBuilder sb = new StringBuilder();
            sb.Append(new PlanBLL().PlanAddress());
            sb.Append(this.TextBoxPlanName.Text.ToString());
            sb.Append(".txt");
            if (Array.IndexOf(new PlanBLL().ReadPlanName(), sb) == -1)
            {
                new PlanBLL().DeletePlanData(info_delete.ToString(), this.TextBoxPlanName.Text);
            }
            new PlanBLL().SavePlanData(sb.ToString(), planModel);

            PlanEventHandler planHandle = new PlanEventHandler();
            planHandle.PlanConfirm += PlanManage.Singleton().ReadPlan;
            planHandle.PlanShow(string.Empty);
            this.Close();
        }

        public static PlanModel model;
        public PlanModel GetSites(bool site1, bool site2, bool site3, bool site4, bool site5, bool site6, bool site7)
        {
            model.IsSetSite1 = site1;
            model.IsSetSite2 = site2;
            model.IsSetSite3 = site3;
            model.IsSetSite4 = site4;
            model.IsSetSite5 = site5;
            model.IsSetSite6 = site6;
            model.IsSetSite7 = site7;

            return model;
        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

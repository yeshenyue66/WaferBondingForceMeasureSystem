using System;
using System.Windows.Forms;

using WaferBondingForceMeasureSystem.Extensions.Models;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.PlanConmmon;
using WaferBondingForceMeasureSystem.Models.Plan;
using System.Text;
using System.Collections.Generic;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class PlanAppend : Form
    {
        public string planName = string.Empty;
        List<PlanModel> planModels;
        public PlanAppend()
        {
            InitializeComponent();

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanAppend_Load(object sender, EventArgs e)
        {
            if(planName != string.Empty)
            {
                this.TextBoxPlanName.Text = planName;
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

        public delegate void MyDelegate(object sender, EventArgs e);
        public event MyDelegate MyEvent;

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

            StringBuilder sb = new StringBuilder();
            sb.Append(new PlanBLL().PlanAddress());
            sb.Append(this.TextBoxPlanName.Text.ToString());
            sb.Append(".txt");
            new PlanBLL().SavePlanData(sb.ToString(), planModel);

            MyEvent?.Invoke(sender, e);
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
    }
}

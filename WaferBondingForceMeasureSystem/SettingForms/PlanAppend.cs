using System;
using System.Windows.Forms;

using WaferBondingForceMeasureSystem.Extensions.Models;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.PlanConmmon;
using WaferBondingForceMeasureSystem.Models.Plan;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class PlanAppend : Form
    {
        
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

            new PlanBLL().SavePlanData(new PlanBLL().PlanAddress() + this.TextBoxPlanName.Text.ToString() + ".txt", planModel);

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
    }
}

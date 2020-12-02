using System;
using System.Windows.Forms;

using WaferBondingForceMeasureSystem.Models.Plan;
using WaferBondingForceMeasureSystem.SettingForms;

namespace WaferBondingForceMeasureSystem.UserControls
{
    public partial class PlanSite : UserControl
    {
        //PlanAppend planAppend = null;
        public PlanSite()
        {
            InitializeComponent();

        }
        public PlanSite(bool Checked)
        {
            InitializeComponent();

        }

        delegate PlanModel SiteData(bool site1, bool site2, bool site3, bool site4, bool site5, bool site6, bool site7);

        /// <summary>
        /// 传递sites值
        /// </summary>
        void SendSites()
        {

            //PlanModel planModel = new PlanModel
            //{
            //    IsSetSite1 = this.CheckBoxSite1.Checked,
            //    IsSetSite2 = this.CheckBoxSite2.Checked,
            //    IsSetSite3 = this.CheckBoxSite3.Checked,
            //    IsSetSite4 = this.CheckBoxSite4.Checked,
            //    IsSetSite5 = this.CheckBoxSite5.Checked,
            //    IsSetSite6 = this.CheckBoxSite6.Checked,
            //    IsSetSite7 = this.CheckBoxSite7.Checked,
            //};
            SiteData siteData = new SiteData(new PlanAppend().GetSites);
            siteData(this.CheckBoxSite1.Checked,
                this.CheckBoxSite2.Checked,
                this.CheckBoxSite3.Checked,
                this.CheckBoxSite4.Checked,
                this.CheckBoxSite5.Checked,
                this.CheckBoxSite6.Checked,
                this.CheckBoxSite7.Checked);
        }

        static PlanModel planModel1;
        public PlanModel Receive(bool site1, bool site2, bool site3, bool site4, bool site5, bool site6, bool site7)
        {
            planModel1 = new PlanModel();
            planModel1.IsSetSite1 = site1;
            planModel1.IsSetSite2 = site2;
            planModel1.IsSetSite3 = site3;
            planModel1.IsSetSite4 = site4;
            planModel1.IsSetSite5 = site5;
            planModel1.IsSetSite6 = site6;
            planModel1.IsSetSite7 = site7;

            return planModel1;
        }

        private void PlanSite_Load(object sender, EventArgs e)
        {
            try
            {
                if (planModel1 != null)
                {
                    this.CheckBoxSite1.Checked = planModel1.IsSetSite1;
                    this.CheckBoxSite2.Checked = planModel1.IsSetSite2;
                    this.CheckBoxSite3.Checked = planModel1.IsSetSite3;
                    this.CheckBoxSite4.Checked = planModel1.IsSetSite4;
                    this.CheckBoxSite5.Checked = planModel1.IsSetSite5;
                    this.CheckBoxSite6.Checked = planModel1.IsSetSite6;
                    this.CheckBoxSite7.Checked = planModel1.IsSetSite7;
                }
                else
                {
                    this.CheckBoxSite1.Checked = false;
                    this.CheckBoxSite2.Checked = false;
                    this.CheckBoxSite3.Checked = false;
                    this.CheckBoxSite4.Checked = false;
                    this.CheckBoxSite5.Checked = false;
                    this.CheckBoxSite6.Checked = false;
                    this.CheckBoxSite7.Checked = false;
                }
            }
            catch
            {

            }
        }
    }
}

using System;
using System.Text;

namespace WaferBondingForceMeasureSystem.Models.Plan
{
    /// <summary>
    /// 功能描述    ：PlanModel  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    [Serializable]
    public class PlanModel
    {

        #region 属性字段
        /// <summary>
        /// 方案名称
        /// </summary>
        private string planName;
        /// <summary>
        /// 模量Site1
        /// </summary>
        private bool isSetSite1;
        /// <summary>
        /// 模量Site2
        /// </summary>
        private bool isSetSite2;
        /// <summary>
        /// 模量Site3
        /// </summary>
        private bool isSetSite3;
        /// <summary>
        /// 模量Site4
        /// </summary>
        private bool isSetSite4;
        /// <summary>
        /// 模量Site5
        /// </summary>
        private bool isSetSite5;
        /// <summary>
        /// 模量Site6
        /// </summary>
        private bool isSetSite6;
        /// <summary>
        /// 模量Site7
        /// </summary>
        private bool isSetSite7;

        /// <summary>
        /// 方案名称
        /// </summary>
        public string Name { get => planName; set => planName = value; }
        /// <summary>
        /// 方案描述
        /// </summary>
        public string Description { get => PlanDescription(); }
        /// <summary>
        /// 模量Site1
        /// </summary>
        public bool IsSetSite1 { get => isSetSite1; set => isSetSite1 = value; }
        /// <summary>
        /// 模量Site2
        /// </summary>
        public bool IsSetSite2 { get => isSetSite2; set => isSetSite2 = value; }
        /// <summary>
        /// 模量Site3
        /// </summary>
        public bool IsSetSite3 { get => isSetSite3; set => isSetSite3 = value; }
        /// <summary>
        /// 模量Site4
        /// </summary>
        public bool IsSetSite4 { get => isSetSite4; set => isSetSite4 = value; }
        /// <summary>
        /// 模量Site5
        /// </summary>
        public bool IsSetSite5 { get => isSetSite5; set => isSetSite5 = value; }
        /// <summary>
        /// 模量Site6
        /// </summary>
        public bool IsSetSite6 { get => isSetSite6; set => isSetSite6 = value; }
        /// <summary>
        /// 模量Site7
        /// </summary>
        public bool IsSetSite7 { get => isSetSite7; set => isSetSite7 = value; }

        #endregion

        #region 构造方法
        public PlanModel()
        {

        }
        public PlanModel(bool isSetSite1, bool isSetSite2, bool isSetSite3, bool isSetSite4, bool isSetSite5, bool isSetSite6, bool isSetSite7)
        {
            this.isSetSite1 = isSetSite1;
            this.isSetSite2 = isSetSite2;
            this.isSetSite3 = isSetSite3;
            this.isSetSite4 = isSetSite4;
            this.isSetSite5 = isSetSite5;
            this.isSetSite6 = isSetSite6;
            this.isSetSite7 = isSetSite7;
        }
        #endregion

        #region 扩展方法
        private string PlanDescription()
        {
            StringBuilder description = new StringBuilder();
            description.Append("Site[");
            if (IsSetSite1)
            {
                description.Append("1,");
            }
            if (IsSetSite2)
            {
                description.Append("2,");
            }
            if (IsSetSite3)
            {
                description.Append("3,");
            }
            if (IsSetSite4)
            {
                description.Append("4,");
            }
            if (IsSetSite5)
            {
                description.Append("5,");
            }
            if (IsSetSite6)
            {
                description.Append("6,");
            }
            if (IsSetSite7)
            {
                description.Append("7");
            }
            description.Append("]");

            return description.ToString();
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferBondingForceMeasureSystem.Models.Algorithms
{
    /// <summary>
    /// 功能描述    ：Class1  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    class BondingForceModel
    {

        #region 字段属性
        /// <summary>
        /// 插刀厚度
        /// </summary>
        private int slottingKnifeDepth;
        /// <summary>
        /// 晶圆上半部分厚度
        /// </summary>
        private int waferUpperDepth;
        /// <summary>
        /// 晶圆下半部分厚度
        /// </summary>
        private int waferLatterDepth;
        /// <summary>
        /// 杨氏模量(Site1)
        /// </summary>
        private int youngModulusSite1;
        /// <summary>
        /// 杨氏模量(Site2)
        /// </summary>
        private int youngModulusSite2;
        /// <summary>
        /// 杨氏模量(Site3)
        /// </summary>
        private int youngModulusSite3;
        /// <summary>
        /// 杨氏模量(Site4)
        /// </summary>
        private int youngModulusSite4;
        /// <summary>
        /// 杨氏模量(Site5)
        /// </summary>
        private int youngModulusSite5;
        /// <summary>
        /// 杨氏模量(Site6)
        /// </summary>
        private int youngModulusSite6;
        /// <summary>
        /// 杨氏模量(Site7)
        /// </summary>
        private int youngModulusSite7;

        /// <summary>
        /// 插刀厚度
        /// </summary>
        public int SlottingKnifeDepth { get => slottingKnifeDepth; set => slottingKnifeDepth = value; }
        /// <summary>
        /// 晶圆上半部分厚度
        /// </summary>
        public int WaferUpperDepth { get => waferUpperDepth; set => waferUpperDepth = value; }
        /// <summary>
        /// 晶圆下半部分厚度
        /// </summary>
        public int WaferLatterDepth { get => waferLatterDepth; set => waferLatterDepth = value; }
        /// <summary>
        /// 杨氏模量(Site1)
        /// </summary>
        public int YoungModulusSite1 { get => youngModulusSite1; set => youngModulusSite1 = value; }
        /// <summary>
        /// 杨氏模量(Site2)
        /// </summary>
        public int YoungModulusSite2 { get => youngModulusSite2; set => youngModulusSite2 = value; }
        /// <summary>
        /// 杨氏模量(Site3)
        /// </summary>
        public int YoungModulusSite3 { get => youngModulusSite3; set => youngModulusSite3 = value; }
        /// <summary>
        /// 杨氏模量(Site4)
        /// </summary>
        public int YoungModulusSite4 { get => youngModulusSite4; set => youngModulusSite4 = value; }
        /// <summary>
        /// 杨氏模量(Site5)
        /// </summary>
        public int YoungModulusSite5 { get => youngModulusSite5; set => youngModulusSite5 = value; }
        /// <summary>
        /// 杨氏模量(Site6)
        /// </summary>
        public int YoungModulusSite6 { get => youngModulusSite6; set => youngModulusSite6 = value; }
        /// <summary>
        /// 杨氏模量(Site7)
        /// </summary>
        public int YoungModulusSite7 { get => youngModulusSite7; set => youngModulusSite7 = value; }

        public int WaferBondingForce { get => SlottingKnifeDepth; set => SlottingKnifeDepth = value; }
        #endregion

        #region 构造方法

        #endregion

    }
}

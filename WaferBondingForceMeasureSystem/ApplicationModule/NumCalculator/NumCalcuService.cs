using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WaferBondingForceMeasureSystem.Models.Algorithms;

namespace WaferBondingForceMeasureSystem.ApplicationModule.NumCalculator
{
    /// <summary>
    /// 功能描述    ：NumCalcuService
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/23 15:01:30 
    /// </summary>
    class NumCalcuService
    {
        public double BondStrength(BondingForceModel bondingForceModel)
        {
            double bondStrength = 3 * bondingForceModel.SlottingKnifeDepth;

            return bondStrength;
        }
    }
}

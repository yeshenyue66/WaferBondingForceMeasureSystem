using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WaferBondingForceMeasureSystem.Extensions.Models;
using WaferBondingForceMeasureSystem.Models.Plan;

namespace WaferBondingForceMeasureSystem.ApplicationModule.Common.PlanConmmon
{
    interface IPlanBLL
    {
        /// <summary>
        /// 获取方案地址
        /// </summary>
        /// <returns></returns>
        string PlanAddress();
        /// <summary>
        /// 保存方案
        /// </summary>
        /// <param name="Path">方案路径</param>
        /// <param name="planModel">方案</param>
        void SavePlanData(string Path, PlanModel planModel);
        /// <summary>
        /// 读取方案
        /// </summary>
        /// <param name="Path">方案路径</param>
        /// <returns></returns>
        List<PlanModel> ReadPlanData(string Path);
    }
}

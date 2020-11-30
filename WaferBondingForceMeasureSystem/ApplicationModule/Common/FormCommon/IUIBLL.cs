using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.Models;
using WaferBondingForceMeasureSystem.Models.Control;

namespace WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon
{
    /// <summary>
    /// 功能描述    ：IUIBLL<T>  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    interface IUIBLL<T>
    {
        #region 获取数据

        ControlModel GetSizeData(T _control);
        List<ControlModel> GetSizeList(Control _control);
        ControlModel GetLocationData(T _control);
        List<ControlModel> GetLocationList(Control _control);
        #endregion

        #region 处理数据

        void SetControls(T _control, int _height, int _width);

        #endregion

    }
}

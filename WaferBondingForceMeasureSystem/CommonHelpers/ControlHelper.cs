using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaferBondingForceMeasureSystem.CommonHelpers
{
    /// <summary>
    /// 功能描述    ：ControlHelper
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    class ControlHelper
    {
        public static T ShowControl<T>(T _control,int _height, string _text) where T:Control
        {
            _control.Text = "";
            return default(T);
        }

        [DllImport("user32.dll")]
        public static extern bool MoveWindow();
    }
}

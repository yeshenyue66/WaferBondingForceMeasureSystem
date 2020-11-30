using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaferBondingForceMeasureSystem.CommonHelpers
{
    /// <summary>
    /// 功能描述    ：TextHelper  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    class TextHelper
    {
        /// <summary>
        /// 输入数字（唯一）
        /// </summary>
        /// <typeparam name="T">容器类型</typeparam>
        /// <param name="_inputArea">输入域</param>
        public static void InputNumOnly<T>(T _inputArea) where T : Control
        {
            _inputArea.KeyPress += InputArea_KeyPress;
        }
      
        /// <summary>
        /// 判断输入数字（唯一）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void InputArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Char.IsNumber(e.KeyChar) && (e.KeyChar != (char)13) && (e.KeyChar != (char)8) && (!((((TextBox)sender).Text == "") && (e.KeyChar == (char)45))))
                {
                    e.Handled = true;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

    }
}

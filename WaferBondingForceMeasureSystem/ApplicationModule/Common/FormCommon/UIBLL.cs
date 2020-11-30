using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.Models;
using WaferBondingForceMeasureSystem.Models.Control;

namespace WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon
{
    /// <summary>
    /// 功能描述    ：UIBLL
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    class UIBLL : IUIBLL<Control>
    {

        #region 获取数据
        /// <summary>
        /// 获取控件长宽
        /// </summary>
        /// <param name="_control">控件</param>
        /// <returns></returns>
        public ControlModel GetSizeData(Control _control)
        {
            ControlModel controlModel = new ControlModel(_control.Height, _control.Width);
            return controlModel;
        }

        /// <summary>
        /// 获取控件长宽列表
        /// </summary>
        /// <param name="_control">控件</param>
        /// <returns></returns>
        public List<ControlModel> GetSizeList(Control _control)
        {
            List<ControlModel> ListCons = new List<ControlModel>();
            foreach(Control _childcons in _control.Controls)
            {
                ListCons.Add(new ControlModel(_childcons.Height, _childcons.Width));
            }
            return ListCons;
        }

        public ControlModel GetLocationData(Control _control)
        {
            ControlModel controlModel = new ControlModel(_control.Location.X, _control.Location.Y);
            return controlModel;
        }

        public List<ControlModel> GetLocationList(Control _control)
        {
            List<ControlModel> ListCons = new List<ControlModel>();
            foreach (Control _childcons in _control.Controls)
            {
                ListCons.Add(new ControlModel(_childcons.Location.X, _childcons.Location.Y));
            }
            return ListCons;
        }

        #endregion

        #region 处理数据
        public void SetControls(Control _control, int _height, int _width)
        {
            foreach (Control _childcon in _control.Controls)
            {
                string[] mytag = _childcon.Tag.ToString().Split(new char[] { ':' });
                float a = Convert.ToSingle(mytag[0]) * _height;
                _childcon.Width = (int)a;
                a = Convert.ToSingle(mytag[1]) * _width;
                _childcon.Height = (int)(a);
                a = Convert.ToSingle(mytag[2]) * _height;
                _childcon.Left = (int)(a);
                a = Convert.ToSingle(mytag[3]) * _width;
                _childcon.Top = (int)(a);
                Single currentSize = Convert.ToSingle(mytag[4]) * _width;
                _childcon.Font = new Font(_childcon.Font.Name, currentSize, _childcon.Font.Style, _childcon.Font.Unit);
                if (_childcon.Controls.Count > 0)
                {
                    SetControls(_control, _height, _width);
                }
            }
        }
        #endregion

        static ControlModel controlModel = null;
        static bool IsMove;
        public void CustomizeMove<T>(T obj) where T : Form
        {
            controlModel = new ControlModel((float)obj.Location.X, (float)obj.Location.Y);

            obj.MouseDown += Obj_MouseDown;
            obj.MouseUp += Obj_MouseUp;
            obj.Move += Obj_MouseMove;
        }

        private void Obj_MouseMove(object sender, EventArgs e)
        {
            if(IsMove)
            {
            //    controlModel.Locationx = controlModel.Locationx - e.X;
            //    controlModel.Locationy = controlModel.Locationy - e.Y;
            }
        }

        private void Obj_MouseUp(object sender, MouseEventArgs e)
        {
            IsMove = false;
        }

        public static void Obj_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    controlModel.Locationx = e.X;
                    controlModel.Locationy = e.Y;
                    IsMove = true;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}

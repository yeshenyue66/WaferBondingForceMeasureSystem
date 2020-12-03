using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
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
        #region 数据处理
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

        #region 界面处理
        private static ControlModel controlModel = null;
        private static bool isMouseDown;
        private static Point mouseOffset;
        private static Form mainForm;
        public static void CustomizeMove<T>(T obj, Form form) where T : Control
        {
            controlModel = new ControlModel((float)obj.Location.X, (float)obj.Location.Y);
            mainForm = form;

            obj.MouseDown += Obj_MouseDown;
            obj.MouseUp += Obj_MouseUp;
            obj.MouseMove += Obj_MouseMove;
        }

        private static void Obj_MouseMove(object sender, EventArgs e)
        {
            if (isMouseDown)
            {
                Point p = Control.MousePosition;
                p.Offset(mouseOffset.X, mouseOffset.Y);
                mainForm.Location = p;
            }
        }

        private static void Obj_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        public static void Obj_MouseDown(object sender, MouseEventArgs e)
        {
            int yOffset, xOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }
        #endregion
    }
}

using System.Drawing;

namespace WaferBondingForceMeasureSystem.Models.Control
{
    /// <summary>
    /// 功能描述    ：Class1  
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    public class ControlModel
    {

        #region 字段属性
        /// <summary>
        /// 高度
        /// </summary>
        private int height;
        /// <summary>
        /// 宽度
        /// </summary>
        private int width;
        /// <summary>
        /// 字体
        /// </summary>
        private Font fontSet;
        /// <summary>
        /// 坐标X
        /// </summary>
        private float locationx;
        /// <summary>
        /// 坐标Y
        /// </summary>
        private float locationy;

        /// <summary>
        /// 高度
        /// </summary>
        public int Height { get => height; set => height = value; }
        /// <summary>
        /// 宽度
        /// </summary>
        public int Width { get => width; set => width = value; }
        /// <summary>
        /// 字体
        /// </summary>
        public Font FontSet { get => fontSet; set => fontSet = value; }
        /// <summary>
        /// 坐标X
        /// </summary>
        public float Locationx { get => locationx; set => locationx = value; }
        /// <summary>
        /// 坐标Y
        /// </summary>
        public float Locationy { get => locationy; set => locationy = value; }

        #endregion

        #region 构造方法

        /// <summary>
        /// 无参构造方法
        /// </summary>
        public ControlModel()
        {

        }
        
        /// <summary>
        /// 构造方法（返回高度、宽度）
        /// </summary>
        /// <param name="height">高度</param>
        /// <param name="width">宽度</param>
        public ControlModel(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// 构造方法（返回高度、宽度、字体）
        /// </summary>
        /// <param name="height">高度</param>
        /// <param name="width">宽度</param>
        /// <param name="fontSet">字体</param>
        public ControlModel(int height, int width, Font fontSet)
        {
            this.height = height;
            this.width = width;
            this.fontSet = fontSet;
        }

        /// <summary>
        /// 构造方法（返回坐标）
        /// </summary>
        /// <param name="locationx">坐标X</param>
        /// <param name="locationy">坐标Y</param>
        public ControlModel(float locationx, float locationy)
        {
            this.locationx = locationx;
            this.locationy = locationy;
        }

        /// <summary>
        /// 构造方法（返回高度、宽度、坐标）
        /// </summary>
        /// <param name="height">高度</param>
        /// <param name="width">宽度</param>
        /// <param name="locationx">坐标X</param>
        /// <param name="locationy">坐标Y</param>
        public ControlModel(int height, int width, float locationx, float locationy)
        {
            this.height = height;
            this.width = width;
            this.locationx = locationx;
            this.locationy = locationy;
        }

        #endregion

    }
}

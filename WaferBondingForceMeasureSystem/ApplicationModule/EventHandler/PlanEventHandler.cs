using System;

namespace WaferBondingForceMeasureSystem.ApplicationModule.EventHandler
{
    /// <summary>
    /// 功能描述    ：PlanEventHandler
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/12/7 14:53:19 
    /// </summary>
    public class PlanEventHandler
    {
        public delegate void PlanConfirmEventHandler(object sender, PlanConfirmEventArgs e);
        public event PlanConfirmEventHandler PlanConfirm;

        public class PlanConfirmEventArgs : EventArgs
        {
            private string planDescrip;

            public string PlanDescrip { get => planDescrip; }
            public PlanConfirmEventArgs(string planDescrip)
            {
                this.planDescrip = planDescrip;
            }
        }
        protected virtual void Show(PlanConfirmEventArgs e)
        {
            PlanConfirm?.Invoke(this, e);
        }
        public void PlanShow(string planDescrip)
        {
            PlanConfirmEventArgs e = new PlanConfirmEventArgs(planDescrip);
            Show(e);
        }
    }
}

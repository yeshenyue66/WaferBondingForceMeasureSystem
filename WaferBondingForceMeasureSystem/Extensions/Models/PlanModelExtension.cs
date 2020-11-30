using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WaferBondingForceMeasureSystem.Models.Plan;

namespace WaferBondingForceMeasureSystem.Extensions.Models
{
    /// <summary>
    /// 功能描述    ：PlanModelExtension
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 16:06:42 
    /// </summary>
    [Serializable]
    class PlanModelExtension : PlanModel
    {
        //public PlanModel _planModel;
        //public string PlanDescription
        //{
        //    get
        //    {
        //        return Description();
        //    }
        //}
        
    }
    
    //class PlanModelExtensionIterator : IEnumerator
    //{
    //    private int position;

    //    public PlanModelExtensionIterator(int position)
    //    {
    //        Position = position;
    //    }

    //    public object Current => throw new NotImplementedException();

    //    public int Position { get => position; set => position = value; }

    //    public bool MoveNext()
    //    {
    //        return true;
    //    }

    //    public void Reset()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}

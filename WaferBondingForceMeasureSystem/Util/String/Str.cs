using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WaferBondingForceMeasureSystem.Util.String
{
    /// <summary>
    /// 功能描述    ：Str
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/23 14:28:45 
    /// </summary>
    class Str
    {
        public static string RemoveFineMark(string str)
        {
            if(str.EndsWith(",]"))
            {
                return str.Replace(",]", "]");
            }
            else
            {
                return str;
            }
        }
        public static int GetCharSum(string str)
        {
            int CharSum = 0;
            foreach(char c in str)
            {
                CharSum += Convert.ToInt32(c);
            }
            return CharSum;
        }
    }
}

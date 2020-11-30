using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WaferBondingForceMeasureSystem.Util.Config
{
    /// <summary>
    /// 功能描述    ：ConfigElement
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/23 9:06:02 
    /// </summary>
    class ConfigElement : ConfigurationElement
    {
        string RequiredElement;
        [ConfigurationProperty("value", IsDefaultCollection = true)]
        public string Value
        {
            get
            {
                return (string)base["value"];
            }
            set
            {
                base["value"] = value;
            }
        }
  
    }
}

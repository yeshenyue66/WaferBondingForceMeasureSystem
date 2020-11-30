using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WaferBondingForceMeasureSystem.Util.Config
{
    /// <summary>
    /// 功能描述    ：ConfigSection
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/23 8:57:15 
    /// </summary>
    class ConfigSection : ConfigurationSection
    {
        //[ConfigurationProperty("log4net", IsRequired = true)]
        //public string Log4net
        //{
        //    get
        //    {
        //        return (string)base["log4net"];
        //    }
        //    set
        //    {
        //        base["log4net"] = value;
        //    }
        //}

        [ConfigurationProperty("", IsDefaultCollection = true)]
        public ConfigElementCollection ChildSections
        {
            get
            {
                return (ConfigElementCollection)base[""];
            }
        }
    }
}

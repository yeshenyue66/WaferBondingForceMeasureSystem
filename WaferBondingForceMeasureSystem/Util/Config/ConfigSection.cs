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
        [ConfigurationProperty("value", IsRequired = true)]
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

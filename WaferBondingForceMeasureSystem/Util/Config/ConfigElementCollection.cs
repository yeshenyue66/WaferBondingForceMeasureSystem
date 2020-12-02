using System.Configuration;

namespace WaferBondingForceMeasureSystem.Util.Config
{
    /// <summary>
    /// 功能描述    ：ConfigElementCollection
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/23 9:02:14 
    /// </summary>
    class ConfigElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConfigElement();
        }
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConfigElement)element).Value;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }
        protected override string ElementName
        {
            get
            {
                return "appender";
            }
        }

        public ConfigElement this[int index]
        {
            get
            {
                return (ConfigElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }
    }

}

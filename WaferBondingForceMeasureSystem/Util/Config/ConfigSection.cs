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
        [ConfigurationProperty("value")]
        public string Value
        {
            get
            {
                return (string)this["value"];
            }
            set
            {
                this["value"] = value;
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

        public static string GetValue(string configPath, string key)
        {
            Configuration ConfigurationInstance = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
            {
                ExeConfigFilename = configPath
            }, ConfigurationUserLevel.None);

            //ConfigurationInstance.GetSection("appsetting");
            //ConfigurationSectionCollection configurationSectionCollection = ConfigurationInstance.Sections;

            //ConfigSection configSection = ConfigurationInstance.GetSection("LoadPort") as ConfigSection;
            //string b = configSection.Value;

            if (ConfigurationInstance.AppSettings.Settings[key] != null)
            {
                return ConfigurationInstance.AppSettings.Settings[key].Value;
            }
            else
            {
                return string.Empty;
            }
        }

        public static void SetValue(string configPath, string key, string value)
        {
            try
            {
                Configuration ConfigurationInstance = ConfigurationManager.OpenMappedExeConfiguration(new ExeConfigurationFileMap()
                {
                    ExeConfigFilename = configPath
                }, ConfigurationUserLevel.None);

                if (ConfigurationInstance.AppSettings.Settings[key] != null)
                {
                    ConfigurationInstance.AppSettings.Settings[key].Value = value;
                }
                else
                {
                    ConfigurationInstance.AppSettings.Settings.Add(key, value);
                }
                ConfigurationInstance.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch
            {

            }
        }
    }
}

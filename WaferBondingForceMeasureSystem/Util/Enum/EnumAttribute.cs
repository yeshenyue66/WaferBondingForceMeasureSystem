using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WaferBondingForceMeasureSystem.Util.Enum
{
    /// <summary>
    /// 功能描述    ：EnumAttribute
    /// 江苏埃洛德数据技术有限公司 2018-11-6
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/25 11:12:14 
    /// </summary>
    class EnumAttribute
    {
        /// <summary>
        /// 返回枚举项的描述信息
        /// </summary>
        /// <param name="value">要获取描述信息的枚举项</param>
        /// <returns>枚举项的描述信息</returns>
        public static string GetDescription(System.Enum value)
        {
            Type enumType = value.GetType();
            string name = System.Enum.GetName(enumType, value);
            if (name != null)
            {
                FieldInfo fieldInfo = enumType.GetField(name);
                if (fieldInfo != null)
                {
                    if (Attribute.GetCustomAttribute(fieldInfo,
                        typeof(DescriptionAttribute), false) is DescriptionAttribute attr)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

        public static Dictionary<string, string> GetKeyValuePairs(Type enumType)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            FieldInfo[] fieldinfos = enumType.GetFields();
            foreach (FieldInfo field in fieldinfos)
            {
                if (field.FieldType.IsEnum)
                {
                    Object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    dic.Add(field.Name, ((DescriptionAttribute)objs[0]).Description);
                }
            }

            return dic;
        }
    }
}

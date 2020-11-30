using System;
using System.Collections.Generic;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WaferBondingForceMeasureSystem.Models.Plan;

namespace WaferBondingForceMeasureSystem.ApplicationModule.Common.PlanConmmon
{
    /// <summary>
    /// 功能描述    ：PlanBLL
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/18 11:06:06 
    /// </summary>
    class PlanBLL : IPlanBLL
    {
        /// <summary>
        /// 获取方案地址
        /// </summary>
        /// <returns></returns>
        public string PlanAddress()
        {
            return ConfigurationManager.AppSettings["FolderAddress"];
        }

        /// <summary>
        /// 保存方案
        /// </summary>
        /// <param name="Path">方案路径</param>
        /// <param name="planModel">方案</param>
        public void SavePlanData(string Path, PlanModel planModel)
        {
            Stream stream = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            XmlSerializer xmlserial = new XmlSerializer(typeof(PlanModel));
            xmlserial.Serialize(stream, planModel);
            stream.Close();
        }

        /// <summary>
        /// 读取方案
        /// </summary>
        /// <param name="Path">方案路径</param>
        /// <returns></returns>
        public List<PlanModel> ReadPlanData(string Path)
        {
            DirectoryInfo Dir = new DirectoryInfo(PlanAddress());
            List<PlanModel> pModelList = new List<PlanModel>();
            foreach (FileInfo file in Dir.GetFiles("*.txt*", SearchOption.TopDirectoryOnly))
            {
                Stream stream = new FileStream(Path + file.ToString(), FileMode.Open, FileAccess.Read, FileShare.None);
                XmlSerializer xmlserial = new XmlSerializer(typeof(PlanModel));
                PlanModel planModel = xmlserial.Deserialize(stream) as PlanModel;
                pModelList.Add(planModel);
                stream.Close();
            }
            return pModelList;
        }
    }
}

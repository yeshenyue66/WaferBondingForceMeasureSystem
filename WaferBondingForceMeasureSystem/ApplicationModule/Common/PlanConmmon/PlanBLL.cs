using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

        public string[] ReadPlanName()
        {
            return Directory.GetFiles(new PlanBLL().PlanAddress());
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

        /// <summary>
        /// 删除方案
        /// </summary>
        /// <param name="Path">方案路径</param>
        /// <param name="name">方案名</param>
        public void DeletePlanData(string Path, string name)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            foreach(FileInfo file in directoryInfo.GetFiles())
            {
                if (file.Attributes != FileAttributes.Directory)
                {
                    if (name == file.Name.Substring(0, file.Name.LastIndexOf('.')))
                    {
                        file.Delete();
                    }
                }
            }
            foreach (var dicInfo in directoryInfo.GetDirectories())
            {
                DeletePlanData(dicInfo.FullName, name);
            }
        }
    }
}

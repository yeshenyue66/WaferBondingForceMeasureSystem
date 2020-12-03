﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Configuration;

using WaferBondingForceMeasureSystem.Models.SerialPorts;
using WaferBondingForceMeasureSystem.Util.Config;
using System.Xml;

namespace WaferBondingForceMeasureSystem.ApplicationModule.Common.SerialPortCommon
{
    /// <summary>
    /// 功能描述    ：SPBLL
    /// 创 建 者    ：Admin
    /// 创建日期    ：2020/11/17 10:16:14 
    /// </summary>
    class SPBLL : ISPBLL
    {
        /// <summary>
        /// 获取串口列表
        /// </summary>
        /// <returns>返回串口列表</returns>
        public List<StringBuilder> GetSerialPorts()
        {
            List<StringBuilder> SerialPortsList = new List<StringBuilder>();
            try
            {
                string[] ports = SerialPort.GetPortNames();
                SerialPort serialPort = new SerialPort();
                foreach (string _port in ports)
                {
                    if (_port != null)
                    {
                        serialPort.PortName = _port;
                        try
                        {
                            serialPort.Open();
                            SerialPortsList.Add(new StringBuilder(_port));
                            //SerialPortsList.Add(new StringBuilder(_port + "(未连接)"));
                        }
                        catch
                        { 
                            SerialPortsList.Add(new StringBuilder(_port));
                        }
                        serialPort.Close();
                    }
                }
                return SerialPortsList;
            }
            catch
            {
                return default;
            }
        }

        IEnumerable<SerialPortModel> GetSerialList()
        {
            return default;
        }
        public static string LPSerialPortName()
        {
            return ConfigSection.GetValue(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "SerialPort.config", "LoadPort");

            //return ConfigurationManager.AppSettings["LoadPort"];
            //var fileMap = new ExeConfigurationFileMap() { ExeConfigFilename = "C:/Users/Admin/source/repos/WaferBondingForceMeasureSystem/WaferBondingForceMeasureSystem/SerialPort.config" };
            //var config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);

            //Configuration config = ConfigurationManager.OpenExeConfiguration("C:/Users/Admin/source/repos/WaferBondingForceMeasureSystem/WaferBondingForceMeasureSystem/bin/Debug/App.Config");
            //ConfigSection configSection = config.Sections["LoadPort"] as ConfigSection;
            //ConfigSection configSection = (ConfigSection)config.GetSection("LoadPort");
            //return configSection.Value;
        }
    }
}

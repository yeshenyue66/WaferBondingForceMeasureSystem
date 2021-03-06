﻿using System;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.Models.Control;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class AlgorithmSetting : Form
    {
        private static AlgorithmSetting algorithmSetting = null;
        private AlgorithmSetting()
        {
            InitializeComponent();
        }

        public static AlgorithmSetting Singleton()
        {
            if(algorithmSetting == null)
            {
                algorithmSetting = new AlgorithmSetting();
            }
            return algorithmSetting;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        static ControlModel _controlModel;
        public ControlModel ControlInteraction(ControlModel controlModel)
        {
            _controlModel = controlModel;
            return _controlModel;
        }

        private void AlgorithmSetting_Load(object sender, EventArgs e)
        {
            UIBLL.CustomizeMove(this.PanelAlgorSettingTopic, this.LabelAlgorSettingTopic, this);
            //this.Height = 553 * _controlModel.Height / 1080;
            //this.Width = 440 * _controlModel.Width / 1902;
        }

        private void PicBoxSysSettingClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

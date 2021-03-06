﻿using System;
using System.Windows.Forms;

using WaferBondingForceMeasureSystem.CommonHelpers;

namespace WaferBondingForceMeasureSystem.UserControls
{
    public partial class CustomizeTextbox : UserControl
    {
        private static CustomizeTextbox customizeTextbox;
        public int TBoxContent
        {
            get;
            set;
        }
        public CustomizeTextbox()
        {
            InitializeComponent();
        }
        public static CustomizeTextbox Singleton()
        {
            if(customizeTextbox == null)
            {
                customizeTextbox = new CustomizeTextbox();

            }
            return customizeTextbox;
        }

        private void PicBoxUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.TBox.Text = (int.Parse(TBox.Text.Trim()) + 1).ToString();
            }
            catch
            {

            }
        }

        private void TBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PicBoxDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.TBox.Text = (int.Parse(TBox.Text.Trim()) - 1).ToString();
            }
            catch
            {

            }
        }

        private void CustomizeTextbox_Load(object sender, EventArgs e)
        {
            this.TBox.Text = TBoxContent.ToString();
            TextHelper.InputNumOnly<TextBox>(this.TBox);
        }
    }
}

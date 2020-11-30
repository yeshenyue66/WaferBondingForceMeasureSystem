using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WaferBondingForceMeasureSystem.CommonHelpers;

namespace WaferBondingForceMeasureSystem.UserControls
{
    public partial class CustomizeTextbox : UserControl
    {
        public int TBoxContent;
        public CustomizeTextbox()
        {
            InitializeComponent();
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

using System;
using System.Drawing;
using System.Windows.Forms;
using WaferBondingForceMeasureSystem.ApplicationModule.Common.FormCommon;
using WaferBondingForceMeasureSystem.CommonHelpers;
using WaferBondingForceMeasureSystem.UserControls;

namespace WaferBondingForceMeasureSystem.SettingForms
{
    public partial class DataManage : Form
    {
        public DataManage()
        {
            InitializeComponent();
            UIBLL.CustomizeMove<Panel, Label>(this.PanelTopic, this.LabelTopic, this);
        }

        //Panel[] panels;

        private void DataManage_Load(object sender, EventArgs e)
        {
            Panel panelIndivData = new Panel
            {
                Dock = DockStyle.Top
            };
            Panel panelGoods = new Panel
            {
                Height = 22,
                BackColor = Color.FromArgb(215, 218, 224),
                Dock = DockStyle.Top,
            };
            PictureBox picBoxGoods = new PictureBox
            {
                Image = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Images/DGVDown.png"),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(1, 4),
                Size = new Size(20, 20),
            };
            picBoxGoods.Click += new EventHandler((s, eh) => {
                if (panelIndivData.Visible == true) 
                {
                    panelIndivData.Visible = false;
                    picBoxGoods.Image = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Images/DGVUp.png");
                }
                else
                {
                    panelIndivData.Visible = true;
                    picBoxGoods.Image = Image.FromFile(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Images/DGVDown.png");
                }
            });

            Label labelGoods = new Label
            {
                Text = "物料编号：" + "",
                Location = new Point(25, 4),
                Font = new Font("宋体", 11F),
            };
            panelGoods.Controls.Add(picBoxGoods);
            panelGoods.Controls.Add(labelGoods);
            this.PanelData.Controls.Add(panelGoods);
            panelIndivData.Height = new CusDataGridView().Height + panelGoods.Height;
            panelIndivData.Controls.Add(new CusDataGridView { Dock = DockStyle.Top });

            this.PanelData.Controls.Add(panelIndivData);
            this.PanelData.Controls.Add(panelGoods);

        }

        private void PicBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.InitialDirectory = @"E:\";
            openfiledialog.Title = "打开文本文件";
            openfiledialog.Filter = "All Files(*.*)|*.*|txt Files(*.txt)|*.txt";
            openfiledialog.FilterIndex = 2;
            openfiledialog.RestoreDirectory = true;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {

            }
        }

    }
}

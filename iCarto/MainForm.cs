using icarto.views;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace icarto
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public MainForm()
        {
            InitializeComponent();

            this.maptMakeupDescLbl.Text = @"    本地图模板适合用来制作符合国家制图标准的1:50000基本比例尺地形图，模板提供了制作基础地形图所需的符号、配色以及地图整饰要素，即选即用。";
            this.maptExpDescLbl.Text = @"    按照制图向导的提示，导入自己的数据，设计样式，即可快速成图，支持导出JPG、PNG、PDF、AI、CDR、DWG等各种格式。"; 
            //this.materialFlatButton1.Location = new Point(this.Size.Width - 200, this.Size.Height + 200);


            //初始化MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            MappingForm mappingForm = new MappingForm();
            mappingForm.Show();
        }

     

        
        
    }
}
using FontAwesomeIcons;
using icarto.common;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icarto.views
{
    public partial class MappingForm : MaterialForm
    {
        //当前高亮的菜单图标,默认是地图符号菜单
        string activeIbtnName = "symIbtn";

        string[] menuLablName = { "usrLabl", "lyrLabl", "symLabl", "txtAnnoLabl", "graphLabl", "layoutLabl","colorLabl", "moreToolsLabl" };

        public MappingForm()
        {
            InitializeComponent();

            initBasemap();

        }

        private void initBasemap()
        {
            string mxdPath = @"\res\data\s01行政区划.mxd";
            axMapControl1.LoadMxFile(FilePathHelper.getFileAbsolutePath(mxdPath));
        }

     

        private void menuIconClick(object sender, EventArgs e)
        {

            string previousIbtnName = activeIbtnName;
            IconButton currentIbtn = sender as IconButton;
            activeIbtnName = currentIbtn.Name;

            if (previousIbtnName ==activeIbtnName)
            {
                ///相邻2次点击的是同一按钮
                if (this.menuIconTlpl.Visible)
                {
                    this.menuTxtTlpl.Visible = false;
                    
                }
                else
                {
                    this.menuTxtTlpl.Visible = true;

                }
            }
            else
            {
                Color cBlue = new ColorHelper().getColorByEnum(ColorPalatte.blueActive);
                Color cGray = new ColorHelper().getColorByEnum(ColorPalatte.blueActive);

               

                //高亮当前选择的菜单
                switch (activeIbtnName)
                {
                    case "usrIbtn":
                        usrIbtn.InActiveColor = cBlue;
                        usrLabl.ForeColor = cBlue;
                        break;
                    case "lyrIbtn":
                        lyrIbtn.ForeColor = cBlue;
                        lyrLabl.ForeColor = cBlue;
                        break;
                    case "symIbtn":
                        symIbtn.InActiveColor = cBlue;
                        symLabl.ForeColor = cBlue;
                        break;
                    case "txtAnnoIbtn":
                        txtAnnoIbtn.InActiveColor = cBlue;
                        txtAnnoLabl.ForeColor = cBlue;
                        break;
                    case "graphIbtn":
                        graphIbtn.InActiveColor = cBlue;
                        graphLabl.ForeColor = cBlue;
                        break;
                    case "layoutIbtn":
                        layoutIbtn.ForeColor = cBlue;
                        layoutLabl.ForeColor = cBlue;
                        break;
                    case "colorIbtn":
                        colorIbtn.InActiveColor = cBlue;
                        colorLabl.ForeColor = cBlue;
                        break;
                    case "moreToolsIbtn":
                        moreToolsIbtn.InActiveColor = cBlue;
                        moreToolsLabl.ForeColor = cBlue;
                        break;

                }

                //将前一个高亮的菜单变暗
                IconButton previousIbtn = this.Controls.Find(previousIbtnName, true)[0] as IconButton;
                previousIbtn.InActiveColor = cGray;
                string previousLablName = new StringHelper().getRestStrings(previousIbtnName, "Ibtn") + "Labl";
                Label previousLabl = this.Controls.Find(previousLablName, true)[0] as Label;
                previousLabl.ForeColor = cGray;

            }



           


        }

        
    }
}

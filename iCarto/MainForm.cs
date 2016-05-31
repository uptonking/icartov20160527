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

            this.maptMakeupDescLbl.Text = @"    ����ͼģ���ʺ������������Ϲ�����ͼ��׼��1:50000���������ߵ���ͼ��ģ���ṩ��������������ͼ����ķ��š���ɫ�Լ���ͼ����Ҫ�أ���ѡ���á�";
            this.maptExpDescLbl.Text = @"    ������ͼ�򵼵���ʾ�������Լ������ݣ������ʽ�����ɿ��ٳ�ͼ��֧�ֵ���JPG��PNG��PDF��AI��CDR��DWG�ȸ��ָ�ʽ��"; 
            //this.materialFlatButton1.Location = new Point(this.Size.Width - 200, this.Size.Height + 200);


            //��ʼ��MaterialSkinManager
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
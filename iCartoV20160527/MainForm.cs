using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace icarto
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //隐藏WinForm左上角标题栏图标
            this.ShowIcon = false;
        }
    }
}
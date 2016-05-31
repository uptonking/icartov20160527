using MaterialSkin.Controls;
using System.Windows.Forms;
namespace icarto
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rightIbtn = new FontAwesomeIcons.IconButton();
            this.leftIbtn = new FontAwesomeIcons.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.operatorPanel = new System.Windows.Forms.Panel();
            this.maptViewIBtn = new FontAwesomeIcons.IconButton();
            this.maptUseIBtn = new FontAwesomeIcons.IconButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.maptLogoLbl = new System.Windows.Forms.Label();
            this.descPanel = new System.Windows.Forms.Panel();
            this.maptExpDescLbl = new System.Windows.Forms.Label();
            this.maptMakeupDescLbl = new System.Windows.Forms.Label();
            this.maptTitleLbl = new System.Windows.Forms.Label();
            this.largeMaptPcb = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.maptDetailsPnl = new System.Windows.Forms.Panel();
            this.maptThumbListPnl = new System.Windows.Forms.Panel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightIbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftIbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.operatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maptViewIBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maptUseIBtn)).BeginInit();
            this.descPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.largeMaptPcb)).BeginInit();
            this.maptDetailsPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1080, 48);
            this.materialTabSelector1.TabIndex = 17;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(14, 111);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1080, 528);
            this.materialTabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.tabPage1.Controls.Add(this.rightIbtn);
            this.tabPage1.Controls.Add(this.leftIbtn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.maptLogoLbl);
            this.tabPage1.Controls.Add(this.maptDetailsPnl);
            this.tabPage1.Controls.Add(this.maptThumbListPnl);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1072, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "最热地图";
            // 
            // rightIbtn
            // 
            this.rightIbtn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.rightIbtn.BackColor = System.Drawing.Color.Transparent;
            this.rightIbtn.IconType = FontAwesomeIcons.IconType.ChevronRight;
            this.rightIbtn.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.rightIbtn.Location = new System.Drawing.Point(1026, 351);
            this.rightIbtn.Name = "rightIbtn";
            this.rightIbtn.Size = new System.Drawing.Size(28, 120);
            this.rightIbtn.TabIndex = 28;
            this.rightIbtn.TabStop = false;
            this.rightIbtn.ToolTipText = null;
            // 
            // leftIbtn
            // 
            this.leftIbtn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.leftIbtn.BackColor = System.Drawing.Color.Transparent;
            this.leftIbtn.IconType = FontAwesomeIcons.IconType.ChevronLeft;
            this.leftIbtn.InActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.leftIbtn.Location = new System.Drawing.Point(6, 351);
            this.leftIbtn.Name = "leftIbtn";
            this.leftIbtn.Size = new System.Drawing.Size(28, 120);
            this.leftIbtn.TabIndex = 27;
            this.leftIbtn.TabStop = false;
            this.leftIbtn.ToolTipText = null;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(840, 474);
            this.label4.MaximumSize = new System.Drawing.Size(370, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "警用监控电子眼分布图";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(569, 474);
            this.label3.MaximumSize = new System.Drawing.Size(370, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "1:500国家基本比例尺地形图";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(363, 474);
            this.label2.MaximumSize = new System.Drawing.Size(370, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "城管网格图";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(110, 474);
            this.label1.MaximumSize = new System.Drawing.Size(370, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "交通线路图";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::icarto.Properties.Resources.警用监控电子眼分布图;
            this.pictureBox5.Location = new System.Drawing.Point(803, 351);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(213, 120);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::icarto.Properties.Resources.城管网格图;
            this.pictureBox4.Location = new System.Drawing.Point(299, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(213, 120);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::icarto.Properties.Resources.测绘基础地形图500;
            this.pictureBox3.Location = new System.Drawing.Point(551, 351);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 120);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::icarto.Properties.Resources.交通交通线路图;
            this.pictureBox2.Location = new System.Drawing.Point(47, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // operatorPanel
            // 
            this.operatorPanel.Controls.Add(this.maptViewIBtn);
            this.operatorPanel.Controls.Add(this.maptUseIBtn);
            this.operatorPanel.Controls.Add(this.materialFlatButton3);
            this.operatorPanel.Controls.Add(this.materialFlatButton2);
            this.operatorPanel.Location = new System.Drawing.Point(493, 212);
            this.operatorPanel.Name = "operatorPanel";
            this.operatorPanel.Size = new System.Drawing.Size(380, 51);
            this.operatorPanel.TabIndex = 19;
            // 
            // maptViewIBtn
            // 
            this.maptViewIBtn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.maptViewIBtn.BackColor = System.Drawing.Color.Transparent;
            this.maptViewIBtn.IconType = FontAwesomeIcons.IconType.Eye;
            this.maptViewIBtn.InActiveColor = System.Drawing.Color.DimGray;
            this.maptViewIBtn.Location = new System.Drawing.Point(146, 15);
            this.maptViewIBtn.Name = "maptViewIBtn";
            this.maptViewIBtn.Size = new System.Drawing.Size(22, 22);
            this.maptViewIBtn.TabIndex = 3;
            this.maptViewIBtn.TabStop = false;
            this.maptViewIBtn.ToolTipText = null;
            // 
            // maptUseIBtn
            // 
            this.maptUseIBtn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(196)))), ((int)(((byte)(255)))));
            this.maptUseIBtn.BackColor = System.Drawing.Color.Transparent;
            this.maptUseIBtn.IconType = FontAwesomeIcons.IconType.HandOUp;
            this.maptUseIBtn.InActiveColor = System.Drawing.Color.DimGray;
            this.maptUseIBtn.Location = new System.Drawing.Point(20, 15);
            this.maptUseIBtn.Name = "maptUseIBtn";
            this.maptUseIBtn.Size = new System.Drawing.Size(22, 22);
            this.maptUseIBtn.TabIndex = 2;
            this.maptUseIBtn.TabStop = false;
            this.maptUseIBtn.ToolTipText = null;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(170, 9);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton3.TabIndex = 1;
            this.materialFlatButton3.Text = "查看详情";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(44, 9);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(72, 36);
            this.materialFlatButton2.TabIndex = 0;
            this.materialFlatButton2.Text = "使用模板";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // maptLogoLbl
            // 
            this.maptLogoLbl.AutoSize = true;
            this.maptLogoLbl.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.maptLogoLbl.ForeColor = System.Drawing.Color.Gray;
            this.maptLogoLbl.Location = new System.Drawing.Point(126, 16);
            this.maptLogoLbl.Name = "maptLogoLbl";
            this.maptLogoLbl.Size = new System.Drawing.Size(101, 30);
            this.maptLogoLbl.TabIndex = 2;
            this.maptLogoLbl.Text = "地图模板";
            // 
            // descPanel
            // 
            this.descPanel.Controls.Add(this.maptTitleLbl);
            this.descPanel.Controls.Add(this.maptMakeupDescLbl);
            this.descPanel.Controls.Add(this.maptExpDescLbl);
            this.descPanel.Location = new System.Drawing.Point(493, 7);
            this.descPanel.Name = "descPanel";
            this.descPanel.Size = new System.Drawing.Size(380, 200);
            this.descPanel.TabIndex = 18;
            // 
            // maptExpDescLbl
            // 
            this.maptExpDescLbl.AutoSize = true;
            this.maptExpDescLbl.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.maptExpDescLbl.ForeColor = System.Drawing.Color.Gray;
            this.maptExpDescLbl.Location = new System.Drawing.Point(4, 119);
            this.maptExpDescLbl.MaximumSize = new System.Drawing.Size(370, 0);
            this.maptExpDescLbl.Name = "maptExpDescLbl";
            this.maptExpDescLbl.Size = new System.Drawing.Size(93, 20);
            this.maptExpDescLbl.TabIndex = 2;
            this.maptExpDescLbl.Text = "地图导出简介";
            // 
            // maptMakeupDescLbl
            // 
            this.maptMakeupDescLbl.AutoSize = true;
            this.maptMakeupDescLbl.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.maptMakeupDescLbl.ForeColor = System.Drawing.Color.Gray;
            this.maptMakeupDescLbl.Location = new System.Drawing.Point(4, 48);
            this.maptMakeupDescLbl.MaximumSize = new System.Drawing.Size(370, 0);
            this.maptMakeupDescLbl.Name = "maptMakeupDescLbl";
            this.maptMakeupDescLbl.Size = new System.Drawing.Size(93, 20);
            this.maptMakeupDescLbl.TabIndex = 1;
            this.maptMakeupDescLbl.Text = "模板构成简介";
            // 
            // maptTitleLbl
            // 
            this.maptTitleLbl.AutoSize = true;
            this.maptTitleLbl.Font = new System.Drawing.Font("Microsoft YaHei", 16F);
            this.maptTitleLbl.ForeColor = System.Drawing.Color.Gray;
            this.maptTitleLbl.Location = new System.Drawing.Point(4, 4);
            this.maptTitleLbl.Name = "maptTitleLbl";
            this.maptTitleLbl.Size = new System.Drawing.Size(316, 30);
            this.maptTitleLbl.TabIndex = 0;
            this.maptTitleLbl.Text = "1:50000国家基本比例尺地形图";
            // 
            // largeMaptPcb
            // 
            this.largeMaptPcb.Image = global::icarto.Properties.Resources.测绘基础地形图5W;
            this.largeMaptPcb.Location = new System.Drawing.Point(25, 16);
            this.largeMaptPcb.Name = "largeMaptPcb";
            this.largeMaptPcb.Size = new System.Drawing.Size(444, 250);
            this.largeMaptPcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largeMaptPcb.TabIndex = 17;
            this.largeMaptPcb.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1072, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "最新地图";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1072, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "测绘类";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1072, 498);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "交通类";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1072, 498);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "国土类";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // maptDetailsPnl
            // 
            this.maptDetailsPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maptDetailsPnl.Controls.Add(this.descPanel);
            this.maptDetailsPnl.Controls.Add(this.operatorPanel);
            this.maptDetailsPnl.Controls.Add(this.largeMaptPcb);
            this.maptDetailsPnl.Location = new System.Drawing.Point(89, 49);
            this.maptDetailsPnl.Name = "maptDetailsPnl";
            this.maptDetailsPnl.Size = new System.Drawing.Size(900, 280);
            this.maptDetailsPnl.TabIndex = 29;
            // 
            // maptThumbListPnl
            // 
            this.maptThumbListPnl.Location = new System.Drawing.Point(0, 340);
            this.maptThumbListPnl.Name = "maptThumbListPnl";
            this.maptThumbListPnl.Size = new System.Drawing.Size(1060, 150);
            this.maptThumbListPnl.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1080, 640);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iCarto快速制图";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightIbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftIbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.operatorPanel.ResumeLayout(false);
            this.operatorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maptViewIBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maptUseIBtn)).EndInit();
            this.descPanel.ResumeLayout(false);
            this.descPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.largeMaptPcb)).EndInit();
            this.maptDetailsPnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialTabSelector materialTabSelector1;
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private TabPage tabPage4;
        private Panel descPanel;
        private PictureBox largeMaptPcb;
        private Label maptTitleLbl;
        private Label maptLogoLbl;
        private Label maptMakeupDescLbl;
        private Label maptExpDescLbl;
        private Panel operatorPanel;
        private MaterialFlatButton materialFlatButton3;
        private MaterialFlatButton materialFlatButton2;
        private FontAwesomeIcons.IconButton maptUseIBtn;
        private FontAwesomeIcons.IconButton maptViewIBtn;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesomeIcons.IconButton leftIbtn;
        private FontAwesomeIcons.IconButton rightIbtn;
        private TabPage tabPage5;
        private Panel maptDetailsPnl;
        private Panel maptThumbListPnl;

    }
}


using System;
using System.Drawing;
namespace paint
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Open = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ImageProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.Rorate = new System.Windows.Forms.ToolStripMenuItem();
            this.HorMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.VMirror = new System.Windows.Forms.ToolStripMenuItem();
            this.InsColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Sharp = new System.Windows.Forms.ToolStripMenuItem();
            this.Embossment = new System.Windows.Forms.ToolStripMenuItem();
            this.InLay = new System.Windows.Forms.ToolStripMenuItem();
            this.Gray = new System.Windows.Forms.ToolStripMenuItem();
            this.直线ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Solid = new System.Windows.Forms.ToolStripMenuItem();
            this.Dash = new System.Windows.Forms.ToolStripMenuItem();
            this.DashDot = new System.Windows.Forms.ToolStripMenuItem();
            this.DashDotDot = new System.Windows.Forms.ToolStripMenuItem();
            this.Dot = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrowAnchor = new System.Windows.Forms.ToolStripMenuItem();
            this.arrowAnchorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondAnchorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareAnchor = new System.Windows.Forms.ToolStripMenuItem();
            this.triangle = new System.Windows.Forms.ToolStripMenuItem();
            this.终点类型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrowAnchorEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.diamondAnchorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roundAnchorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareAnchorEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TriangleEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.画笔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewT = new System.Windows.Forms.ToolStripButton();
            this.OpenT = new System.Windows.Forms.ToolStripButton();
            this.SaveT = new System.Windows.Forms.ToolStripButton();
            this.LINE = new System.Windows.Forms.ToolStripButton();
            this.RECT = new System.Windows.Forms.ToolStripButton();
            this.Circle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.颜色 = new System.Windows.Forms.ToolStripDropDownButton();
            this.RED = new System.Windows.Forms.ToolStripMenuItem();
            this.GREE = new System.Windows.Forms.ToolStripMenuItem();
            this.BLUE = new System.Windows.Forms.ToolStripMenuItem();
            this.linesize = new System.Windows.Forms.ToolStripTextBox();
            this.FRect = new System.Windows.Forms.ToolStripButton();
            this.FEll = new System.Windows.Forms.ToolStripButton();
            this.ColorSet = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MousePos = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 52);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1004, 664);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 664);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.ImageProcess,
            this.直线ToolStripMenuItem,
            this.画笔ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New,
            this.Open,
            this.Save});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(41, 20);
            this.File.Text = "文件";
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(94, 22);
            this.New.Text = "新建";
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(94, 22);
            this.Open.Text = "打开";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 22);
            this.Save.Text = "保存";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ImageProcess
            // 
            this.ImageProcess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rorate,
            this.HorMirror,
            this.VMirror,
            this.InsColor,
            this.Sharp,
            this.Embossment,
            this.InLay,
            this.Gray});
            this.ImageProcess.Name = "ImageProcess";
            this.ImageProcess.Size = new System.Drawing.Size(65, 20);
            this.ImageProcess.Text = "图像处理";
            // 
            // Rorate
            // 
            this.Rorate.Name = "Rorate";
            this.Rorate.Size = new System.Drawing.Size(118, 22);
            this.Rorate.Text = "旋转";
            this.Rorate.Click += new System.EventHandler(this.Rorate_Click);
            // 
            // HorMirror
            // 
            this.HorMirror.Name = "HorMirror";
            this.HorMirror.Size = new System.Drawing.Size(118, 22);
            this.HorMirror.Text = "水平镜象";
            this.HorMirror.Click += new System.EventHandler(this.HorMirror_Click);
            // 
            // VMirror
            // 
            this.VMirror.Name = "VMirror";
            this.VMirror.Size = new System.Drawing.Size(118, 22);
            this.VMirror.Text = "竖直镜象";
            this.VMirror.Click += new System.EventHandler(this.VMirror_Click);
            // 
            // InsColor
            // 
            this.InsColor.Name = "InsColor";
            this.InsColor.Size = new System.Drawing.Size(118, 22);
            this.InsColor.Text = "逆反处理";
            this.InsColor.Click += new System.EventHandler(this.InsColor_Click);
            // 
            // Sharp
            // 
            this.Sharp.Name = "Sharp";
            this.Sharp.Size = new System.Drawing.Size(118, 22);
            this.Sharp.Text = "锐化";
            this.Sharp.Click += new System.EventHandler(this.Sharp_Click);
            // 
            // Embossment
            // 
            this.Embossment.Name = "Embossment";
            this.Embossment.Size = new System.Drawing.Size(118, 22);
            this.Embossment.Text = "浮雕处理";
            this.Embossment.Click += new System.EventHandler(this.Embossment_Click);
            // 
            // InLay
            // 
            this.InLay.Name = "InLay";
            this.InLay.Size = new System.Drawing.Size(118, 22);
            this.InLay.Text = "镶嵌处理";
            this.InLay.Click += new System.EventHandler(this.InLay_Click);
            // 
            // Gray
            // 
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(118, 22);
            this.Gray.Text = "灰度图像";
            this.Gray.Click += new System.EventHandler(this.Gray_Click);
            // 
            // 直线ToolStripMenuItem
            // 
            this.直线ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Solid,
            this.ArrowAnchor,
            this.终点类型ToolStripMenuItem});
            this.直线ToolStripMenuItem.Name = "直线ToolStripMenuItem";
            this.直线ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.直线ToolStripMenuItem.Text = "线型";
            // 
            // Solid
            // 
            this.Solid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dash,
            this.DashDot,
            this.DashDotDot,
            this.Dot,
            this.solidToolStripMenuItem});
            this.Solid.Name = "Solid";
            this.Solid.Size = new System.Drawing.Size(118, 22);
            this.Solid.Text = "虚线类型";
            // 
            // Dash
            // 
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(130, 22);
            this.Dash.Text = "Dash";
            this.Dash.Click += new System.EventHandler(this.Dash_Click);
            // 
            // DashDot
            // 
            this.DashDot.Name = "DashDot";
            this.DashDot.Size = new System.Drawing.Size(130, 22);
            this.DashDot.Text = "DashDot";
            this.DashDot.Click += new System.EventHandler(this.DashDot_Click);
            // 
            // DashDotDot
            // 
            this.DashDotDot.Name = "DashDotDot";
            this.DashDotDot.Size = new System.Drawing.Size(130, 22);
            this.DashDotDot.Text = "DashDotDot";
            this.DashDotDot.Click += new System.EventHandler(this.DashDotDot_Click);
            // 
            // Dot
            // 
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(130, 22);
            this.Dot.Text = "Dot";
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // ArrowAnchor
            // 
            this.ArrowAnchor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrowAnchorToolStripMenuItem,
            this.diamondAnchorToolStripMenuItem,
            this.squareAnchor,
            this.triangle});
            this.ArrowAnchor.Name = "ArrowAnchor";
            this.ArrowAnchor.Size = new System.Drawing.Size(118, 22);
            this.ArrowAnchor.Text = "起点类型";
            // 
            // arrowAnchorToolStripMenuItem
            // 
            this.arrowAnchorToolStripMenuItem.Name = "arrowAnchorToolStripMenuItem";
            this.arrowAnchorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.arrowAnchorToolStripMenuItem.Text = "ArrowAnchor";
            this.arrowAnchorToolStripMenuItem.Click += new System.EventHandler(this.arrowAnchorToolStripMenuItem_Click);
            // 
            // diamondAnchorToolStripMenuItem
            // 
            this.diamondAnchorToolStripMenuItem.Name = "diamondAnchorToolStripMenuItem";
            this.diamondAnchorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.diamondAnchorToolStripMenuItem.Text = "DiamondAnchor";
            this.diamondAnchorToolStripMenuItem.Click += new System.EventHandler(this.diamondAnchorToolStripMenuItem_Click);
            // 
            // squareAnchor
            // 
            this.squareAnchor.Name = "squareAnchor";
            this.squareAnchor.Size = new System.Drawing.Size(148, 22);
            this.squareAnchor.Text = "SquareAnchor";
            this.squareAnchor.Click += new System.EventHandler(this.squareAnchor_Click);
            // 
            // triangle
            // 
            this.triangle.Name = "triangle";
            this.triangle.Size = new System.Drawing.Size(148, 22);
            this.triangle.Text = "Triangle";
            this.triangle.Click += new System.EventHandler(this.triangle_Click);
            // 
            // 终点类型ToolStripMenuItem
            // 
            this.终点类型ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArrowAnchorEnd,
            this.diamondAnchorToolStripMenuItem1,
            this.roundAnchorToolStripMenuItem,
            this.squareAnchorEndToolStripMenuItem,
            this.TriangleEnd});
            this.终点类型ToolStripMenuItem.Name = "终点类型ToolStripMenuItem";
            this.终点类型ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.终点类型ToolStripMenuItem.Text = "终点类型";
            // 
            // ArrowAnchorEnd
            // 
            this.ArrowAnchorEnd.Name = "ArrowAnchorEnd";
            this.ArrowAnchorEnd.Size = new System.Drawing.Size(166, 22);
            this.ArrowAnchorEnd.Text = "ArrowAnchorEnd";
            this.ArrowAnchorEnd.Click += new System.EventHandler(this.ArrowAnchorEnd_Click);
            // 
            // diamondAnchorToolStripMenuItem1
            // 
            this.diamondAnchorToolStripMenuItem1.Name = "diamondAnchorToolStripMenuItem1";
            this.diamondAnchorToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.diamondAnchorToolStripMenuItem1.Text = "DiamondAnchorEnd";
            this.diamondAnchorToolStripMenuItem1.Click += new System.EventHandler(this.diamondAnchorToolStripMenuItem1_Click);
            // 
            // roundAnchorToolStripMenuItem
            // 
            this.roundAnchorToolStripMenuItem.Name = "roundAnchorToolStripMenuItem";
            this.roundAnchorToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.roundAnchorToolStripMenuItem.Text = "RoundAnchorEnd";
            this.roundAnchorToolStripMenuItem.Click += new System.EventHandler(this.roundAnchorToolStripMenuItem_Click);
            // 
            // squareAnchorEndToolStripMenuItem
            // 
            this.squareAnchorEndToolStripMenuItem.Name = "squareAnchorEndToolStripMenuItem";
            this.squareAnchorEndToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.squareAnchorEndToolStripMenuItem.Text = "SquareAnchorEnd";
            this.squareAnchorEndToolStripMenuItem.Click += new System.EventHandler(this.squareAnchorEndToolStripMenuItem_Click);
            // 
            // TriangleEnd
            // 
            this.TriangleEnd.Name = "TriangleEnd";
            this.TriangleEnd.Size = new System.Drawing.Size(166, 22);
            this.TriangleEnd.Text = "TriangleEnd";
            this.TriangleEnd.Click += new System.EventHandler(this.squareAnchorToolStripMenuItem_Click);
            // 
            // 画笔ToolStripMenuItem
            // 
            this.画笔ToolStripMenuItem.Name = "画笔ToolStripMenuItem";
            this.画笔ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.画笔ToolStripMenuItem.Text = "画笔";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewT,
            this.OpenT,
            this.SaveT,
            this.LINE,
            this.RECT,
            this.Circle,
            this.toolStripSeparator1,
            this.颜色,
            this.linesize,
            this.FRect,
            this.FEll,
            this.ColorSet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1004, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewT
            // 
            this.NewT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewT.Image = ((System.Drawing.Image)(resources.GetObject("NewT.Image")));
            this.NewT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewT.Name = "NewT";
            this.NewT.Size = new System.Drawing.Size(23, 22);
            this.NewT.Text = "toolStripButton1";
            this.NewT.Click += new System.EventHandler(this.NewT_Click);
            // 
            // OpenT
            // 
            this.OpenT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenT.Image = ((System.Drawing.Image)(resources.GetObject("OpenT.Image")));
            this.OpenT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenT.Name = "OpenT";
            this.OpenT.Size = new System.Drawing.Size(23, 22);
            this.OpenT.Text = "toolStripButton1";
            this.OpenT.Click += new System.EventHandler(this.OpenT_Click);
            // 
            // SaveT
            // 
            this.SaveT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveT.Image = ((System.Drawing.Image)(resources.GetObject("SaveT.Image")));
            this.SaveT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveT.Name = "SaveT";
            this.SaveT.Size = new System.Drawing.Size(23, 22);
            this.SaveT.Text = "toolStripButton2";
            this.SaveT.Click += new System.EventHandler(this.SaveT_Click);
            // 
            // LINE
            // 
            this.LINE.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LINE.Image = ((System.Drawing.Image)(resources.GetObject("LINE.Image")));
            this.LINE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LINE.Name = "LINE";
            this.LINE.Size = new System.Drawing.Size(23, 22);
            this.LINE.Tag = "直线";
            this.LINE.Text = "直线";
            this.LINE.Click += new System.EventHandler(this.LINE_Click);
            // 
            // RECT
            // 
            this.RECT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RECT.Image = ((System.Drawing.Image)(resources.GetObject("RECT.Image")));
            this.RECT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RECT.Name = "RECT";
            this.RECT.Size = new System.Drawing.Size(23, 22);
            this.RECT.Text = "矩形";
            this.RECT.Click += new System.EventHandler(this.RECT_Click);
            // 
            // Circle
            // 
            this.Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(23, 22);
            this.Circle.Text = "圆";
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // 颜色
            // 
            this.颜色.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.颜色.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RED,
            this.GREE,
            this.BLUE});
            this.颜色.Image = ((System.Drawing.Image)(resources.GetObject("颜色.Image")));
            this.颜色.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.颜色.Name = "颜色";
            this.颜色.Size = new System.Drawing.Size(29, 22);
            this.颜色.Text = "toolStripDropDownButton1";
            // 
            // RED
            // 
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(152, 22);
            this.RED.Text = "红";
            this.RED.Click += new System.EventHandler(this.RED_Click);
            // 
            // GREE
            // 
            this.GREE.Name = "GREE";
            this.GREE.Size = new System.Drawing.Size(152, 22);
            this.GREE.Text = "绿";
            this.GREE.Click += new System.EventHandler(this.GREE_Click);
            // 
            // BLUE
            // 
            this.BLUE.Name = "BLUE";
            this.BLUE.Size = new System.Drawing.Size(152, 22);
            this.BLUE.Text = "蓝";
            this.BLUE.Click += new System.EventHandler(this.BLUE_Click);
            // 
            // linesize
            // 
            this.linesize.Name = "linesize";
            this.linesize.Size = new System.Drawing.Size(100, 25);
            this.linesize.Text = "2";
            // 
            // FRect
            // 
            this.FRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FRect.Image = ((System.Drawing.Image)(resources.GetObject("FRect.Image")));
            this.FRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FRect.Name = "FRect";
            this.FRect.Size = new System.Drawing.Size(23, 22);
            this.FRect.Text = "实矩形";
            this.FRect.Click += new System.EventHandler(this.FRect_Click);
            // 
            // FEll
            // 
            this.FEll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FEll.Image = ((System.Drawing.Image)(resources.GetObject("FEll.Image")));
            this.FEll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FEll.Name = "FEll";
            this.FEll.Size = new System.Drawing.Size(23, 22);
            this.FEll.Text = "实椭圆";
            this.FEll.Click += new System.EventHandler(this.FEll_Click);
            // 
            // ColorSet
            // 
            this.ColorSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ColorSet.Image = ((System.Drawing.Image)(resources.GetObject("ColorSet.Image")));
            this.ColorSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorSet.Name = "ColorSet";
            this.ColorSet.Size = new System.Drawing.Size(23, 22);
            this.ColorSet.Text = "颜色";
            this.ColorSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ColorSet.Click += new System.EventHandler(this.ColorSet_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MousePos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1004, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // MousePos
            // 
            this.MousePos.Name = "MousePos";
            this.MousePos.Size = new System.Drawing.Size(23, 17);
            this.MousePos.Text = "0,0";
            // 
            // Form1
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1016, 698);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Open;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem ImageProcess;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewT;
        private System.Windows.Forms.ToolStripButton SaveT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MousePos;
        private System.Windows.Forms.ToolStripButton OpenT;
        //private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem Rorate;
        private System.Windows.Forms.ToolStripMenuItem HorMirror;
        private System.Windows.Forms.ToolStripMenuItem VMirror;
        private System.Windows.Forms.ToolStripButton LINE;
        private System.Windows.Forms.ToolStripButton RECT;
        private System.Windows.Forms.ToolStripButton Circle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton 颜色;
        private System.Windows.Forms.ToolStripMenuItem RED;
        private System.Windows.Forms.ToolStripMenuItem GREE;
        private System.Windows.Forms.ToolStripMenuItem BLUE;
        private System.Windows.Forms.ToolStripTextBox linesize;
        private System.Windows.Forms.ToolStripButton FRect;
        private System.Windows.Forms.ToolStripButton FEll;
        private System.Windows.Forms.ToolStripMenuItem InsColor;
        private System.Windows.Forms.ToolStripMenuItem Sharp;
        private System.Windows.Forms.ToolStripMenuItem Embossment;
        private System.Windows.Forms.ToolStripMenuItem InLay;
        private System.Windows.Forms.ToolStripMenuItem Gray;
        private System.Windows.Forms.ToolStripButton ColorSet;
        private System.Windows.Forms.ToolStripMenuItem 直线ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Solid;
        private System.Windows.Forms.ToolStripMenuItem ArrowAnchor;
        private System.Windows.Forms.ToolStripMenuItem 终点类型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Dash;
        private System.Windows.Forms.ToolStripMenuItem DashDot;
        private System.Windows.Forms.ToolStripMenuItem DashDotDot;
        private System.Windows.Forms.ToolStripMenuItem Dot;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrowAnchorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diamondAnchorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareAnchor;
        private System.Windows.Forms.ToolStripMenuItem triangle;
        private System.Windows.Forms.ToolStripMenuItem ArrowAnchorEnd;
        private System.Windows.Forms.ToolStripMenuItem diamondAnchorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roundAnchorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareAnchorEndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TriangleEnd;
        private System.Windows.Forms.ToolStripMenuItem 画笔ToolStripMenuItem;
    }
}


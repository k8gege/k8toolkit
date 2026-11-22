using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaintII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "f:\\";
            openFileDialog1.Filter = "image files (*.bmp)|*.bmp|image files(*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Image image = Image.FromFile(openFileDialog1.FileName);
                try
                {
                    this.bitmap = new Bitmap(openFileDialog1.FileName);
                    imgwidth = ClientRectangle.Width;
                    imgheight = ClientRectangle.Height;
                    Graphics g = this.CreateGraphics();
                    g.DrawImage(bitmap, ClientRectangle);
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show("文件包含图像数据");
                }

            }




        }



        private void ZoomOut_Click(object sender, EventArgs e)
        {
           
            imgheight =(int)  Math.Ceiling(imgheight/1.1);
            imgwidth =(int) Math.Ceiling(imgwidth / 1.1);
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.White);
            Rectangle rectback = new Rectangle(0, 0, 1024, 768);
            g.FillRectangle(brush, ClientRectangle);
            g.DrawImage(bitmap, 0, 0, imgwidth, imgheight);

        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
           // RedrawWindow();
            imgheight = (int) Math.Ceiling(imgheight * 1.1);
            imgwidth = (int) Math.Ceiling(imgwidth * 1.1);
            Graphics g = this.CreateGraphics();
            Brush brush = new SolidBrush(Color.White);
            Rectangle rectback = new Rectangle(0, 0, 1024, 768);
            g.FillRectangle(brush, rectback);
            g.DrawImage(bitmap, 0,0,imgwidth,imgheight);
            this.AutoScrollMinSize = new Size(imgwidth,imgheight);


        }
    }
}
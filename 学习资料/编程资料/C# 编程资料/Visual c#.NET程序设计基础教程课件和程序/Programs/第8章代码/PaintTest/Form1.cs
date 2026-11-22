using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace PaintTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Line_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Blue, 3);
            blackPen.DashStyle = DashStyle.Dash;
           // Create points that define line.
           Point start = new Point(100, 100);
           Point end = new Point(500, 500);
          // Draw line to screen.
           g.DrawLine(blackPen, start, end);
           start = end;
           end = new Point(100, 500);
           g.DrawLine(blackPen, start, end);
        }

        private void Rect_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            blackPen.DashStyle = DashStyle.Dash;
            // 建立矩形.
            Rectangle rect = new Rectangle(100, 100, 200, 200);
            // 绘制矩形
            g.DrawRectangle(blackPen, rect); 

        }

        private void FillRect_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            // 构建矩形对象.
            Rectangle rect = new Rectangle(100, 100, 200, 200);
            // 画实心矩形.
            g.FillRectangle(blueBrush, rect);

        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            //构建矩形对象.
            Rectangle rect = new Rectangle(100, 100, 200, 100);
            // 画空心空心椭圆.
            g.DrawEllipse(blackPen, rect);
        }

        private void Arc_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            // Create rectangle to bound ellipse.
            RectangleF rect = new RectangleF(100.0F, 100.0F, 100.0F, 200.0F);
            // Create start and sweep angles on ellipse.
            float startAngle = 0.0F;
            float sweepAngle = 90.0F;
            // Draw arc to screen.
            g.DrawArc(blackPen, rect, startAngle, sweepAngle);

        }

        private void FillEllipse_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush redBrush = new SolidBrush(Color.Red);
            // Create rectangle for ellipse.
            int x = 100;
            int y = 100;
            int width = 200;
            int height = 100;
            Rectangle rect = new Rectangle(x, y, width, height);
            // Fill ellipse on screen.
            g.FillEllipse(redBrush, rect);

        }

        private void Ploygon_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);          // Create points that define polygon.
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 25);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);
            Point[] curvePoints =
             {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7
             };
            // Draw polygon to screen.
            g.DrawPolygon(blackPen, curvePoints);

        }

        private void EllipseShad_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            HatchBrush myHatchBrush =
                new HatchBrush(HatchStyle.DottedGrid, Color.Blue, Color.Green);

            // Create rectangle for ellipse.
            int x = 100;
            int y = 100;
            int width = 200;
            int height = 100;
            Rectangle rect = new Rectangle(x, y, width, height);
            // Fill ellipse on screen.
            g.FillEllipse(myHatchBrush, rect);

        }

        private void Ellipsetext_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Image myImage = Image.FromFile("F:\\source\\C#\\PaintTest\\text.jpg");
            TextureBrush myTextureBrush = new TextureBrush(myImage);
            g.FillEllipse(myTextureBrush, 100,100, 200, 500);

        }

        private void EllipseLearG_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Rectangle myRectangle = new Rectangle(100, 100, 200, 500);
            LinearGradientBrush myLinearGradientBrush = new LinearGradientBrush(
               myRectangle,
               Color.Blue,
               Color.Green,
               LinearGradientMode.ForwardDiagonal);
            g.FillEllipse(myLinearGradientBrush, 100, 100, 200, 500);

        }
    }
}
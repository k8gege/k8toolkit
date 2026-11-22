using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace paint
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Point start;
        bool CanMove;
        int select = 0;
        Pen pen = new Pen(Color.Red, 2);
        Brush brush = new SolidBrush(Color.Gray);
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Red, float.Parse(this.linesize.Text));
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.pictureBox1.Image = bitmap;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "f:\\";
            saveFileDialog1.Filter = "image files (*.bmp)|*.bmp|image files(*.jpg)|*.jpg|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (bitmap != null)
                        bitmap.Save(saveFileDialog1.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("There was a problem saving the file." +
                        "Check the file permissions.");
                }

            }


        }

        private void Open_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

             openFileDialog1.InitialDirectory = "f:\\" ;
             openFileDialog1.Filter = "image files (*.bmp)|*.bmp|image files(*.jpg)|*.jpg|All files (*.*)|*.*";
             openFileDialog1.FilterIndex = 2 ;
             openFileDialog1.RestoreDirectory = true ;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Image image = Image.FromFile(openFileDialog1.FileName);
                this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                try
                {
                    this.bitmap = new Bitmap(openFileDialog1.FileName);
                    this.pictureBox1.Image = bitmap;
                }
                catch(System.ArgumentException)
                {
                    MessageBox.Show("文件包含图像数据");
                }

            }



        }

        private void New_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            this.pictureBox1.Image = bitmap;

        }

        private void NewT_Click(object sender, EventArgs e)
        {
            New_Click( sender,  e);
        }

        private void SaveT_Click(object sender, EventArgs e)
        {
            Save_Click( sender,  e);
        }

        private void OpenT_Click(object sender, EventArgs e)
        {
            Open_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Rorate_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                this.pictureBox1.Image = bitmap;
            }

        }

        private void HorMirror_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                this.pictureBox1.Image = bitmap;
            }

        }

        private void VMirror_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
                this.pictureBox1.Image = bitmap;
            }

        }

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!CanMove)
                {
                    this.start = new Point(e.X, e.Y);
                    this.CanMove = true;
                }
                else
                {
                    this.pictureBox1.Image = this.bitmap;
                    Graphics g = Graphics.FromImage(this.pictureBox1.Image);
                    switch(select){
                        case 1:
                             g.DrawLine(pen, this.start, new Point(e.X, e.Y));
                            break;
                        case 2:
                            if (start.X < e.X && start.Y < e.Y)
                                g.DrawRectangle(pen, start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                        case 3:
                            if (start.X < e.X && start.Y < e.Y)
                                g.DrawEllipse(pen, start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                        case 4:
                            if (start.X < e.X && start.Y < e.Y)
                                g.FillRectangle(brush, start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                        case 5:
                            if (start.X < e.X && start.Y < e.Y)
                                g.FillEllipse(brush, start.X, start.Y, e.X - start.X, e.Y - start.Y);
                            break;
                    }
                    g.Dispose();
                    CanMove = false;
                    //this.pictureBox1.Invalidate();
                }
            }

        }
        private void Form1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (this.CanMove == true)
            {
                this.pictureBox1.Image = (Bitmap)this.bitmap.Clone();
                Graphics g = Graphics.FromImage(this.pictureBox1.Image);
                switch(select){
                    case 1:
                       g.DrawLine(pen, this.start, new Point(e.X, e.Y));//重绘
                      break;
                    case 2:
                        if (start.X<e.X&&start.Y<e.Y)
                             g.DrawRectangle(pen, start.X,start.Y, e.X-start.X,e.Y-start.Y);
                        break;
                    case 3:
                        if (start.X < e.X && start.Y < e.Y)
                            g.DrawEllipse(pen, start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    case 4:
                        if (start.X < e.X && start.Y < e.Y)
                            g.FillRectangle(brush, start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;
                    case 5:
                        if (start.X < e.X && start.Y < e.Y)
                            g.FillEllipse(brush, start.X, start.Y, e.X - start.X, e.Y - start.Y);
                        break;


                }

                g.Dispose();
            }
            this.MousePos.Text = "坐标" + e.X + "," + e.Y;

        }

        private void LINE_Click(object sender, EventArgs e)
        {
            select = 1;

        }

        private void RECT_Click(object sender, EventArgs e)
        {
            select = 2;
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            select = 3;

        }

        private void RED_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, float.Parse(this.linesize.Text));
            brush=new  SolidBrush(Color.Red);

        }

        private void GREE_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Green, float.Parse(this.linesize.Text));
            brush = new SolidBrush(Color.Green);

        }

        private void BLUE_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, float.Parse(this.linesize.Text));
            brush = new SolidBrush(Color.Blue);

        }

        private void FRect_Click(object sender, EventArgs e)
        {
            select = 4;
        }

        private void FEll_Click(object sender, EventArgs e)
        {
            select = 5;
        }

        private void InsColor_Click(object sender, EventArgs e)
        {

            if (bitmap != null)
            {
                Color c = new Color();
                for (int i=0;i<bitmap.Width;i++)
                    for (int j = 0; j < bitmap.Height; j++)
                    {
                        c = bitmap.GetPixel(i, j);
                        Color c1 = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                        bitmap.SetPixel(i, j, c1);

                    }
                this.pictureBox1.Image = bitmap;

            }

        }

        private void Sharp_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Color c = new Color();
                Color c1=new Color();
                int rr,gg,bb;
                for (int i=1;i<bitmap.Width;i++)
                    for (int j = 1; j < bitmap.Height; j++)
                    {
                        c = bitmap.GetPixel(i, j);
                        c1=bitmap.GetPixel(i-1, j-1);
                        rr=c.R+Math.Abs(c.R-c1.R)/2;
                        gg=c.G+Math.Abs(c.G-c1.G)/2;
                        bb=c.B+Math.Abs(c.B-c1.B)/2;
                        if (rr>255)
                            rr=255;
                        if (gg>255)
                            gg=255;
                        if (bb > 255)
                            bb = 255;
                        Color c2 = Color.FromArgb(rr, gg,bb);
                        bitmap.SetPixel(i, j, c2);

                    }
                this.pictureBox1.Image = bitmap;
            }

        }

        private void Embossment_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Color c = new Color();
                Color c1 = new Color();
                Color c2 = new Color();
                Color c3 = new Color();
                Color c4 = new Color();

                int rr, gg, bb;
                for (int i = 1; i < bitmap.Width-1; i++)
                    for (int j = 1; j < bitmap.Height-1; j++)
                    {
                        c = bitmap.GetPixel(i, j);
                        c1 = bitmap.GetPixel(i - 1, j -1);
                        c2 = bitmap.GetPixel(i, j-1);
                        c3 = bitmap.GetPixel(i+1, j);
                        c4 = bitmap.GetPixel(i, j + 1);
                        rr =(c.R-c1.R+64);
                        bb = (c.B  - c1.B +64);
                        gg =(c.G  - c1.G +64);
                        if (rr > 255)
                            rr = 255;
                        if (gg > 255)
                            gg = 255;
                        if (bb > 255)
                            bb = 255;
                        if (rr < 0)
                            rr = 0;
                        if (gg < 0)
                            gg = 0;
                        if (bb < 0)
                            bb = 0;
                        Color cn = Color.FromArgb(rr, bb, gg);
                        bitmap.SetPixel(i, j, cn);

                    }
                this.pictureBox1.Image = bitmap;
            }
        }

        private void InLay_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Color c = new Color();
                Color c1 = new Color();
                int rr, gg, bb,kr,kc;
                for (int i = 0; i < bitmap.Width - 5; i+=5)
                    for (int j = 0; j < bitmap.Height - 5; j+=5)
                    {
                        rr=0;
                        gg = 0;
                        bb = 0;
                        for ( kc = 0; kc < 5; kc++)
                            for ( kr = 0; kr < 5; kr++)
                            {
                                c1 = bitmap.GetPixel(i + kc, j + kr);
                                rr += c1.R;
                                gg += c1.G;
                                bb += c1.B;
                            }
                        rr/=25;
                        gg/=25;
                        bb/=25;
                        if (rr > 255)
                            rr = 255;
                        if (gg > 255)
                            gg = 255;
                        if (bb > 255)
                            bb = 255;
                        if (rr < 0)
                            rr = 0;
                        if (gg < 0)
                            gg = 0;
                        if (bb < 0)
                            bb = 0;
                        for (kc = 0; kc < 5; kc++)
                            for (kr = 0; kr < 5; kr++)
                            {
                                Color cn =  Color.FromArgb(rr, gg, bb);
                                bitmap.SetPixel(i+kc, j+kr, cn);

                            }


                    }
                this.pictureBox1.Image = bitmap;
            }

        }

        private void Gray_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Color c = new Color();
                Color c1 = new Color();
                int yy;
                for (int i = 0; i < bitmap.Width ; i++)
                    for (int j = 0; j < bitmap.Height ; j++)
                    {
                        c1 = bitmap.GetPixel(i, j );
                        yy=(int)(0.31*c1.R+0.59*c1.G+0.11*c1.B);
                        if (yy > 255)
                            yy = 255;
                     Color cn = Color.FromArgb(yy, yy, yy);
                        bitmap.SetPixel(i , j , cn);



                    }
                this.pictureBox1.Image = bitmap;
            }
        }

        private void ColorSet_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
           // MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                pen = new Pen(MyDialog.Color, float.Parse(this.linesize.Text));
                brush = new SolidBrush(MyDialog.Color);
            }

        }

        private void Dash_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dash;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Solid;

        }

        private void DashDot_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.DashDot;
        }

        private void DashDotDot_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.DashDotDot;

        }

        private void Dot_Click(object sender, EventArgs e)
        {
            pen.DashStyle = DashStyle.Dot;

        }

        private void diamondAnchorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.StartCap = LineCap.DiamondAnchor;
        }

        private void arrowAnchorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.StartCap = LineCap.ArrowAnchor;
        }

        private void squareAnchor_Click(object sender, EventArgs e)
        {
            pen.StartCap = LineCap.SquareAnchor;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            pen.StartCap = LineCap.Triangle;
        }

        private void diamondAnchorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pen.EndCap = LineCap.DiamondAnchor;
        }

        private void ArrowAnchorEnd_Click(object sender, EventArgs e)
        {
            pen.EndCap = LineCap.DiamondAnchor;

        }

        private void roundAnchorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.EndCap = LineCap.RoundAnchor;

        }

        private void squareAnchorEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.EndCap = LineCap.SquareAnchor;

        }

        private void squareAnchorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.EndCap = LineCap.Triangle;
        }


    }
}
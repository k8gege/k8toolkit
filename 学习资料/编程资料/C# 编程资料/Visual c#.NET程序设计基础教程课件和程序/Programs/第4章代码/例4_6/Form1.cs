using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 例4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ofdSelectPicture_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                this.Text = "图像查看器 （" + ofdSelectPicture.FileName + "）";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

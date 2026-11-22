using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 例4_4
{
    public partial class Form1 : Form
    {
        Student zhangfei, liubei;

        public void UpdateForm()
        {
            label3.Text = zhangfei.Name + "有" + zhangfei.Score + "分";
            label4.Text = liubei.Name + "有" + liubei.Score + "分";
        }

        public Form1()
        {
            InitializeComponent();
            zhangfei = new Student();
            liubei = new Student();
            zhangfei.Name = "zhangfei";
            zhangfei.Score = 100;
            liubei.Name = "liubei";
            liubei.Score = 100;
            UpdateForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zhangfei.GiveScore(5);
            UpdateForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            liubei.TakeOffScore(3);
            UpdateForm();
        }
    }
}

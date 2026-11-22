using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtShenFenZheng.Text == "" || txtAccountID.Text == "" || txtName.Text == "" || txtPassWord1.Text == "" || txtPassWord2.Text == "")
            {
                MessageBox.Show("请把信息输入完整！");
                return;
            }
            if (txtPassWord1.Text != txtPassWord2.Text)
            {
                MessageBox.Show("输入的密码不一致！");
                return;
            }

            string _ShenFenZheng = txtShenFenZheng.Text;
            Program.IAccount = new SaverAccount(_ShenFenZheng, txtName.Text, txtAccountID.Text, txtPassWord1.Text);


           
                Login frm = new Login();
                frm.Show(this);
            
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label6.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ex6_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 连接本地的MS SQL Server服务器的Northwind数据库
            string connString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;";
            // 更新Employees表中ID号为5的员工姓名
            string sqlString = "select * from Employees";
            // 建立连接对象
            SqlConnection conn = new SqlConnection(connString);
            // 打开连接
            conn.Open();
            // 建立数据命令对象
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            // 执行命令，返回SqlDataReader对象
            SqlDataReader sdr = cmd.ExecuteReader();
            //清空ListBox1框中内容
            listBox1.Items.Clear();
            // 迭代结果集中的行，直到读完最后一条记录Read方法返回false
            while (sdr.Read())
            {
                // 用数字序号引用字段的增加到ListBox1框中
                listBox1.Items.Add(sdr[0]);
                listBox1.Items.Add(sdr[1]);
                listBox1.Items.Add(sdr[2]);
            }
            // 关闭DataReader
            sdr.Close();				
            // 关闭连接
            conn.Close();	
        }
    }
}
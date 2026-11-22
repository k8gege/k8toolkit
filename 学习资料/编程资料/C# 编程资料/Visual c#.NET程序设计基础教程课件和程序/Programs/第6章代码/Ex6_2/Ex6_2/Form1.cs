using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex6_2
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
            // 查询Employees表中ID号为5的员工姓名
            string sqlString = " select LastName,FirstName from Employees where EmployeeID = 5";
            // 建立连接对象
            SqlConnection conn = new SqlConnection(connString);                  	
            // 打开连接
            conn.Open();
            // 建立数据命令对象
            SqlCommand cmd = new SqlCommand(sqlString, conn);
            // 执行命令，返回影响的行数
            int rowsReturned = cmd.ExecuteNonQuery();
            MessageBox.Show(rowsReturned.ToString() + "记录已更新");
            // 关闭连接
            conn.Close();		                                              
        }
    }
}
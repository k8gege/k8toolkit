using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Exp6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection1 = new SqlConnection();
            sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True";

            try
            {
                sqlConnection1.Open();// 打开数据连接
               // 执行数据操作 
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.ToString());// 错误处理
            }
            finally
            {
                sqlConnection1.Close();// 关闭数据连接
        }

        }
    }
}
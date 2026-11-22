using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex6_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dataSet11);
        }

        private void btn_SaveUpdate_Click(object sender, EventArgs e)
        {
            this.BindingContext[dataSet11, "Employees"].EndCurrentEdit();
            sqlDataAdapter1.Update(dataSet11, "Employees");
        }

        private void btn_UptData_Click(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter1.UpdateCommand.CommandText = "Update Employees Set LastName = 'Benjanmin' where EmployeeID = 1";
                //连接数据库
                sqlConnection1.Open();
                // 执行操作
                sqlCommand1.ExecuteNonQuery();
                // 显示在dataGrid1控件中
                DataTable table1 = new DataTable();
                sqlDataAdapter1.Fill(table1);
                dataGrid1.DataSource = table1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlConnection1.Close();
            }
        }

    }
}
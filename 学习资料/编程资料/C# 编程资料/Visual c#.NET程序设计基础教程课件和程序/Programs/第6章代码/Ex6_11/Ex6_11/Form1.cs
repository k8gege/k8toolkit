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
    }
}
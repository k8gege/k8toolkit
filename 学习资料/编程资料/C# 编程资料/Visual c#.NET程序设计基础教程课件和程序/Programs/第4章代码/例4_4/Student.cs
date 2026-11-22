using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace 例4_4
{
    class Student
    {
        public string Name;
        public int Score;

        public int GiveScore(int amount)
        {
            if (amount > 0)
            {
                Score += amount;
                return amount;
            }
            else
            {
                MessageBox.Show("加分：" + amount + "不是一个合理值");
                return 0;
            }
        }

        public int TakeOffScore(int amount)
        {
            if (Score >= amount && amount > 0)
            {
                Score -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("减分：" + amount + "不是一个合理值");
                return 0;
            }
        }

    }
}

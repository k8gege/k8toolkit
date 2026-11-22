using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1
{
    public class SaverAccount:IBankAccount
    {
        private decimal balance;
        private string accountID;
        private string passWord;
        private string shenFenID;
        private string userName;

        public void PayIn(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                //Console.WriteLine("您的余额不足！取款失败！");
                throw new Exception("您的余额不足！取款失败！");
                return false;
            }
        }

        public string AccountID
        {
            get { return accountID; }
        }
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        public string ShenFenID
        {
            get { return shenFenID; }
        }

        public string UserName
        {
            get { return userName; }
        }

        public SaverAccount(string _shenFenID, string _userName, string _accountID, string _passWord)
        {
            this.shenFenID = _shenFenID;
            this.userName = _userName;
            this.accountID = _accountID;
            this.passWord = _passWord;
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public override string ToString()
        {
            //String.Format( "string { N [,M] [:formatstring]  }", arg1)
            //N:从0开始的整数;
            //M: 是一个可以选择的整数,表示格式化后的参数所占的宽度
            //formatstring:表示要格式化的格式;( C : 表示货币形式 )
            return String.Format("您的余额为:{0,6:C}", balance);
        }

    }
}

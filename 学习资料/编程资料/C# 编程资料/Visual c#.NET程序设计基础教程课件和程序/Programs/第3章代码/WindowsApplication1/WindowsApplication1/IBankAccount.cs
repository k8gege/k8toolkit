using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1
{
    public interface IBankAccount
    {
        void PayIn(decimal amount);

        bool Withdraw(decimal amount);

        string AccountID
        {
            get;
        }
        string PassWord
        {
            get;
            set;
        }

        string ShenFenID
        {
            get;
        }

        string UserName
        {
            get;
        }

        decimal Balance
        {
            get;
        }
    }
}

using System;

namespace IBankAccount
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	public interface IBankAccount
	{
		void PayIn(decimal amount);
		bool Withdraw(decimal amount);
		decimal Balance
		{
			get;
		}
	}
	public class SaverAccount : IBankAccount
	{
		private decimal balance;
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
			Console.WriteLine("Withdrawal attempt failed.");
			return false;
		}
		public decimal Balance
		{
			get
			{
				return balance;
			}
		}
		public override string ToString()
		{
			return String.Format("Venus Bank Saver: Balance = {0,6:C}", balance);
		}
	}

	class Class1
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: 在此处添加代码以启动应用程序
			//
			IBankAccount venusAccount = new SaverAccount();
			venusAccount.PayIn(200);
			venusAccount.Withdraw(100);
			Console.WriteLine(venusAccount.ToString());  

		}
	}
}

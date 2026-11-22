using System;

namespace MainEntryPoint
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
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
			Money cash1 = new Money();
			cash1.Amount = 40M;
			Console.WriteLine("cash1.ToString() returns: " + cash1.ToString());

		}
	}
	class Money
	{
		private decimal amount;
		public decimal Amount
		{
			get
			{
				return amount;
			}
			set
			{
				amount = value;
			}
		}
		public override string ToString()
		{
			return "$" + Amount.ToString();
		}
	}

}

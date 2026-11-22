using System;

namespace _0verflow
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
			try
			{
				checked
				{
					int Integer1;
					int Integer2;
					int Sum;
					Integer1 = 2000000000;
					Integer2 = 2000000000;
					Sum = Integer1 + Integer2;
				}
			}
			catch(OverflowException)
			{
				Console.WriteLine("A mathematical operation caused an overflow.");
			}
		}
	}
}

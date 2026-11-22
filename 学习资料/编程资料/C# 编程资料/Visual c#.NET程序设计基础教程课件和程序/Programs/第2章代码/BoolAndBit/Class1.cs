using System;

namespace BoolAndBit
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
			Console.WriteLine("Enter an integer:");
			int myInt=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Integer less than 10?{0}",myInt<10);
			Console.WriteLine("Integer between 0 and 5?{0}",(0<=myInt)&&(myInt<=5));
			Console.WriteLine("Bitwise AND of Integer and 10 = {0}",myInt&10);		

		}
	}
}

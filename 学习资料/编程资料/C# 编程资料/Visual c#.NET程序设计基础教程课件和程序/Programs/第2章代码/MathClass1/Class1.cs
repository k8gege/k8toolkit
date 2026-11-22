using System;

namespace MathClass1
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
			double Num1,Num2;
			Console.WriteLine("Please input two numbers:");
			Num1=Convert.ToDouble(Console.ReadLine());
			Num2=Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("{0} + {1} = {2}",Num1,Num2, Num1+Num2);
			Console.WriteLine("{0} - {1} = {2}",
				Num1, Num2, Num1-Num2);
			Console.WriteLine("{0} * {1} = {2}",
				Num1, Num2, Num1*Num2);
			Console.WriteLine("{0} / {1} = {2}",
				Num1, Num2, Num1/Num2);
			Console.WriteLine("{0} % {1} = {2}",
				Num1, Num2, Num1%Num2);

		}
	}
}

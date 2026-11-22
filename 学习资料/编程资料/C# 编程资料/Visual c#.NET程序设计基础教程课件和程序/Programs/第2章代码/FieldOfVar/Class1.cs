using System;

namespace FieldOfVar
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
		static void Write()
		{
			string myString = "String defined in Write()";
			Console.WriteLine("Now in Write()");
			Console.WriteLine("myString = {0}", myString);
		}

		static void Main(string[] args)
		{
			//
			// TODO: 在此处添加代码以启动应用程序
			//
			string myString = "String defined in Main()";
			Write();
			Console.WriteLine("\nNow in Main()");
			Console.WriteLine("myString = {0}", myString);

		}
	}
}

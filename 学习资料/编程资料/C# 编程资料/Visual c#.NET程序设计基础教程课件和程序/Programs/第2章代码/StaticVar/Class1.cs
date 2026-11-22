using System;

namespace StaticVar
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	class Class1
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		//[STAThread]

		static string myString;
		static void Write()
		{
			string myString = "String defined in Write()";
			Console.WriteLine("Now in Write()");
			Console.WriteLine("Local myString = {0}", myString);
			Console.WriteLine("Global myString = {0}", Class1.myString);
		}

		static void Main(string[] args)
		{
			//
			// TODO: 在此处添加代码以启动应用程序
			//
			string myString = "String defined in Main()";
			Class1.myString = "Global string";
			Write();
			Console.WriteLine("\nNow in Main()");
			Console.WriteLine("Local myString = {0}", myString);
			Console.WriteLine("Global myString = {0}", Class1.myString);

		}
	}
}

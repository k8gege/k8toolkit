using System;

namespace StringExample
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
			string s1 = "a string";
			string s2 = s1;
			Console.WriteLine("s1 is " + s1);
			Console.WriteLine("s2 is " + s2);
			s1 = "another string";
			Console.WriteLine("s1 is now " + s1);
			Console.WriteLine("s2 is now " + s2);

		}
	}
}

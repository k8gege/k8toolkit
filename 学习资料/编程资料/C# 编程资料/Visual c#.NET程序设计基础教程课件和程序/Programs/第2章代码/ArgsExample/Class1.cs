using System;

namespace ArgsExample
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
		 public static int Main(string[] args)
		{
			//
			// TODO: 在此处添加代码以启动应用程序
			//
			for (int i = 0; i < args.Length; i++)
			{
				Console.WriteLine(args[i]);
			}
            Console.Read();
			return 0;

		}
	}
}

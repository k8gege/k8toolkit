using System;

namespace ArrayDemo
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
			string[] friendNames = {"Robert Barwell","Mike Parry","Jeremy Beacock"};
			int i;
			Console.WriteLine("Here are {0} of my friends:",friendNames.Length);
			for(i=0;i<friendNames.Length;i++)
			{
				Console.WriteLine(friendNames[i]);
			}			

		}
	}
}

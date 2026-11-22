using System;

namespace IndexOutOfRange
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
				int [] IntegerArray = new int[5];
				IntegerArray[10] = 123;
			}
			catch(IndexOutOfRangeException)
			{
				Console.WriteLine("An invald element index access was attempted.");
			}

		}
	}
}

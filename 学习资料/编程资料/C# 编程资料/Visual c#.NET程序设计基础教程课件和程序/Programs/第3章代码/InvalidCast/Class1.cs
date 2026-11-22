using System;

namespace InvalidCast
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
				Class1 MyObject = new Class1();
				IFormattable Formattable;
				Formattable = (IFormattable)MyObject;
			}
			catch(InvalidCastException)
			{
				Console.WriteLine("MyObject does not implement the IFormattable interface");
			}

		}
	}
}

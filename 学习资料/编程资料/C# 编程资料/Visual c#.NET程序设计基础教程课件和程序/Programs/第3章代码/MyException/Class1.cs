using System;

namespace MyException
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	class MyException: ApplicationException
	{
		public MyException():base("This is my exception message.")
		{
		}
	}

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
				MyObject.ThrowException();
			}
			catch(MyException CaughtException)
			{
				Console.WriteLine(CaughtException.Message);
			}
		}
		public void ThrowException()
		{
			throw new MyException();
		}


		
	}
}

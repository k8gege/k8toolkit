using System;

namespace Enum
{
	/// <summary>
	/// Class1 的摘要说明。
	/// </summary>
	enum orientation:byte
	{
		north = 1,
		south = 2,
		east = 3,
		west = 4
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
			byte directionByte;
			string directionString;
			orientation myDirection = orientation.north;
			Console.WriteLine("myDirection = {0}",myDirection);
			directionByte = (byte)myDirection;
			directionString = Convert.ToString(myDirection);
			Console.WriteLine("byte equivalent = {0}",directionByte);
			Console.WriteLine("string equivalent = {0}",directionString);	
 
		}
	}
}

using System;

namespace ConvertTo
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
			short shortResult,shortVal = 4;
			int integerVal = 67;
			long longResult;
			float floatVal = 10.5F;
			double doubleResult,doubleVal = 99.999;
			string stringResult, stringVal = "17";
			bool boolVal = true;
			doubleResult = floatVal * shortVal;
			Console.WriteLine("Inplicit:{0} * {1} -> {2}",floatVal,shortVal,doubleResult);
			shortResult = (short)floatVal;
			Console.WriteLine("Explicit: {0}->{1}",floatVal,shortResult);
			stringResult= Convert.ToString(boolVal) + Convert.ToString(doubleVal);
			Console.WriteLine("Explicit:\"{0}\"+\"{1}\"->{2}",
				boolVal,doubleVal,stringResult);
			longResult = integerVal + Convert.ToInt64(stringVal);
			Console.WriteLine("Mixed:{0}+{1} ->{2}",integerVal,stringVal,longResult);

		}
	}
}

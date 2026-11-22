using System;

namespace FunctionWithParams
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
		static int SumVals(params int[] vals)
		{
			int sum = 0;
			foreach (int val in vals)
			{
				sum += val;
			}
			return sum;
		}

		static void Main(string[] args)
		{
			//
			// TODO: 在此处添加代码以启动应用程序
			//
			int sum = SumVals(1, 5, 2, 9, 8);
			Console.WriteLine("Summed Values = {0}", sum);
			Console.ReadLine();

		}
	}
}

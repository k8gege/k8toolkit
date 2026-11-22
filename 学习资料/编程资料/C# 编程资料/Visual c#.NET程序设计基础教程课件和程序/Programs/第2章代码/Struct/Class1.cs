using System;

namespace Struct
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
	　
	struct route
	{
		public orientation direction;
		public double distance;
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
				route myRoute;
				int myDirection = -1;
				double myDistance;
				Console.WriteLine("1)North\n2)South\n3)East\n4)West");
				do
				{
					Console.WriteLine("Select a direction:");
					myDirection = Convert.ToInt32(Console.ReadLine());
				}while((myDirection<1)||(myDirection>4));
				Console.WriteLine("Input a distance:");
				myDistance = Convert.ToDouble(Console.ReadLine());
				myRoute.direction = (orientation)myDirection;
				myRoute.distance = myDistance;
				Console.WriteLine("myRoute specifies a direction of {0} and a"+"distance of {1}",myRoute.direction,myRoute.distance);	

			}
		}
	}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			string temp = "7.0";
			int x = 7;
			Console.WriteLine("Hello C# 7.0");
			Console.WriteLine(string.Format("这是C#{0}的语法", "6.0"));
			Console.WriteLine($"这是C#{temp}的语法");
			Console.WriteLine($"这是C#{x}的语法");

			var user = getUserInfo();
			Console.WriteLine($"用户编码:{user.Item1}");
			Console.WriteLine($"用户姓名:{user.Item2}");
			Console.WriteLine($"创建时间:{user.Item3}");


			var user2 = getUserInfoNew();
			Console.WriteLine($"用户编码:{user2.UserId}");
			Console.WriteLine($"用户姓名:{user2.Name}");
			Console.WriteLine($"创建时间:{user2.CreateTime}");


			var user3 = getUserInfoNew2();
			Console.WriteLine($"用户编码:{user3.Item1}");
			Console.WriteLine($"用户姓名:{user3.Item2}");
			Console.WriteLine($"创建时间:{user3.Item3}");


			Console.WriteLine($"getTryParse:{getTryParse()}");

			Console.ReadKey();
		}

		private static int getTryParse()
		{
			string temp = "7s";
			if (int.TryParse(temp, out int i))
			{
				return i;
			}
			else
			{
				return 0;
			}
		}

		
		/// <summary>
		/// 7.0之前的用法
		/// </summary>
		/// <returns></returns>
		private static Tuple<int, string, DateTime> getUserInfo()
		{
			var result = new Tuple<int, string, DateTime>(1,"小宝",DateTime.Now);
			return result;
		}

		private static (int UserId, string Name, DateTime CreateTime) getUserInfoNew()
		{
			return (2, "郑少宝", DateTime.Now);
		}

		private static (int, string, DateTime) getUserInfoNew2()
		{
			return (3, "阿扎西", DateTime.Now);
		}
	}
}

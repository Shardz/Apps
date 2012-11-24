using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
	class Program
	{
		static void Main(string[] args)
		{
			string s;
			int x;
			float y;
			DateTime dt;
			s = Console.ReadLine();
			if (int.TryParse(s, out x))
			{
				Console.WriteLine("int");
			}
			else
				if (float.TryParse(s, out y))
				{
					Console.WriteLine("float");
				}
				else
					if (DateTime.TryParse(s, out dt))
					{
						Console.WriteLine("Date");
					}
					else
						Console.WriteLine("Text");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SPOJ1
{
	static public class Prime
	{
		static public void isPrime(int l1, int l2)
		{
			bool[] notPrime = new bool[l2-l1+1];
			int sqrrt = (int)Math.Sqrt(l2);
			try
			{
				for (int i = 0; i < l2 - l1 + 1; i++)
					notPrime[i] = false;
				for (int i = 2; i <= sqrrt; i++)
				{
					int less = l1 / i;
					less *= i;
					if (!notPrime[i])
					{
						for (int j = less; j <= l2; j += i)
						{
							if (j != i && j >= l1)
							{
								notPrime[j - l1] = true;
							}
						}
					}
				}
				for (int i = 0; i < l2-l1+1; i++)
				{
					if (!notPrime[i])
					{
						Console.WriteLine(l1+i);
					}
				}
			}
			catch (OutOfMemoryException)
			{
				GC.Collect();
				return;
			}
		}
		class Program
		{
			static void Main(string[] args)
			{
				int lines = int.Parse(Console.ReadLine());
				int[,] Limits = new int[lines, 2];
				var pattern = @"(\d+) (\d+)";
				int l = 0;
				while (l < lines)
				{
					var match = Regex.Match(Console.ReadLine(), pattern);
					Limits[l, 0] = int.Parse(match.Groups[1].Value);
					Limits[l, 1] = int.Parse(match.Groups[2].Value);
					l++;
				}
				for (int i = 0; i < lines; i++)
				{
					Prime.isPrime(Limits[i, 0], Limits[i, 1]);
					Console.WriteLine();
				}
			}
		}
	}
}

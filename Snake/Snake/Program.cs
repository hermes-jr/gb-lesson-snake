using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int iter = 0; iter < 10; iter++)
			{
				Point pnt = new Point(iter, iter, '*');
				pnt.DrawChar();
			}

			List<int> numList = new List<int>();
			numList.Add(77);
			numList.Add(10);
			numList.Add(34);

			int cc = numList[1]; // 10

			Console.ReadLine();
		}
	}
}

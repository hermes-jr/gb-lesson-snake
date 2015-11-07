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

			List<Point> pnList = new List<Point>();
			pnList.Add(new Point(20, 20, 'x'));
			pnList.Add(new Point(10, 15, 'y'));
			pnList.Add(new Point(15, 10, 'z'));

			foreach (Point pnt in pnList)
			{
				pnt.DrawChar();
			}
			Console.ReadLine();
		}
	}
}

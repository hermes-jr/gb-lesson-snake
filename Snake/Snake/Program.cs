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
			int winW = Console.WindowWidth - 1;
			int winH = Console.WindowHeight - 1;

			for (int iter = 0; iter < 10; iter++)
			{
				Point pnt = new Point(iter, iter, '*');
				pnt.DrawChar();
			}

			HorizontalLine hline1 = new HorizontalLine(0, winW, 0, '#');
			hline1.DrawLine();
			HorizontalLine hline2 = new HorizontalLine(0, winW, winH, '#');
			hline2.DrawLine();

			VerticalLine vline1 = new VerticalLine(0, winH, 0, '#');
			vline1.DrawLine();
			VerticalLine vline2 = new VerticalLine(0
				, winH, winW, '#');
			vline2.DrawLine();

			Console.ReadLine();
		}
	}
}

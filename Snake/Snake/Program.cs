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

			HorizontalLine hline1 = new HorizontalLine(2, 20, 10, '#');
			hline1.DrawLine();
			HorizontalLine hline2 = new HorizontalLine(2, 20, 20, '#');
			hline2.DrawLine();

			VerticalLine vline1 = new VerticalLine(10, 20, 2, '#');
			vline1.DrawLine();
			VerticalLine vline2 = new VerticalLine(10, 20, 20, '#');
			vline2.DrawLine();

			Console.ReadLine();
		}
	}
}

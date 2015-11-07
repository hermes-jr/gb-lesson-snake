using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	enum Direction
	{
		LEFT,
		UP,
		DOWN,
		RIGHT
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Border
			int winW = Console.WindowWidth - 1;
			int winH = Console.WindowHeight - 1;

			HorizontalLine hline1 = new HorizontalLine(0, winW, 0, '#');
			hline1.Draw();
			HorizontalLine hline2 = new HorizontalLine(0, winW, winH, '#');
			hline2.Draw();

			VerticalLine vline1 = new VerticalLine(0, winH, 0, '#');
			vline1.Draw();
			VerticalLine vline2 = new VerticalLine(0, winH, winW, '#');
			vline2.Draw();

			Point tl = new Point(10, 10, '*');
			Snake snake = new Snake(tl, 20, Direction.RIGHT);
			snake.Draw();
			snake.Move();

			// Don't close now
			Console.ReadLine();
		}
	}
}

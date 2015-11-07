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
				Point pnt = new Point();
				pnt.x = iter;
				pnt.y = iter;
				pnt.sym = '*';
				DrawChar(pnt);
			}
			
			Console.ReadLine();
		}

		static void DrawChar(int x, int y, char sym)
		{
			Console.SetCursorPosition(x, y);
			Console.Write(sym);
		}
		
		static void DrawChar(Point p)
		{
			Console.SetCursorPosition(p.x, p.y);
			Console.Write(p.sym);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure
	{
		public Snake(Point tail, int length, Direction direction) {
			plist = new List<Point>();
			for (int iter = 0; iter < length; iter++)
			{
				Point p = new Point(tail);
				p.Move(iter, direction);
				plist.Add(p);
			}
		}
	}
}

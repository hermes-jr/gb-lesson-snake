using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Line : Shape
	{
		public Line(Direction direction, int a, int b, int c, char sym)
		{
			this.plist = new List<Point>();
			for (int iter = a; iter <= b; iter++)
			{
				if (direction == Direction.RIGHT || direction == Direction.LEFT)
				{
					// Horizontal line
					this.plist.Add(new Point(iter, c, sym));
				}
				else if (direction == Direction.UP || direction == Direction.DOWN)
				{
					// Vertical line
					this.plist.Add(new Point(c, iter, sym));
				}
			}
		}
	}
}

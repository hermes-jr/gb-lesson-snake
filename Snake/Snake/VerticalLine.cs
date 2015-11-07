using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figure
	{
		public VerticalLine(int top, int bottom, int x, char sym)
		{
			this.plist = new List<Point>();
			for (int iter = top; iter <= bottom; iter++)
			{
				this.plist.Add(new Point(x, iter, sym));
			}
		}
	}
}

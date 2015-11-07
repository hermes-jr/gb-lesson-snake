using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine : Figure
	{
		public HorizontalLine(int _left, int _right, int _y, char _sym)
		{
			this.plist = new List<Point>();
			for (int iter = _left; iter <= _right; iter++)
			{
				this.plist.Add(new Point(iter, _y, _sym));
			}
		}
	}
}

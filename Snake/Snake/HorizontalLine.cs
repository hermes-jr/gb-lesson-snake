using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine
	{
		List<Point> plist;

		public HorizontalLine(int _left, int _right, int _y, char _sym)
		{
			this.plist = new List<Point>();
			for (int iter = _left; iter <= _right; iter++)
			{
				this.plist.Add(new Point(iter, _y, _sym));
			}
		}

		public void DrawLine()
		{
			foreach (Point p in this.plist)
			{
				p.DrawChar();
			}
		}
	}
}

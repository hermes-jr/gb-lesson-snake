using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class HorizontalLine : Figure
	{
		public HorizontalLine(int left, int right, int y, char sym)
		{
			this.plist = new List<Point>();
			for (int iter = left; iter <= right; iter++)
			{
				this.plist.Add(new Point(iter, y, sym));
			}
		}
	}
}

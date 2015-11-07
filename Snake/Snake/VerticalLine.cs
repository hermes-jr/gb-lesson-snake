﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figure
	{
		public VerticalLine(int _top, int _bottom, int _x, char _sym)
		{
			this.plist = new List<Point>();
			for (int iter = _top; iter <= _bottom; iter++)
			{
				this.plist.Add(new Point(_x, iter, _sym));
			}
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Shape
	{
		protected 
			List<Point> plist;

		public void Draw()
		{
			foreach (Point p in this.plist)
			{
				p.Draw();
			}
		}
	}
}

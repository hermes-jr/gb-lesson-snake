﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
		public int x;
		public int y;
		public char sym;

		public void DrawChar()
		{
			Console.SetCursorPosition(this.x, this.y);
			Console.Write(this.sym);
		}
	}
}

﻿using System;
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
				Point pnt = new Point(iter, iter, '*');
				pnt.DrawChar();
			}

			HorizontalLine hline1 = new HorizontalLine(10, 20, 4, '#');
			hline1.DrawLine();

			Console.ReadLine();
		}
	}
}

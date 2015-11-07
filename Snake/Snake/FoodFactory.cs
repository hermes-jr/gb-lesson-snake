using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodFactory
	{
		int winH;
		int winW;
		char sym;

		Random rand = new Random();

		public FoodFactory(int winH, int winW, char sym)
		{
			this.winH = winH;
			this.winW = winW;
			this.sym = sym;
		}

		public Point createFood()
		{
			Point foodPoint = new Point(rand.Next(2, winW - 2), rand.Next(2, winH - 2), sym);
			return foodPoint;
		}
	}
}

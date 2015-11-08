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

		public Point createFood(Snake avoidsnake)
		{
			Point foodPoint;
			do
			{
				foodPoint = new Point(rand.Next(4, winW - 2), rand.Next(4, winH - 2), sym);
			}
			while (avoidsnake.IsHit(foodPoint));
			return foodPoint;
		}
	}
}

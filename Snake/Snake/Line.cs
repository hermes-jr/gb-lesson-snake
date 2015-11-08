using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Line : Shape
	{
		public Line(Direction direction, int a, int b, int c, char sym)
		{
			this.plist = new List<Point>();
			for (int iter = a; iter <= b; iter++)
			{
				if (direction == Direction.RIGHT || direction == Direction.LEFT)
				{
					// Horizontal line
					this.plist.Add(new Point(iter, c, sym));
				}
				else if (direction == Direction.UP || direction == Direction.DOWN)
				{
					// Vertical line
					this.plist.Add(new Point(c, iter, sym));
				}
			}
		}
	}

	class Walls
	{
		List<Shape> wallList;

		public Walls(int winW, int winH)
		{
			this.wallList = new List<Shape>();

			Line hline1 = new Line(Direction.RIGHT, 0, winW, 0, '#');
			Line hline2 = new Line(Direction.RIGHT, 0, winW, winH, '#');
			Line vline1 = new Line(Direction.DOWN, 0, winH, 0, '#');
			Line vline2 = new Line(Direction.DOWN, 0, winH, winW, '#');
			this.wallList.Add(hline1);
			this.wallList.Add(hline2);
			this.wallList.Add(vline1);
			this.wallList.Add(vline2);
		}

		internal bool IsHit(Shape shape)
		{
			foreach (var wall in this.wallList)
			{
				if(wall.IsHit(shape))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (var wall in this.wallList)
			{
				wall.Draw();
			}
		}
	}
}

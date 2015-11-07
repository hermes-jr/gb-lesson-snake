using System;
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

		public Point()
		{ }

		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p)
		{
			this.x = p.x;
			this.y = p.y;
			this.sym = p.sym;
		}
		
		public void Draw()
		{
			Console.SetCursorPosition(this.x, this.y);
			Console.Write(this.sym);
		}

		public void Clear()
		{
			this.sym = ' ';
			this.Draw();
		}

		public void Move(int offset, Direction direction)
		{
			switch(direction)
			{
				case Direction.UP:
					this.y -= offset;
					break;
				case Direction.DOWN:
					this.y += offset;
					break;
				case Direction.LEFT:
					this.x -= offset;
					break;
				case Direction.RIGHT:
					this.x += offset;
					break;
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figure
	{
		Direction direction;

		public Snake(Point tail, int length, Direction direction) {
			this.direction = direction;

			plist = new List<Point>();
			for (int iter = 0; iter < length; iter++)
			{
				Point p = new Point(tail);
				p.Move(iter, direction);
				plist.Add(p);
			}
		}

		internal void Move()
		{
			Point tail = this.plist.First();
			plist.Remove(tail);
			Point head = this.GetNextPoint();
			plist.Add(head);

			tail.Clear();
			head.Draw();
		}

		public Point GetNextPoint()
		{
			Point head = this.plist.Last();
			Point next = new Point(head);
			next.Move(1, this.direction);
			return next;
		}

		public void HandleKey(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
				this.direction = Direction.LEFT;
			else if (key == ConsoleKey.RightArrow)
				this.direction = Direction.RIGHT;
			else if (key == ConsoleKey.DownArrow)
				this.direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow)
				this.direction = Direction.UP;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Shape
	{
		Direction direction;
		public int length;

		public Snake(Point tail, int length, Direction direction) {
			this.direction = direction;
			this.length = length;

			plist = new List<Point>();
			for (int iter = 0; iter < this.length; iter++)
			{
				Point p = new Point(tail);
				p.Move(iter, direction);
				plist.Add(p);
			}
		}

		internal void Move()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;

			Point tail = this.plist.First();
			plist.Remove(tail);
			Point head = this.GetNextPoint();
			plist.Add(head);

			tail.Clear();
			head.Draw();

			Console.ResetColor();
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

		public bool Eat(Point food)
		{
			Point head = this.GetNextPoint();
			if (head.Hits(food))
			{
				food.sym = head.sym;
				this.plist.Add(food);
				this.length++;
				return true;
			}
			else
			{
				return false;
			}
		}

		internal bool IsHitTail()
		{
			return false;
		}
	}
}

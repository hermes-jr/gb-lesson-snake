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
		int length;

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

		private void Grow()
		{
			this.length++;
			Point newhead = new Point(plist.Last());
			newhead.Move(1, this.direction);
			plist.Add(newhead);
		}

		public bool Eat(Point food)
		{
			if(this.plist.Last().x ==  food.x && this.plist.Last().y == food.y)
			{
				this.Grow();
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

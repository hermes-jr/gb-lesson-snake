using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Shape
	{
		protected List<Point> plist;

		public virtual void Draw()
		{
			foreach (Point p in this.plist)
			{
				p.Draw();
			}
		}

		internal bool IsHit(Shape shape)
		{
			foreach (var p in this.plist)
			{
				if (shape.IsHit(p))
				{
					return true;
				}
			}
			return false;
		}

		internal bool IsHit(Point point)
		{
			foreach (var p in this.plist)
			{
				if (point.Hits(p))
				{
					return true;
				}
			}
			return false;
		}
	}
}

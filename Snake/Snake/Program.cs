using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
	enum Direction
	{
		LEFT,
		UP,
		DOWN,
		RIGHT
	}

	class Program
	{
		static void Main(string[] args)
		{
			// Border
			int winW = Console.WindowWidth - 1;
			int winH = Console.WindowHeight - 1;

			Walls walls = new Walls(winW, winH);
			walls.Draw();

			// Snake
			Point tl = new Point(10, 10, '*');
			Snake snake = new Snake(tl, 4, Direction.RIGHT);

			// Food
			FoodFactory foodfactory = new FoodFactory(winH, winW, '$');
			Point food = foodfactory.createFood();
			Console.ForegroundColor = ConsoleColor.Yellow;
			food.Draw();
			Console.ResetColor();

			// Infinite loop
			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					// Snake dies
					Console.SetCursorPosition(2, 2);
					Console.Write("Snake died...");
					break;
				}
				if (snake.Eat(food))
				{
					food = foodfactory.createFood();
					Console.ForegroundColor = ConsoleColor.Yellow;
					food.Draw();
					Console.ResetColor();
				}
				else
				{
					snake.Move();
				}
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
					if (key.Key == ConsoleKey.Q)
						break; // Get the hell out of this infinite loop
				}
				Thread.Sleep(50); // Control FPS here
				Console.SetCursorPosition(2, 2);
				Console.Write("Length: " + snake.length);
			}

			Console.SetCursorPosition(2, 3);
			Console.Write("Thank you for playing. Bye!");
			Thread.Sleep(1000);
		}
	}
}

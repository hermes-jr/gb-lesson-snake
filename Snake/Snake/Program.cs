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
			// Dimensions
			//int winW = Console.WindowWidth - 1;
			//int winH = Console.WindowHeight - 1;
			int winH = 20;
			int winW = 34;

			ushort level = 1;

			// Border
			Walls walls = new Walls(winW, winH);
			walls.Draw();

			// Snake
			Point tl = new Point(10, 10, '*');
			Snake snake = new Snake(tl, 3, Direction.RIGHT);

			// Food
			FoodFactory foodfactory = new FoodFactory(winH, winW, '$');
			Point food = foodfactory.createFood(snake);
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
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Snake collapsed...");
					break;
				}
				if (snake.Eat(food))
				{
					food = foodfactory.createFood(snake);
					Console.ForegroundColor = ConsoleColor.Yellow;
					food.Draw();
					Console.ResetColor();
					// level up every 5 feeds and level cap is 40 (121 - level * 3 must be > 0)
					if (snake.length % 5 == 0 && level < 40)
						level++;
				}
				else
				{
					snake.Move();
				}
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey(true);
					snake.HandleKey(key.Key);
					if (key.Key == ConsoleKey.Q)
						break; // Get the hell out of this infinite loop
				}

				// Thread.Sleep(80); // Control FPS here
				Thread.Sleep(121 - level * 3);

				Console.SetCursorPosition(2, 1);
				Console.Write("Length: " + snake.length + " Level: " + level);
			}

			// Print banner and wait for Enter key
			Console.ForegroundColor = ConsoleColor.Yellow;
			int endplaneX = Math.Abs((winW / 2) - 15);
			Console.SetCursorPosition(endplaneX, 7);
			Console.Write("===============================");
			Console.SetCursorPosition(endplaneX, 8);
			Console.Write("| Thank you for playing. Bye! |");
			Console.SetCursorPosition(endplaneX, 9);
			Console.Write("|   Press Enter key to quit.  |");
			Console.SetCursorPosition(endplaneX, 10);
			Console.Write("===============================");
			while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
		}
	}
}

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
			int winW = Console.WindowWidth - 1;
			int winH = Console.WindowHeight - 1;
			//winH = 40;
			//winW = 60;

			// Border
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
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("Snake collapsed...");
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
					ConsoleKeyInfo key = Console.ReadKey(true);
					snake.HandleKey(key.Key);
					if (key.Key == ConsoleKey.Q)
						break; // Get the hell out of this infinite loop
				}
				Thread.Sleep(80); // Control FPS here
				Console.SetCursorPosition(2, 2);
				Console.Write("Length: " + snake.length);
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

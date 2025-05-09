using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys
{
    class Program
    {
        static void Main(string[] args)
        {
			int x = Console.CursorLeft;
			int y = Console.CursorTop;
			Console.ForegroundColor = ConsoleColor.DarkBlue;
			Console.BackgroundColor = ConsoleColor.Yellow;
			char cursorSymbol = '$';

			ConsoleKeyInfo keyInfo;

			do
			{
				Console.SetCursorPosition(x, y);
				Console.Write("$");

				if (Console.KeyAvailable)
				{
					keyInfo = Console.ReadKey(true);
				}
				else
				{
					keyInfo = new ConsoleKeyInfo();
				}

				switch (keyInfo.Key)
				{
					case ConsoleKey.W:
					case ConsoleKey.UpArrow:
						y--;
						break;
					case ConsoleKey.S:
					case ConsoleKey.DownArrow:
						y++;
						break;
					case ConsoleKey.A:
					case ConsoleKey.LeftArrow:
						x--;
						break;
					case ConsoleKey.D:
					case ConsoleKey.RightArrow:
						x++;
						break;
					case ConsoleKey.Escape:
						break;
				}

				x = Math.Max(0, Math.Min(x, Console.WindowWidth - 1));
				y = Math.Max(0, Math.Min(y, Console.WindowHeight - 1));

				Console.SetCursorPosition(x, y);
				Console.Write(cursorSymbol);

			} while (keyInfo.Key != ConsoleKey.Escape);

			Console.ResetColor();
			Console.Clear();

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(" :( Game over!!!");
			Console.ResetColor();
		}
    }
}

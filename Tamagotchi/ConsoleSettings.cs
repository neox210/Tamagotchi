using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    static class ConsoleSettings
    {
        public static void ConsoleSet()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WindowHeight = 31;
            Console.WindowWidth = 90;
            Console.Title = "TAMAGOTCHI GAME @ ŁUKASZ BRZEZIŃSKI";
            Console.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tamagotchi
{
    class Death
    {
        public static void DeadSkull()
        {
            var writeMenu = new List<string>();

            string path = @"Death.txt";
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    writeMenu.Add(reader.ReadLine());
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var line in writeMenu)
            {
                Console.WriteLine(line);
            }
            Console.ForegroundColor = ConsoleColor.Black;
        }

    }
}

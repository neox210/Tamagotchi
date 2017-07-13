using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tamagotchi
{
    static class DogScreenASCII
    {
        
        public static void DisplayDogMenuFrame()
        {
            var writeMenu = new List<string>();

            string path = @".\DogArt\DogMain.txt";
            using (var reader = new StreamReader(path))
            {
                while(!reader.EndOfStream)
                {
                    writeMenu.Add(reader.ReadLine());
                }
            }

            foreach(var line in writeMenu)
            {
                Console.WriteLine(line);
            }

        }

        public static void DisplayDogFace(int health)
        {
            var writeMenu = new List<string>();

            if (health<30)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (health < 60)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            string path = @".\DogArt\DogFace.txt";
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    writeMenu.Add(reader.ReadLine());
                }
            }
            int i = 1;
            foreach (var line in writeMenu)
            {
                Console.SetCursorPosition(2, i);
                Console.WriteLine(line);
                i++;
            }
            Console.ForegroundColor = ConsoleColor.Black;

        }

        public static void DisplayDogHealth(int health)
        {
            var writeMenu = new List<string>();

            string path = @".\DogArt\DogHealth.txt";
            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    writeMenu.Add(reader.ReadLine());
                }
            }
         
            for (int i = 26, j = 0; j < (health / 15) + 1; j++)
            {
                Console.SetCursorPosition(57, i);
                Console.WriteLine(writeMenu[j]);
                i--;
            }
        }

        public static void DisplayDogEnergy(int energy)
        {
            Console.SetCursorPosition(4, 26);
            Console.WriteLine("ENERGY");

            
                Console.BackgroundColor = ConsoleColor.Yellow;

            if (energy!=0)
            {
                for (int i = 27, j = 0; j < (energy / 11) + 1; j++)
                {
                    Console.SetCursorPosition(2 + j, i);
                    Console.Write(" ");
                }
            }
            else
            {
                Console.SetCursorPosition(2, 27);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("NO ENERGY");
                
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void DisplayDogHunger(int hunger)
        {
            Console.SetCursorPosition(16, 26);
            Console.WriteLine("HUNGER");

            
            if (hunger >= 40)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (hunger > 60)
            {
                Console.BackgroundColor = ConsoleColor.Red;

            }
            if (hunger < 40)
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }

            if (hunger>100)
            {
                hunger = 100;
            }

                for (int i = 27, j = 0; j < (hunger / 11) + 1; j++)
                {
                    Console.SetCursorPosition(14 + j, i);
                    Console.Write(" ");
                }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
        }

        public static void DisplayDogHappiness(int happy)
        {
            Console.SetCursorPosition(27, 26);
            Console.WriteLine("HAPPINESS");

            if (happy >= 60)
            {
                Console.BackgroundColor = ConsoleColor.Green;

            }
            if (happy < 60)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            if (happy <= 45)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (happy <= 30)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }

            if (!(happy <= 0))
            {
                for (int i = 27, j = 0; j < (happy / 11) + 1; j++)
                {
                    Console.SetCursorPosition(26 + j, i);
                    Console.Write(" ");
                }
            }
            else
            {
                
                    Console.SetCursorPosition(26, 27);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" VERY SAD ");
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void DisplayDogHygiene(int hygiene)
        {
            Console.SetCursorPosition(39, 26);
            Console.WriteLine("HYGIENE");

            if (hygiene >= 60)
            {
                Console.BackgroundColor = ConsoleColor.Green;

            }
            if (hygiene < 60)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (hygiene <= 30)
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }

            if (!(hygiene <= 0))
            {
                for (int i = 27, j = 0; j < (hygiene / 11) + 1; j++)
                {
                    Console.SetCursorPosition(38 + j, i);
                    Console.Write(" ");
                }
            }
            else
            {

                Console.SetCursorPosition(38, 27);
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" VERY DIRTY ");
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }


        public static void DisplayDogIllnesse(int ill)
        {
            
            if (ill < 10)
            {
                Console.SetCursorPosition(59, 27);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("VERY HEALTHY");

            }
            if (ill >= 10)
            {
                Console.SetCursorPosition(61, 27);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("HEALTHY");
            }
            if (ill >= 20)
            {
                Console.SetCursorPosition(60, 27);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("TAKE PILLS");
            }
            if (ill >= 40)
            {
                Console.SetCursorPosition(54, 27);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("DOG NEED SEROIUS HELP");
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void DiplayDayTime(int age, int rounds)
        {
            Console.SetCursorPosition(75, 21);
            Console.Write($"Day: {age}");

            if (rounds<=24)
            {
                Console.SetCursorPosition(75, 22);
                Console.Write($"Hour: {rounds}");
            }
            else
            {
                var hours = rounds%24;
                Console.SetCursorPosition(75, 22);
                Console.Write($"Hour: {hours}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class DisplayDogActions : DisplayAnimalsActions
    {
        public override  void DisplayBath()
        {
            Console.SetCursorPosition(73, 11);
            Console.WriteLine("1 - River");
            Console.SetCursorPosition(73, 12);
            Console.WriteLine("2 - Shower");
            Console.SetCursorPosition(73, 13);
            Console.WriteLine("3 - Bath");
            Console.SetCursorPosition(73, 14);
            Console.WriteLine("4 - Rain");
            Console.SetCursorPosition(73, 15);
        }


        public override void DisplayFeed()
        {
            Console.SetCursorPosition(73, 11);
            Console.WriteLine("1 - Bone");
            Console.SetCursorPosition(73, 12);
            Console.WriteLine("2 - Cookie");
            Console.SetCursorPosition(73, 13);
            Console.WriteLine("3 - DogFood");
            Console.SetCursorPosition(73, 14);
            Console.WriteLine("4 - PostMan");
            Console.SetCursorPosition(73, 15);
        }

        public override void DisplayHeal()
        {
            Console.SetCursorPosition(73, 11);
            Console.WriteLine("1 - Apap");
            Console.SetCursorPosition(73, 12);
            Console.WriteLine("2 - Vet");
            Console.SetCursorPosition(73, 13);
            Console.WriteLine("3 - Injection");
            Console.SetCursorPosition(73, 14);
            Console.WriteLine("4 - Nothing");
            Console.SetCursorPosition(73, 15);
        }

        public override void DisplayPlay()
        {
            Console.SetCursorPosition(73, 11);
            Console.WriteLine("1 - Fetch");
            Console.SetCursorPosition(73, 12);
            Console.WriteLine("2 - Run");
            Console.SetCursorPosition(73, 13);
            Console.WriteLine("3 - Walk");
            Console.SetCursorPosition(73, 14);
            Console.WriteLine("4 - Bite");
            Console.SetCursorPosition(73, 15);
        }

        public override void DisplaySleep()
        {
            Console.SetCursorPosition(73, 11);
            Console.WriteLine("1 - Floor");
            Console.SetCursorPosition(73, 12);
            Console.WriteLine("2 - DogBed");
            Console.SetCursorPosition(73, 13);
            Console.WriteLine("3 - HumanBed");
            Console.SetCursorPosition(73, 14);
            Console.WriteLine("4 - Outside");
            Console.SetCursorPosition(73, 15);
        }
    }
}

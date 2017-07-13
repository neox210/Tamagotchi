using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class DogEngine
    {
        Dog Dog = new Dog("Puszek");
        
        public void DogMain()
        {
            while (true)
            {
                // DogDisplayStats();
                DogScreenASCII.DisplayDogMenuFrame();
                DogScreenASCII.DisplayDogFace(Dog.Health);
                DogScreenASCII.DisplayDogHealth(Dog.Health);
                DogScreenASCII.DisplayDogEnergy(Dog.Energy);
                DogScreenASCII.DisplayDogHunger(Dog.Hunger);
                DogScreenASCII.DisplayDogHappiness(Dog.Happiness);
                DogScreenASCII.DisplayDogHygiene(Dog.Hygiene);
                DogScreenASCII.DisplayDogIllnesse(Dog.Illnesses);
                DogScreenASCII.DiplayDayTime(Dog.Age, Dog.Rounds);

                Console.WriteLine();
                DogDiplayMoves();
                var number = Console.ReadLine();
                var checkNumber = int.TryParse(number, out int deafult);
                if (checkNumber)
                {
                    var option = int.Parse(number);
                    switch (option)
                    {
                        case 1:
                            Dog.Feed();
                            break;
                        case 2:
                            Dog.Bath();
                            break;
                        case 3:
                            Dog.Play();
                            break;
                        case 4:
                            Dog.Clean();
                            break;
                        case 5:
                            Dog.Heal();
                            break;
                        case 6:
                            Dog.Sleep();
                            break;
                    }
                    Dog.CheckModifiedStats();
                    Dog.HealthControl();
                    if (Dog.Death())
                    {
                        Console.Clear();
                        Death.DeadSkull();
                        Console.ReadKey();
                        break;
                    }
                    Console.SetCursorPosition(73, 18);
                    Console.WriteLine("enter any key");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("please enter number");
                    Console.ReadKey();
                    Console.Clear();
                }


            }
        }

        public void DogDisplayStats()
        {
            Console.WriteLine("name: " + Dog.Name);
            Console.WriteLine("Age: " + Dog.Age);
            Console.WriteLine("Health: " + Dog.Health);
            Console.WriteLine("Energy: " + Dog.Energy);
            Console.WriteLine("Happiness: " + Dog.Happiness);
            Console.WriteLine("Hunger: " + Dog.Hunger);
            Console.WriteLine("Hygiene: " + Dog.Hygiene);
            Console.WriteLine("Illnesses: " + Dog.Illnesses);
        }

        public void DogDiplayMoves()
        {
            Console.SetCursorPosition(73, 4);
            Console.WriteLine("1 - Feed");
            Console.SetCursorPosition(73, 5);
            Console.WriteLine("2 - Bath");
            Console.SetCursorPosition(73, 6);
            Console.WriteLine("3 - Play");
            Console.SetCursorPosition(73, 7);
            Console.WriteLine("4 - Clean");
            Console.SetCursorPosition(73, 8);
            Console.WriteLine("5 - Heal");
            Console.SetCursorPosition(73, 9);
            Console.WriteLine("6 - Sleep");
            Console.SetCursorPosition(73, 10);
        }

    }
}

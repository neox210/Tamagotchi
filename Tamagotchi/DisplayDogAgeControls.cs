using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class DisplayDogAgeControls
    {
        public void DisplayBathControl(int bathOption)
        {
            switch (bathOption)
            {
                case (int)DogWashing.River:
                    Console.WriteLine("Your Dog is too young to swim in the River");
                    break;
                case (int)DogWashing.Shower:

                    break;
                case (int)DogWashing.Bath:
                    Console.WriteLine("Your Dog could draw in your bath. Wait until he grow!");
                    break;
                case (int)DogWashing.Rain:
                    Console.WriteLine("Your Dog could be ill after Rain!. Take care of him and let him grow!");
                    break;
            }
        }

        public void DisplayFeedControl(int feedOption)
        {
            switch (feedOption)
            {
                case (int)DogFood.DogFood:
                    break;
                case (int)DogFood.Cookie:
                    Console.WriteLine("Your Dog is too young for cookies! He will be fat fast!");
                    break;
                case (int)DogFood.Bone:
                    Console.WriteLine("Your young Dog could choke!");
                    break;
                case (int)DogFood.PostMan:
                    Console.WriteLine("Your dog have to be grown up to attack a postman!");
                    break;
            }
        }

        public void DisplayPlayControl(int playOption)
        {
            switch (playOption)
            {
                case (int)DogGames.Walk:
                    break;
                case (int)DogGames.Run:
                    Console.WriteLine("Your Dog is very lazy. Let him grow and then run.");
                    break;
                case (int)DogGames.Fetch:
                    Console.WriteLine("You throw a stick but Dog is to small to bring it back");
                    break;
                case (int)DogGames.Bite:
                    Console.WriteLine("So cute dog! He try to attack??? ohh he is so small ");
                    break;
            }
        }

        public void DisplayHealControl(int option)
        {
            switch (option)
            {
                case (int)DogMedicines.Apap:

                    break;
                case (int)DogMedicines.Injection:
                    Console.WriteLine("Your dog is too young for a big needle!");
                    break;
                case (int)DogMedicines.Nothing:

                    break;
                case (int)DogMedicines.Vet:
                    Console.WriteLine("Let your dog grow! Then go to vet! Take care of him!");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class DogActionsModifiers
    {
        public string Bath(int bathOption)
        {
            string mod = "0 0 0 0 0 0 0";
            switch(bathOption)
            {
                case (int)DogWashing.River:
                    mod = "0 -20 10 15 20 5 3";
                    break;
                case (int)DogWashing.Shower:
                    mod = "0 -5 5 -10 35 0 2";
                    break;
                case (int)DogWashing.Bath:
                    mod = "0 -5 5 -20 45 0 1";
                    break;
                case (int)DogWashing.Rain:
                    mod = "0 -15 10 25 10 2";
                    break;
            }
            return mod;
        }

        public string Clean()
        {
            return "0 0 40 20 20 -10 3";
        }

        public string Feed(int feedOption)
        {
            string mod = "0 0 0 0 0 0 0";
            switch (feedOption)
            {
                case (int)DogFood.DogFood:
                    mod = "0 -10 -25 15 -10 2 1";
                    break;
                case (int)DogFood.Cookie:
                    mod = "0 -5 -10 25 -10 7 1";
                    break;
                case (int)DogFood.Bone:
                    mod = "0 -15 -20 35 -20 0 2";
                    break;
                case (int)DogFood.PostMan:
                    mod = "0 -50 -50 50 -30 20 3";
                    break;
            }
            return mod;
        }
       
        public string Heal(int feedOption)
        {
            string mod = "0 0 0 0 0 0 0";
            var rnd = new Random();
            
            switch (feedOption)
            {
                case (int)DogMedicines.Apap:
                    mod = "10 -10 10 0 0 -15 1";
                    break;
                case (int)DogMedicines.Injection:
                    mod = "30 -10 10 -35 0 -25 2";
                    break;
                case (int)DogMedicines.Nothing:
                    var luck = rnd.Next(0, 100);
                    
                    if(luck < 20)
                    {
                        mod = "-40 -30 -20 -20 -20 30 4 Your_Dog_get_serious_disease";
                        break;
                    }
                    else if(luck >= 20 && luck <= 50 )
                    {
                        mod = "-20 -20 -10 -10 -10 15 2 Your_Dog_get_sick";
                        break;
                    }
                    else if (luck > 50)
                    {
                        mod = "10 0 -10 15 -10 -10 2 Your_Dog_feels_better";
                        break;
                    }
                    break;
                case (int)DogMedicines.Vet:
                    mod = "40 -35 30 -50 -30 -40 4";
                    break;
            }
            return mod;
        }
        // health | energy | Hunger | Happiness | Hygiene | ILINESS | ROUNDS

        public string Play(int playOption)
        {
            string mod = "0 0 0 0 0 0 0";
            switch (playOption)
            {
                case (int)DogGames.Walk:
                    mod = "0 -15 20 20 -10 5 2";
                    break;
                case (int)DogGames.Run:
                    mod = "0 -20 30 25 -20 7 1";
                    break;
                case (int)DogGames.Fetch:
                    mod = "0 -20 35 35 -20 0 2";
                    break;
                case (int)DogGames.Bite:
                    mod = "0 -35 40 45 -30 20 3";
                    break;
            }
            return mod;
        }



        private List<int> Sleepmodifier(int hours, int mod)
        {
            List<int> modifiers = new List<int>();

            modifiers.Add( 4 * (hours - mod));
            modifiers.Add(13 * (hours - mod));
            modifiers.Add((5 * (hours + mod)));
            modifiers.Add(2 * (hours - mod) * (-1));
            modifiers.Add((hours + mod) * (-1));
            modifiers.Add((hours - mod) * (-1));
            modifiers.Add(hours);


            return modifiers;
        }
        public string Sleep(int sleepOption, int hours)
        {
            string mod = "0 0 0 0 0 0 0";

            var modifiers = new List<int>();

            switch (sleepOption)
            {
                case (int)DogSleepPlaces.Outside:

                    modifiers = Sleepmodifier(hours, 3);
                    mod = string.Join(" ", modifiers);
                    break;
                case (int)DogSleepPlaces.Floor:
                    modifiers = Sleepmodifier(hours, 2);
                    mod = string.Join(" ", modifiers);
                    break;
                case (int)DogSleepPlaces.DogBed:
                    modifiers = Sleepmodifier(hours, 1);
                    mod = string.Join(" ", modifiers);
                    break;
                case (int)DogSleepPlaces.HumanBed:
                    modifiers = Sleepmodifier(hours, 0);
                    mod = string.Join(" ", modifiers);
                    break;
            }
            return mod;
        }

        

    }
}

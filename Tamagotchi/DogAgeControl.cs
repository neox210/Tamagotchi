using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class DogAgeControl
    {
        public bool BathControl(int age, int option)
        {
            
            switch(option)
            {
                case (int)DogWashing.River:
                    if (age > 12)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case (int)DogWashing.Shower:
                    return true;

                case (int)DogWashing.Bath:
                    if (age > 6)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case (int)DogWashing.Rain:
                    if (age > 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

            }
            return false;
        }

        public bool FeedControl(int age, int option)
        {
            switch (option)
            {
                case (int)DogFood.DogFood:
                    return true;
                case (int)DogFood.Cookie:
                    if (age > 4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (int)DogFood.Bone:
                    if (age > 8)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (int)DogFood.PostMan:
                    if (age > 16)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

        public bool HealControl(int age, int option)
        {
            switch (option)
            {
                case (int)DogMedicines.Apap:
                    return true;
                case (int)DogMedicines.Injection:
                    if (age > 6)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (int)DogMedicines.Nothing:
                    return true;

                case (int)DogMedicines.Vet:
                    if (age > 12)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

        public bool PlayControl (int age, int option)
        {
            switch (option)
            {
                case (int)DogGames.Walk:
                    return true;
                case (int)DogGames.Run:
                    if (age > 3)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (int)DogGames.Fetch:
                    if (age > 7)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (int)DogGames.Bite:
                    if (age > 13)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }

        public bool SleepControl(int age, int option)
        {

            switch (option)
            {
                case (int)DogSleepPlaces.Outside:

                    return true;
                case (int)DogSleepPlaces.Floor:
                    if (age > 5)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (int)DogSleepPlaces.DogBed:
                    if (age > 10)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case (int)DogSleepPlaces.HumanBed:
                    if (age > 17)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }
    }
}

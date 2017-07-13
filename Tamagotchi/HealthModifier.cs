using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class HealthModifier
    {
        public int OldAge { get; private set; }
        public int NewAge { get; private set; }

        public string HealthChange(int energy, int hunger, int happy, int hygiene, int illiness, int age)
        {
            GetCurrentAge(age);
            string mod = "0 0 0 0 0 0 0";
            if (OldAge!=NewAge)
            {
                int hp = 0;
                hp += HpFromEnergy(energy);
                hp += HpFromHappiness(happy);
                hp += HpFromHunger(hunger);
                hp += HpFromHygiene(hygiene);
                hp += HpFromIllnesses(illiness);
                mod = $"{hp} 0 0 0 0 0 0";
                OldAge = age;
            }
            return mod;
        }

        private void GetCurrentAge(int age)
        {
            NewAge = age;
        }

        private int HpFromEnergy(int energy)
        {
            int hp = 0;
            if (energy<20)
            {
                hp = -10;
            }
            if (energy < 10)
            {
                hp = -15;
            }
            if (energy < 0)
            {
                hp = -20;
            }
            return hp;
        }

        private int HpFromHunger(int hunger)
        {
            int hp = 0;
            if (hunger >40)
            {
                hp = -10;
            }
            if (hunger > 60)
            {
                hp = -20;
            }
            if (hunger > 80)
            {
                hp = -30;
            }
            return hp;
        }

        private int HpFromHappiness(int happy)
        {
            int hp = 0;
            if (happy < 30)
            {
                hp = -20;
            }
            if (happy < 45)
            {
                hp = -15;
            }
            if (happy < 60)
            {
                hp = -10;
            }
            return hp;
        }

        private int HpFromHygiene(int hygiene)
        {
            int hp = 0;
            if (hygiene < 30)
            {
                hp = -20;
            }
            if (hygiene < 50)
            {
                hp = -15;
            }
            if (hygiene < 60)
            {
                hp = -10;
            }
            return hp;
        }

        private int HpFromIllnesses(int illnesses)
        {
            int hp = 0;
            if (illnesses > 20)
            {
                hp = -15;
            }
            if (illnesses > 30)
            {
                hp = -30;
            }
            if (illnesses > 40)
            {
                hp = -45;
            }
            return hp;
        }
    }
}

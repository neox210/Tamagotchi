using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public abstract class Animal
    {
        public int Health { get; private set; }
        public int Energy { get; private set; }
        public int Hunger { get; private set; }
        public int Happiness { get; private set; }
        public int Hygiene { get; private set; }
        public int Illnesses { get; private set; }
        public int Age { get { return Rounds / 24; } }
        public int Rounds { get; private set; }
        public string Name { get; private set; }

        public abstract void Feed();
        public abstract void Sleep();
        public abstract void Clean();
        public abstract void Heal();
        public abstract void Bath();
        public abstract void Play();


        // Set start pet parameters 
        public void SetHealth(int health)
        {
            this.Health = health;
        }

        public void SetEnergy(int energy)
        {
            this.Energy = energy;
        }

        public void SetHunger(int hunger)
        {
            this.Hunger = hunger;
        }

        public void SetHappiness(int happiness)
        {
            this.Happiness = happiness;
        }
        
        public void SetHygiene(int hygiene)
        {
            this.Hygiene = hygiene;
        }

        public void SetIllnesses(int illnesses)
        {
            this.Illnesses = illnesses;
        }

        public void SetRound(int round)
        {
            this.Rounds = round;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }

        //Incrase pet parameters

        public void AddHealth(int health)
        {
            this.Health += health;
        }

        public void AddEnergy(int energy)
        {
            this.Energy += energy;
        }

        public void AddHunger(int hunger)
        {
            this.Hunger += hunger;
        }

        public void AddHappiness(int happiness)
        {
            this.Happiness += happiness;
        }

        public void AddHygiene(int hygiene)
        {
            this.Hygiene += hygiene;
        }

        public void AddIllnesses(int illnesses)
        {
            this.Illnesses += illnesses;
        }

        public void AddRound(int round)
        {
            this.Rounds += round;
        }

        // Decarase pet parameters 

        public void SubtractHealth(int health)
        {
            this.Health -= health;
        }

        public void SubtractEnergy(int energy)
        {
            this.Energy -= energy;
        }

        public void SubtractHunger(int hunger)
        {
            this.Hunger -= hunger;
        }

        public void SubtractHappiness(int happiness)
        {
            this.Happiness -= happiness;
        }

        public void SubtractHygiene(int hygiene)
        {
            this.Hygiene -= hygiene;
        }

        public void SubtractIllnesses(int illnesses)
        {
            this.Illnesses -= illnesses;
        }

    }

    
}

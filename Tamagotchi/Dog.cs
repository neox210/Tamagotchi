using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    public class Dog : Animal
    {
        DisplayDogActions Display = new DisplayDogActions();
        DogActionsModifiers Mod = new DogActionsModifiers();
        DogAgeControl ModControl = new DogAgeControl();
        DisplayDogAgeControls DisplayControls = new DisplayDogAgeControls();
        HealthModifier HelathModifier = new HealthModifier();
        

        public Dog(string name)
        {
            SetHealth(100);
            SetEnergy(100);
            SetHunger(50);
            SetHappiness(30);
            SetHygiene(30);
            SetIllnesses(0);
            SetRound(0);
            SetName(name);
            
        }

        public override void Bath()
        {
            Display.DisplayBath();

            var option = Console.ReadLine();
            var optionCheck = int.TryParse(option, out int deafult);
            if (optionCheck)
            {
                var bathOption = int.Parse(option);
                if (ModControl.BathControl(this.Age, bathOption) == true)
                {
                    var Modifiers = Mod.Bath(bathOption).Split(' ');
                    CheckEnergy(Modifiers);
                }

                else
                {
                    DisplayControls.DisplayBathControl(bathOption);
                }
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
        }

        public override void Clean()
        {
            var Modifiers = Mod.Clean().Split(' ');
            CheckEnergy(Modifiers);
        }

        public override void Feed()
        {
            Display.DisplayFeed();

            var option = Console.ReadLine();
            var optionCheck = int.TryParse(option, out int deafult);
            if (optionCheck)
            {
                var feedOption = int.Parse(option);
                if (ModControl.FeedControl(this.Age, feedOption) == true)
                {
                    var Modifiers = Mod.Feed(feedOption).Split(' ');
                    CheckEnergy(Modifiers);
                }
                else
                {
                    DisplayControls.DisplayFeedControl(feedOption);
                }
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
        }

        public override void Heal()
        {
            Display.DisplayHeal();

            var option = Console.ReadLine();
            var optionCheck = int.TryParse(option, out int deafult);
            if (optionCheck)
            {
                var healOption = int.Parse(option);
                if (ModControl.HealControl(this.Age, healOption) == true)
                {
                    var Modifiers = Mod.Heal(healOption).Split(' ');
                    CheckEnergy(Modifiers);
                    try
                    {
                        var nothingInfo = Modifiers[7].Split('_');
                        foreach (var word in nothingInfo)
                        {
                            Console.Write($"{word} ");
                        }
                    }
                    catch { }
                }
                else
                {
                    DisplayControls.DisplayHealControl(healOption);
                }
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
        }

        public override void Play()
        {
            Display.DisplayPlay();

            var option = Console.ReadLine();
            var optionCheck = int.TryParse(option, out int deafult);
            if (optionCheck)
            {
                var playOption = int.Parse(option);
                if (ModControl.PlayControl(this.Age, playOption) == true)
                {
                    var Modifiers = Mod.Play(playOption).Split(' ');
                    CheckEnergy(Modifiers);
                }
                else
                {
                    DisplayControls.DisplayPlayControl(playOption);
                }
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
        }

        public override void Sleep()
        {
            Display.DisplaySleep();

            var option = Console.ReadLine();
            var optionCheck = int.TryParse(option, out int deafult);
            if (optionCheck)
            {
                var sleepOption = int.Parse(option);
                Console.SetCursorPosition(73, 16);
                Console.WriteLine("How many hours?");
                Console.SetCursorPosition(73, 17);
                var option2 = Console.ReadLine();
                var option2Check = int.TryParse(option2, out int deafult2);
                if (option2Check)
                {
                    var hours = int.Parse(option2);
                    if (ModControl.SleepControl(this.Age, sleepOption) == true)
                    {
                        var Modifiers = Mod.Sleep(sleepOption, hours).Split(' ');
                        ModifyDog(Modifiers);
                    }
                    else
                    {
                        DisplayControls.DisplayFeedControl(sleepOption);
                    }
                }
                else
                {
                    Console.WriteLine("please enter valid number");
                }
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }
        }

        public void ModifyDog(string[] Modifiers)
        {
            AddHealth(int.Parse(Modifiers[0]));
            AddEnergy(int.Parse(Modifiers[1]));
            AddHunger(int.Parse(Modifiers[2]));
            AddHappiness(int.Parse(Modifiers[3]));
            AddHygiene(int.Parse(Modifiers[4]));
            AddIllnesses(int.Parse(Modifiers[5]));
            AddRound(int.Parse(Modifiers[6]));
        }
        
        public void CheckModifiedStats()
        {
            if (this.Health>100)
            {
                SetHealth(100);
            }
            if (this.Energy>100)
            {
                SetEnergy(100);
            }
            if (this.Happiness>100)
            {
                SetHappiness(100);
            }
            if (this.Hunger<0)
            {
                SetHunger(0);
            }
            if (this.Hygiene>100)
            {
                SetHygiene(100);
            }
            if (this.Illnesses<0)
            {
                SetIllnesses(0);
            }
        }

        public void CheckEnergy(string[] modifiers)
        {
            if ( !(this.Energy + (int.Parse(modifiers[1])) < 0))
            {
                ModifyDog(modifiers); 
            }
            else
            {
                Console.WriteLine("Your Dog don't have enough energy");
            }

        }

        public void HealthControl()
        {
           var newHealth = HelathModifier.HealthChange(this.Energy, this.Hunger, this.Happiness, this.Hygiene, this.Illnesses, this.Age).Split(' ');
            ModifyDog(newHealth);
        }

        public bool Death()
        {
            if (this.Health<=0)
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleSettings.ConsoleSet();
            var engine = new DogEngine();

                engine.DogMain();
        }
    }
}

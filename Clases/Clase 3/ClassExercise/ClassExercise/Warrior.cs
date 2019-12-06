using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Warrior : Character
    {
        public int stamina;

        public Warrior(string name, int hp, Stats stats) : base(name, hp, stats)
        {
            Console.WriteLine("Creando Warrior...");

        }
    }
}

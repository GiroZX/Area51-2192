using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Rogue : Character
    {
        public Rogue(string name, int hp, Stats stats) : base(name, hp, stats)
        {
            Console.WriteLine("Creando Rogue...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Wizard : Character
    {
        public int MP;

        public Wizard(string name, int hp, int mp, Stats stats) : base(name, hp, stats)
        {
            Console.WriteLine("Creando Wizard...");

        }
    }
}

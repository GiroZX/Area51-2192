using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorrq
{
    class Vampire : Enemy
    {

        void AttackBite()
        {
            Console.WriteLine("The Vampire bites you!");
            //Protagonist.HP = -2;
        }
    }
}

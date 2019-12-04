using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Player
    {
        public int hp = 5;

        public string Health()
        {
            return "HP = " + hp;
        }

        public string EnterWord()
        {
            Console.WriteLine("Ingrese una letra:");
            return Console.ReadLine();

        }

        public void Damage()
        {
            hp--;

            if (hp <= 0)
                hp = 0;
        }

        public bool IsDead()
        {
            return hp <= 0;
        }
       

    }
}

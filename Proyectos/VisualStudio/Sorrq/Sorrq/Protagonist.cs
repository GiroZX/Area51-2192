using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorrq
{
    class Protagonist
    {
        public string name;
        public int HP;
        public int DEX;
        public int WIS;

        public Protagonist (string name, int hp, int dex, int wis)
        {
            this.name = name;
            this.HP = hp;
            this.DEX = dex;
            this.WIS = wis;

        }

        public virtual void ShowActionMenu()
        {
            Console.WriteLine("What will you do?");
            Console.WriteLine("=================");
        }



        }
    }

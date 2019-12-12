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
        public int ammo;


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
            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    Shoot();
                    break;

                case "2":
                    AmmoCheck();
                    break;

                case "3":
                    Damage();
                    break;

            }

            ShowActionMenu();

        }

        public void Damage()
        {
            HP--;

            if (HP <= 0)
                HP = 0;

        }

        public void Shoot()
        {
            ammo--;
        }

        public void AmmoCheck()
        {
            Console.WriteLine("Actualmente tienes " + ammo + " balas.");
        }



    }
}

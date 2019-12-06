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
            this.MP = mp;
            Console.WriteLine("Creando Wizard...");
        }

        public void Cast()
        {
            Console.WriteLine("Cast");
        }

        public override void ShowActionMenu()
        {
            base.ShowActionMenu();
            Console.WriteLine("4 - cast");

            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    Walk();
                    break;

                case "2":
                    Jump();
                    break;

                case "3":
                    Attack();
                    break;

                case "4":
                    Cast();
                    break;
            }

            ShowActionMenu();
        }

    }
}

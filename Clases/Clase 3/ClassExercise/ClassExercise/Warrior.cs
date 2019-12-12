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

        public override void ShowActionMenu()
        {
            base.ShowActionMenu();

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
            }

            ShowActionMenu();
        }

    }
}

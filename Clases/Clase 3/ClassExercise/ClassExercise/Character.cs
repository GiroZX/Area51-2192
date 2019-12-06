using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    abstract class Character
    {
        public string name;
        public int HP;
        public Stats stats;


        public Character(string name, int hp, Stats stats) {
            this.name = name;
            this.HP = hp;
            this.stats = new Stats();
        }

        public void Attack() {
            Console.WriteLine("You attack: 'Take this!'");
        }

        public void Jump()
        {
            Console.WriteLine("You jump: 'HUP!'");
        }

        public void Walk()
        {
            Console.WriteLine("You walk: 'Is that a penny?'");
        }

        public void ShowActionMenu()
        {
            Console.WriteLine("What will you do?");
            Console.WriteLine("=================");
            Console.WriteLine("1 - Attack");
            Console.WriteLine("2 - Jump");
            Console.WriteLine("3 - Walk");

            string action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    Attack();
                    break;
                case "2":
                    Jump();
                    break;
                case "3":
                    Walk();
                    break;

            }
        }



    }
}

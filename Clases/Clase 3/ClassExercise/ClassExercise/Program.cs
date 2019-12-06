using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args) {

            Console.WriteLine("Character type:");
            Console.WriteLine("\t1-Rogue");
            Console.WriteLine("\t2-Warrior");
            Console.WriteLine("\t3-Wizard");
            string type = Console.ReadLine();
            int hp = 20;
            int mp = 50;
            Stats stats = new Stats();

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Character myCharacter = null;
            switch (type){
                case "1":
                    myCharacter = new Rogue(name, hp, stats);
                    break;

                case "2":
                    myCharacter = new Warrior(name, hp, stats);
                    break;

                case "3":
                    myCharacter = new Wizard(name, hp, mp, stats);
                    break;

                default:
                    Console.WriteLine("DLC has not been purchased!");
                    break;
            }

            if (myCharacter != null)
                myCharacter.ShowActionMenu();

            Console.ReadLine();
        }
    }
}

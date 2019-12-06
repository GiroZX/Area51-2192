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

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Character myCharacter = null;
            switch (type){
                case "1":
                    myCharacter = new Rogue(name);
                    break;

                case "2":
                    myCharacter = new Warrior(name);
                    break;

                case "3":
                    myCharacter = new Wizard(name);
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

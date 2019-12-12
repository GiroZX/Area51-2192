using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorrq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare vuestro nombre:");
            string name = Console.ReadLine();
            int hp = 10;
            int dex = 6;
            int wis = 9;
            int ammo = 8;

            Console.WriteLine("Saludos " + name + ", y bienvenido a su corta aventura como un detective.");
            Protagonist myProtagonist;

            
            myProtagonist.ShowActionMenu();

            Console.ReadLine();
        }
    }
}

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
            Console.WriteLine("State thy name:");
            string name = Console.ReadLine();
            int hp = 20;
            int dex = 6;
            int wis = 9;

            Console.WriteLine("Hello " + name + ", and welcome to your short adventure as a detective");
            Console.ReadLine();
        }
    }
}

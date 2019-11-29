using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        static void Main(string[] args)
        {

            string secretWord = "pantalones";
            string letter = "";

            Console.WriteLine("Ingrese una letra:");
            letter = Console.ReadLine();
            Console.WriteLine(">" + letter);



            Console.ReadLine();
        }
    }
}

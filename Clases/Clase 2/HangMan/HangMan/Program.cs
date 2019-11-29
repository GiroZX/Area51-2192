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
            string tempWord = "";
            string publicWord = "";
            string letter = "";
            int hp = 5;

            for (int i = 0; i < secretWord.Length; i++)
            {
                tempWord += "*";
            }
            publicWord = tempWord;
            Console.WriteLine(publicWord);


            while (hp > 0)
            {
                Console.WriteLine("HP = " + hp);
                Console.WriteLine("Ingrese una letra:");
                letter = Console.ReadLine();
                Console.Clear();

                //Console.WriteLine(">" + letter);

                tempWord = "";
                /*foreach (char c in secretWord)
                {
                    if (letter == "" + c)
                    {
                        tempWord += c; // tempWord = tempWord + c;
                    }

                    else
                    {
                        tempWord += "*";
                    }
                }*/
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (letter == "" + secretWord[i])
                    {
                        tempWord += letter; //tempWord += secretWord[i];
                    }
                    else
                    {
                        tempWord += publicWord[i];
                    }
                }

                if (publicWord == tempWord)
                {
                    hp--;
                }

                if(secretWord == tempWord)
                {
                    Console.WriteLine("You live another day, mortal!");
                    break;
                }

                publicWord = tempWord;
                Console.WriteLine(publicWord);
            }


            if (hp <= 0)
            { Console.WriteLine("YOUR SOUL IS MINE!!!"); }

                Console.ReadLine();
        }
    }
}

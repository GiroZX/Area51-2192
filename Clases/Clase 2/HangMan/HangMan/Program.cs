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
            /*

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
                //*foreach (char c in secretWord)
                {
                    if (letter == "" + c)
                    {
                        tempWord += c; // tempWord = tempWord + c;
                    }

                    else
                    {
                        tempWord += "*";
                    }
                }//
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

            */

            GameManager gameManager = new GameManager();
            Player player = new Player();
            Board board = new Board();

            gameManager.SetSecretWord("zAPatilLas");

            while (gameManager.isPlaying)
            {
                board.Clear();
                board.Draw(player.Health());

                
                board.Draw(gameManager.publicWord);

                string letter = player.EnterWord();
                if (gameManager.CheckLetter(letter)){
                    gameManager.UpdatePublicWord(letter);
                }
                else
                {
                    player.Damage();
                }



                //OPTION 1
                /*
                if (player.IsDead())
                {
                    gameManager.isPlaying = false;
                }
                */
            }

            // OPTION 1
            /*
            board.Clear();
            board.Draw(player.Health());
            board.Draw("Better luck next time, sucker.");
            */

            if (gameManager.IsWin())
            {
                board.Draw("Congrats, you did it!");
            }


            board.Close();

        }
    }
}

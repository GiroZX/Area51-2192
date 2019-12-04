using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Board
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Draw(string line)
        {
            Console.WriteLine(line);
        }

        public void Close()
        {
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();
        }

    }
}

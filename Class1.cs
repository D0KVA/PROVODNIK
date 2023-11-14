using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provodnik
{
    internal class Menu
    {
        public static int Show(int minS, int maxS)
        {
            int pos = 3;
            ConsoleKeyInfo key;
            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != minS)
                    pos--;
                else if (key.Key == ConsoleKey.DownArrow && pos != maxS)
                    pos++;
            } while (key.Key != ConsoleKey.Enter);
            return pos;
        }
    }
}

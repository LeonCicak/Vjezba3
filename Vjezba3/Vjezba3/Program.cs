using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 4, z = 5; // primjer vrijednosti za stranice

            if (x > 0 && y > 0 && z > 0)
            {
                // provjera Pitagorine teoreme za sve permutacije stranica
                if ((x * x + y * y == z * z) ||
                    (x * x + z * z == y * y) ||
                    (y * y + z * z == x * x))
                {
                    Console.WriteLine("Vrijednosti čine stranice pravokutnog trokuta.");
                }
                else
                {
                    Console.WriteLine("Vrijednosti ne čine stranice pravokutnog trokuta.");
                }
            }
            else
            {
                Console.WriteLine("Vrijednosti stranica moraju biti veće od 0.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    class Program
    {
        static string name1, name2;
        static int s1j1, s2j1, s3j1, cont1;
        static int s1j2, s2j2, s3j2, cont2;
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el nombre del jugador 1");
            name1 = Console.ReadLine();
            Console.WriteLine("ingrese el nombre del jugador 2");
            name2 = Console.ReadLine();

            Console.WriteLine("----SET 1 ----");
            Console.WriteLine($"ingrese los puntos del set 1 del jugador {name1}");
            s1j1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"ingrese los puntos del set 1 del jugador {name2}");
            s1j2 = Convert.ToInt32(Console.ReadLine());

            if (s1j1 > s1j2)
            {
                cont1++;
            }
            else
            {
                cont2++;
            }

            Console.WriteLine("----SET 2 ----");
            Console.WriteLine($"ingrese los puntos del set 2 del jugador {name1}");
            s2j1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"ingrese los puntos del set 2 del jugador {name2}");
            s2j2 = Convert.ToInt32(Console.ReadLine());

            if (s2j1 > s2j2)
            {
                cont1++;
            }
            else
            {
                cont2++;
            }
            Console.WriteLine("----SET 3 ----");
            Console.WriteLine($"ingrese los puntos del set 3 del jugador {name1}");
            s3j1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"ingrese los puntos del set 3 del jugador {name2}");
            s3j2 = Convert.ToInt32(Console.ReadLine());

            if (s3j1 > s3j2)
            {
                cont1++;
            }
            else
            {
                cont2++;
            }
            if (cont1 > cont2)
            {
                Console.WriteLine($"el ganador es {name1}");

            }
            else 
            {
                Console.WriteLine($"el ganador es {name2}");
            }
        }
    }
}         

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace orden_del_menor_7_2
{
    class Program
    {
        static int num,orden,menor;
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el 1º numero");
            num = Convert.ToInt32(Console.ReadLine());
            menor = num;
            orden = 1;

            Console.WriteLine("ingrese el 2º numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor) 
            {
                orden = 2;
            }

            Console.WriteLine("ingrese el 3º numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                orden = 3;
            }

            Console.WriteLine("ingrese el 4º numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                orden = 4;
            }

            Console.WriteLine("ingrese el 5º numero");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < menor)
            {
                orden = 5;
            }
            Console.WriteLine($"el numero de orden en el que se ingreso el menor fue {orden}");
            Console.ReadKey();
        }
    }
}

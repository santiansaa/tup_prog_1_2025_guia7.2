using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_valor_7_2
{
    class Program
    {
        static double num,mayor = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el numero 1 ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > mayor) 
            {
                mayor = num;
            }

            Console.WriteLine("ingrese el numero 2 ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }
            Console.WriteLine("ingrese el numero 3 ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }

            Console.WriteLine("ingrese el numero 4 ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }
            Console.WriteLine("ingrese el numero 5 ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }
            Console.WriteLine($"el mayor numero ingresado es {mayor}");
            Console.ReadKey();
        }
    }
}

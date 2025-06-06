using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positivo_negativo_cero
{
    class Program
    {
        static double num;
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            num = Convert.ToDouble(Console.ReadLine());
            if (num >= 1) 
            {
                Console.WriteLine("este numero es positivo");
            }
            if (num == 0) 
            {
                Console.WriteLine("el numero ingresado es 0");
            }
            if (num < 0)
            {
                Console.WriteLine("el numero ingresado es negativo");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soluciones_guia_7._2
{

    class condicion_alumno
    {
        static double promocion,nota1,nota2,nota3,suma,prom;
        
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese la nota con la que se promociona");
            promocion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese las 3 notas que obtuvo el alumno");
            nota1= Convert.ToDouble(Console.ReadLine()); Console.WriteLine("nota1");
            nota2 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("nota2");
            nota3 = Convert.ToDouble(Console.ReadLine()); Console.WriteLine("nota3");
            suma = nota1 + nota2 + nota3;
            prom = suma / 3;
            if (prom >= promocion)
            {
                Console.WriteLine($"se promocina con  {promocion}");
                Console.WriteLine($" y este alumno obtuvo {prom}, por lo tanto promociona ");
            }
            else 
            {
                Console.WriteLine($"se promocina con  {promocion}");
                Console.WriteLine($" y este alumno obtuvo {prom}");
                Console.WriteLine("por lo tanto este alumno rinde final ");
            }

            Console.ReadKey();

        }

    }
}

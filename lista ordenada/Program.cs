using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_ordenada
{
    class Program
    {
        static string p1, p2, p3;
        static double nt1, nt2, nt3;
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese nombre de estudiante 1");
            p1 = Console.ReadLine();
            Console.WriteLine("ingrese nombre de estudiante 2");
            p2 = Console.ReadLine();
            Console.WriteLine("ingrese nombre de estudiante 3");
            p3 = Console.ReadLine();

            Console.WriteLine($"ingrese nota de {p1}");
            nt1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"ingrese nota de {p2}");
            nt2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"ingrese nota de {p3}");
            nt3 = Convert.ToDouble(Console.ReadLine());

            if (nt1 > nt2)
            {
                if (nt3 > nt2)
                {
                    if (nt3 > nt1)
                    {
                        Console.WriteLine($"nota 3 {nt3}---nota1 {nt1}---nota2---{nt2}");
                    }
                    else
                    {
                        Console.WriteLine($"nota 1 {nt1}---nota3 {nt3}---nota2---{nt2}");
                    }
                }
                else
                {
                    Console.WriteLine($"nota 1 {nt1}---nota2 {nt2}---nota3---{nt3}");
                }

            }
            else 
            {
                if (nt3 > nt1)
                {
                    if (nt3 > nt2) 
                    {
                        Console.WriteLine($"nota 3 {nt3}---nota1 {nt2}---nota1---{nt1}");
                    }
                    else 
                    {

                        Console.WriteLine($"nota 2 {nt2}---nota3 {nt3}---nota1---{nt1}");
                    }

                }
                else 
                {
                    Console.WriteLine($"nota 2 {nt2}---nota1 {nt1}---nota3---{nt3}");
                }

            }
            

            


        }
    }
}

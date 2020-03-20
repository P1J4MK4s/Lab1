using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        enum gradus : int
        {
            min = 0,
            krit = 72,
            max = 100,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*const*/ int i = 10;
            Console.WriteLine(i);
            i = 100;
            Console.WriteLine(i);
            Console.WriteLine("минимальная температура=" + (int)gradus.min);
            Console.WriteLine("критическая температура=" + (int)gradus.krit);
            Console.WriteLine("максимальная температура=" + (int)gradus.max);

            double x = Math.E;
            Console.WriteLine("E={0:##.###}", x);
            Console.WriteLine("E={0:.####}", x);
            Console.WriteLine("E={0:.######}", x);

            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("c={0:.###}",c);



        }
    }
}

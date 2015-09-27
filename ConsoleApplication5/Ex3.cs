using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3;

            // aria;
           
            Console.WriteLine("coordonatele punctului 1 x1=");
            x1= double.Parse(Console.ReadLine());
            Console.WriteLine("coordonatele punctului 1 y1=");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("coordonatele punctului 2 x2=");
            x2= double.Parse(Console.ReadLine());
            Console.WriteLine("coordonatele punctului 2 y2=");
            y2= double.Parse(Console.ReadLine());

            Console.WriteLine("coordonatele punctului 3 x3=");
            x3= double.Parse(Console.ReadLine());
            Console.WriteLine("coordonatele punctului 3 y3=");
            y3= double.Parse(Console.ReadLine());

            // aria unui triungi cand se cunosc coordonatele punctelor 

            double aria = x1 * (y2 - y3) - y1 * (x2 - x3) + (x2 * y3 - x3 * y2);
            Console.WriteLine("Aria este {0}", aria*0.5);
            Console.WriteLine();

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}

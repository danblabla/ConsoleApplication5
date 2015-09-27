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
            float x1, y1, x2, y2, x3, y3;
           
            Console.WriteLine("coordonatele punctului 1 x1=");
            x1= float.Parse(Console.ReadLine());
            Console.WriteLine("coordonatele punctului 1 y1=");
            y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("coordonatele punctului 2 x2=");
            x2= float.Parse(Console.ReadLine());
            Console.WriteLine("coordonatele punctului 2 y2=");
            y2= float.Parse(Console.ReadLine());

            Console.WriteLine("coordonatele punctului 3 x3=");
            x3= float.Parse(Console.ReadLine());
            Console.WriteLine("coordonatele punctului 3 y3=");
            y3= float.Parse(Console.ReadLine());

            Console.WriteLine("Aria este {0}", x1*(y2- y3)-y1*(x2-x3)+(x2*y3-x3*y2));
            Console.WriteLine();

            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}

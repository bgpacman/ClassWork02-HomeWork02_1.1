using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var s = Math.PI * r * r;
            var p = 2 * Math.PI * r;

            Console.WriteLine("Area = {0}", s);
            Console.WriteLine("Perimeter = {0}", p);
        }
    }
}

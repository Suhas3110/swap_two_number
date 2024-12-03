using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_two_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the two number");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Swap two Number");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a+" "+b);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sum_and_avg
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            double av;
            string s;
            Console.Write("a="); s = Console.ReadLine();
            a = int.Parse(s);
            Console.Write("b="); s = Console.ReadLine();
            b = int.Parse(s);
            sum = a + b;
            av = sum / 2.0;
            Console.WriteLine("sum={0} av={1}", sum, av);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WartoscBezwzgledna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WartoscBezwzgledna.Abs(5));
            Console.WriteLine(WartoscBezwzgledna.Abs(-1));
            Console.WriteLine(WartoscBezwzgledna.Abs(23.312));
            Console.WriteLine(WartoscBezwzgledna.Abs(-455123.123));
            Console.WriteLine(WartoscBezwzgledna.Abs(-0.001));
            Console.WriteLine(WartoscBezwzgledna.Abs(1));
            Console.WriteLine(WartoscBezwzgledna.Abs(0));
            Console.ReadKey();
        }
    }
}

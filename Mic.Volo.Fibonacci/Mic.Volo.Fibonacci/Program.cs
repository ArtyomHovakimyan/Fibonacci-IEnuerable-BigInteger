using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Mic.Volo.Fibonacci
{
    class Program
    {
        static IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = new BigInteger(0);
            BigInteger b = new BigInteger(1);
            BigInteger c = new BigInteger(0);

            while (Console.ReadKey().Key == ConsoleKey.Spacebar)
            {
                yield return c;
                c = a + b;
                a = b;
                b = c;
            }
        }
        static void Main(string[] args)
        {
            var Values = Fibonacci();
            foreach (var value in Values)
            {
                Console.WriteLine($"Press Space to Print Next Value {value}");
            }
        }
    }
}

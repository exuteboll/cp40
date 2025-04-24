using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        delegate int Calc(int x, int y);
        static void Main(string[] args)
        {
            Calc calc = new Calc(Add);
            int result = calc.Invoke(4, 5);
            Console.WriteLine(result);

            calc = Multiply;
            result = calc(4, 5);
            Console.WriteLine(result);

            calc = Del;
            result = calc(10, 2);
            Console.WriteLine(result);

            calc = Minus;
            result = calc(5, 4);
            Console.WriteLine(result);
            Console.ReadKey();

        }
        static int Add(int x, int y) => x + y;

        static int Multiply(int x, int y) => x * y;
        static int Del(int x, int y) => x / y;
        static int Minus(int x, int y) => x - y;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        public static double Average(double m, double n)
        {
            double sum = 0;
            int count = 0;
            for (double i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return sum / count;
        }
        public delegate double AverageDelegate(double m, double n);

        static void Main(string[] args)
        {
            AverageDelegate avg = new AverageDelegate(Average);

            double res = avg(10, 20);
            Console.WriteLine(res);

            double res1 = avg(100, 200);
            Console.WriteLine(res1);

            double res2 = avg(300, 600);
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}

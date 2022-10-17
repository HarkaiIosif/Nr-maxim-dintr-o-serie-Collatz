using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr_maxim_dintr_o_serie_Collatz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = -1;
            int n = int.Parse(Console.ReadLine());
            while (n != 1)
            {
                if (n > max) max = n;
                if (n % 2 == 0) n = n / 2;
                else n = 3 * n + 1;
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}

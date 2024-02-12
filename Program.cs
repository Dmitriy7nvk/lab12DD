using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Unit-testing in C#");
            Console.WriteLine("Anime");
        }

        public static int Min(int a, int b, int c)
        {

            int min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }
    }
}

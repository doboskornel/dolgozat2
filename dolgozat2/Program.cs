using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[100];
            Random r = new Random();
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                r.Next();
            }

            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb.Length;
            }

            Console.ReadKey();


        }
    }
}

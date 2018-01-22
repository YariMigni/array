using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int[] Numeri = new int[A];

            for (int i = 0; i < A; i++)
            {
                Console.WriteLine();
                Console.WriteLine("inserisci il numero di posizione {0}", i);
                Numeri[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Numeri.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("il valore e {0}", Numeri[i]);
            }
            Console.ReadLine();
        }
    }
}

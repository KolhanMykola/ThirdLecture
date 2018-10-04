using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLecture5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter level of trsingle");
            int level = int.Parse(Console.ReadLine());

            for (int i = 1; i <= level; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

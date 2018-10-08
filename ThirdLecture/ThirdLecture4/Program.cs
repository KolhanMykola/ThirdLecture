using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter data of three subjects");
            int math = Convert.ToInt32(Console.ReadLine());
            int physics = Convert.ToInt32(Console.ReadLine());
            int chemistry = Convert.ToInt32(Console.ReadLine());
            if (IsAllowedFirst(math,physics,chemistry)) Console.WriteLine("Student is allowed");
            else if (IsAllowedSecond(math, physics, chemistry)) Console.WriteLine("Student is allowed");
            else Console.WriteLine("Student is not allowed");

            Console.ReadKey();
        }

        private static bool IsAllowedFirst(int math, int physics, int chemistry)
        {
            return math >= 65 && physics >= 55 && chemistry >= 50 && math + physics + chemistry >= 180;
        }

        private static bool IsAllowedSecond(int math, int physics, int chemistry)
        {
            return math+physics >= 140 || math + chemistry >= 140;
        }
       
    }
}

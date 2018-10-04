using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I wanna calculate something for you, please input the first digit");
            string firstDigitString = Console.ReadLine();
            Console.WriteLine("Thank’s and another digit please!");
            string secondDigitString = Console.ReadLine();
            int firstDigit = 0, secondDigit = 0;

            try
            {
                firstDigit = Convert.ToInt32(firstDigitString);
                secondDigit = Convert.ToInt32(secondDigitString);

                if (firstDigit > 10 || firstDigit < 0 || secondDigit > 10 || secondDigit < 0)
                    Console.WriteLine("\nSorry, I support only digits from 0 to 10 :");
                else
                    Console.WriteLine($"Here you are: {firstDigit * secondDigit}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nSorry, I do not now how to multiply chars:");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nSorry, but is too large for a 32 bit integer:");
            };

            Console.ReadKey();
        }
    }
}

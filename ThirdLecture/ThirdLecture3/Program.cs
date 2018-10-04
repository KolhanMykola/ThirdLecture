using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters, hour, minutes, seconds;
            try
            {
                Console.WriteLine("Input distance(meters): ");
                meters = double.Parse(Console.ReadLine());
                Console.WriteLine("Input timeSec(hour): ");
                hour = double.Parse(Console.ReadLine());
                Console.WriteLine("Input timeSec(minutes): ");
                minutes = double.Parse(Console.ReadLine());
                Console.WriteLine("Input timeSec(seconds): ");
                seconds = double.Parse(Console.ReadLine());
            }

            catch(FormatException)
            {
                Console.WriteLine("Please input digit!");
                Console.ReadKey();
                return;
            }

            double timeSeconds = hour * 3600 + minutes * 60 + seconds;
            double timeHours = hour + minutes / 60 + seconds/3600;          

            Console.WriteLine("Your speed in meters/sec is {0}", meters / timeSeconds);
            Console.WriteLine("Your speed in km/h is {0}", (meters / 1000) / timeHours);
            Console.WriteLine("Your speed in miles/h is {0}", meters * 0.00062137119223733 / timeHours);

            Console.ReadKey();
        }
    }
}

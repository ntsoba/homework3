using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance: ");
            float distance = float.Parse(Console.ReadLine());

            Console.WriteLine("Input hour: ");
            int hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Input minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Input seconds: ");
            int seconds = int.Parse(Console.ReadLine());

            //Calculate meters/sec

            float sfm = minutes * 60; //seconds in minutes

            float sfh = hour * 3600; // seconds in hours

            float sec1 = seconds + sfm + sfh; 

            float metsec = distance / (float)sec1; // meters/sec

            //Calculate km/h

            double min1 = (seconds / (float)60) + minutes;

            double hour1 = (min1 / (float)60) + hour;

            float km = distance / 1000;

            double kmh = km / (float)hour1;  // km/hour

            //Calculate miles/h

            double mil = distance* 0.00062137;

            double milih = mil / (float)hour1; // mil/hour


            Console.WriteLine("Your speed in meters/sec is " + metsec);
            Console.WriteLine("Your speed in km/h is " + kmh);
            Console.WriteLine("Your speed in miles/h is " + milih);

            Console.ReadKey();
        }
    }
}

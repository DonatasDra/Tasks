using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            int minutes = 0;
            bool validInput = false;

            // Check hours input
            while (!validInput || hours < 0 || hours >= 24)
            {
                Console.Write("Enter hours between 0 and 23: ");
                var hoursInput = Console.ReadLine();
                validInput = int.TryParse(hoursInput, out hours);
                if(!validInput)
                {
                    Console.WriteLine("Invalid input");
                }
            }
            validInput = false;

            // Check minutes input
            while (!validInput || minutes < 0 || minutes >= 60)
            { 
                Console.Write("Enter minutes between 0 and 59: ");
                var minutesInput = Console.ReadLine();
                validInput = int.TryParse(minutesInput, out minutes);
                if (!validInput)
                {
                    Console.WriteLine("Invalid input");
                }
            } ;

            // Make sure hours arrow range is between 0 and 11
            if (hours >= 12)
            {
                hours -= 12;
            }

            // Get degree of hours and minutes arrows
            float hoursDegree = (float)(hours * 30 + minutes * 0.5);
            float minutesDegree = 360/60 * minutes;

            // Locate lesser angle
            if (hoursDegree - minutesDegree < 0)
            {
                hoursDegree = 360 - hoursDegree;
                minutesDegree = 360 - minutesDegree;
            }
            // Calculate angle
            float angle = hoursDegree - minutesDegree;

            Console.WriteLine("Lesser angle in degrees is: " + angle);
        }
    }
}
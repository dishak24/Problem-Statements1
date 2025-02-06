using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ProblemStatement1
{
    internal class MovieTikit
    {
        public int age;
        public int movieTime;
        public long tikitPrice = 0;
        public void CalculatePrize()
        {
            Console.WriteLine("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            if (age < 0)
            {
                Console.WriteLine("Enter valid age !");
            }

            Console.WriteLine("Enter your Movie Time in format of 24 hours:");
            movieTime = Convert.ToInt32(Console.ReadLine());

            if(movieTime < 1 && movieTime > 12)
            {
                Console.WriteLine("Enter valid Movie Time in the format of 24 hours !");
            }

            if ( age <= 12)
            {
                tikitPrice = 120;
            }
            else if ( age <= 64 && age > 12)
            {
                tikitPrice = 240;
            }
            else
            {
                tikitPrice = 180;
            }

            if ( movieTime <= 12 )
            {
                tikitPrice -= 50;
            }

            Console.WriteLine("Thank you for Booking...!");
            Console.WriteLine("Age :" +age );
            Console.WriteLine("Movie Time :" + movieTime);
            Console.WriteLine("Tikit Prize :" +tikitPrice);

        }
      
        
    }
}

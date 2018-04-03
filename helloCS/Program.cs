using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsAtDogPark = 398; // Yes, this is a HUGE dog park
            int sandwichesICanEat = 3; // Small sandwiches
            double niceDinnerPrice = 9.589; // In gas station dollars
            int[] carColor = new int[] { 104, 212, 140 }; // RGB form
            string carMake = "Toyota"; // #dreambig
            string carModel = "AE86"; // Lets deliver some tofu
            DateTime rightNow = DateTime.Now; // Good naming
            char myFirstLetter = 'C'; // TODO: Add silly comment
            int starsInTheSky = 100; // In billions of stars, only could count the ones in our galaxy

            Console.WriteLine(String.Format("There are {0} dogs at this one particular dog park. The real question: Does such a dog park exist?", dogsAtDogPark));
            Console.WriteLine(String.Format("Since I don't eat much, {0} is the limit for my gut.", sandwichesICanEat));
            Console.WriteLine(String.Format("The last time I took a girl out for a nice dinner it only cost me {0}... Maybe that's is why I'm single?", niceDinnerPrice));
            Console.WriteLine(String.Format("[{0}, {1}, {2}] == {3}", carColor[0], carColor[1], carColor[2], "Some greenish color if you cared"));
            Console.WriteLine(String.Format("{0} is the greatest car company ever!!!", carMake));
            Console.WriteLine(String.Format("{0}. Seriously, lets deliver some tofu.", carModel));
            Console.WriteLine(String.Format("{0} is the current time and date", rightNow));
            Console.WriteLine(String.Format("{0} is the first characture of the word \"Charles\"", myFirstLetter));
            Console.WriteLine(String.Format("There are {0} billion stars in our beautiful galaxy!", starsInTheSky));

            Console.Read(); // Wait a minute!
        }
    }
}

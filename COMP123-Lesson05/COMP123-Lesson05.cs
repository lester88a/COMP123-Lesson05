using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] originalArray = { "Honda", "BMW", "Mercedes", "Jeep", "Ford" };

            string[] newArray = new string[3];

            Random rnd = new Random();

            int randomMember;


            // Assign cells from one array to another


            int index = 0;
            while (index < newArray.Length)
            {
                randomMember = generateRandomMember(rnd);

                if (originalArray[randomMember] != "unavailable")
                {
                    newArray[index] = originalArray[randomMember];

                    originalArray[randomMember] = "unavailable";

                    index++;
                }


            }


            /* Alternate Looping Structure
            for (int index = 0; index < newArray.Length; index++)
            {
                
                randomMember = generateRandomMember(rnd);
                if (originalArray[randomMember] != "unavailable")
                {
                    newArray[index] = originalArray[randomMember];
                    originalArray[randomMember] = "unavailable";
                } 
            }
             */



            /* Alternate way to declare and initialize an array
            string[] originalArray = new string[6];
            originalArray[0] = "Honda";
            originalArray[1] = "BMW";
            originalArray[2] = "Mercedes";
            originalArray[3] = "Jeep";
            originalArray[4] = "Ford";
            originalArray[5] = "Jaguar";
            */

            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("+  Original Car  List  +");
            Console.WriteLine("++++++++++++++++++++++++");

            // Output the value of the each cell in each array
            for (index = 0; index < originalArray.Length; index++)
            {
                Console.WriteLine(originalArray[index]);
            }

            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("+     New Car  List    +");
            Console.WriteLine("++++++++++++++++++++++++");

            for (index = 0; index < newArray.Length; index++)
            {

                Console.WriteLine(newArray[index]);
            }







            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }

        private static int generateRandomMember(Random rnd)
        {
            int randomCar;

            randomCar = rnd.Next(5);
            Console.WriteLine("My Random car is {0}", randomCar); // Debugging line
            return randomCar;
        }
    }
}
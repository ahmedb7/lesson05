using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] carMakeList= {"Honda","BMW","Mercedes", "Jeep", "Ford"};

            string[] tempCarMakeList = new string[3];
            Random rnd = new Random();

            int randomCar;

            randomCar = rnd.Next(6);
            Console.WriteLine("My random car is {0}", randomCar);

            for (int index = 0; index < tempCarMakeList.Length; index++ )
            {
                tempCarMakeList[index] = carMakeList[index];
            }

                /*string[] carMakeList = new string [6];
                carMakeList[0] = "Honda";
                carMakeList[1] = "BMW";
                carMakeList[2] = "Marcedes";
                carMakeList[3] = "Jeep";
                carMakeList[4] = "Ford";
                carMakeList[5] = "Jagur";
                */
            //Put put the value
                for (int index = 0; index < carMakeList.Length; index++)
                {
                    Console.WriteLine(carMakeList[index]);
                    
                }
                Console.WriteLine("+++++++++++++++++++++++++");
                for (int index = 0; index < tempCarMakeList.Length; index++)
                {
                    
                    Console.WriteLine(tempCarMakeList[index]);
                }

            

            /* Alternative Methods
            int index = 0;
            while (index< carMakeList.Length)
            {
                Console.WriteLine(carMakeList[index]);
                index++;
            }
             */ 
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
    
        }
    }
}

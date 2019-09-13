using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Mileage_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean isRunning = true;
            double totalMPG = 0.00;
            double newMPG;
            double miles;
            double gallons;
            //double[] MPGArr = new double[0];
            List<double> MPGList = new List<double>(); 

            while (isRunning)
            {
                Console.Write("Enter the number of miles driven (-1 to quit): ");
                miles = Convert.ToDouble(Console.ReadLine());
                if (miles == -1)
                {
                    isRunning = false;
                    break;
                }
                Console.Write("Enter the number of gallons used: ");
                gallons = Convert.ToDouble(Console.ReadLine());

                newMPG = miles / gallons;
                MPGList.Add(newMPG);

                for (int i = 0; i < MPGList.Count; i++) {
                    totalMPG += MPGList[i];
                }

                totalMPG /= MPGList.Count;

                Console.WriteLine(MPGList);
                Console.WriteLine(MPGList.Count);
                Console.ReadLine();

                Console.WriteLine("MPG this tankful: " + MPGList[MPGList.Count]);
                Console.WriteLine("Total MPG: " + totalMPG);
                Console.WriteLine();
            }

            Console.WriteLine("Press 'enter' to close the program.");
            Console.ReadLine();
        }
    }
}

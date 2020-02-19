using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtoCConverter
{
    class Program
    {

        public static void printDirections()
         {
            Console.WriteLine("Welcome to the Farhenheit to Celsius Converter Program!");
            Console.WriteLine("In a moment you will be prompted for a temperature in FARHENHEIT.");
            Console.WriteLine("This program will quickly convert the temperature to Celsius and display the result.");
            Console.WriteLine("\nPlease remember to enter only one integer with no other symbols or characters.\n");
         }
        public static int getInt()
        {
            int n1 = 0;
            String input = "";
            Console.WriteLine("Please enter an integer: ");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }
        public static double convertFToC(int fTemp)
        {
            double cTemp = 0.0;

            cTemp = fTemp - 32.0;
            cTemp = cTemp * 5.0;
            cTemp = cTemp / 9.0;

            return cTemp;
        }
        public static void printResults(int fTemp, double cTemp)
        {
            Console.Clear();
            Console.WriteLine("The temperature you entered was: " + fTemp);
            Console.WriteLine("Your temperature converted to Celsius is: " + cTemp + "\n");
            Console.Write("Thank you for using the Farhenheit to Celsius converter!");
        }
        public static void farToCelConversion()
        {
            int farTemp = 0;
            double celTemp = 0.0;
            
            printDirections();
            farTemp = getInt();

            celTemp = convertFToC(farTemp);

            printResults(farTemp, celTemp);
            Console.ReadLine(); //This is here because I was having issues with Visual Studio
        }

        static void Main(string[] args)
        {
            farToCelConversion();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    static class Trigonometry
    {
        internal static double calcOppSide(double adjside,double acuteangle)
        {
            double result = 0;
            //convert angle to radians
            double radians = acuteangle / 57.3;
            //get TAN of the radians
            double tan = Math.Tan(radians);
            result =Math.Round( tan * adjside,1);

            return result;
        }

        internal static double calcHypotenuseSide(double adjside, double oppside)
        {
            
            return Math.Sqrt(((adjside * adjside) + (oppside * oppside)));
        }

        internal static void displayResults(double oppside, double hypotenuse)
        {
            Console.WriteLine("Opposite: {0}", Math.Round(oppside,0));
            Console.WriteLine("Hypotenuse: {0}", Math.Round(hypotenuse,0));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class WindowsDimensionsCalc2
    {
        const double MAX_WINDOWS_WIDTH = 5.0;
        const double MIN_WINDOWS_WIDTH = 0.5;
        const double MAX_WINDOWS_HEIGHT = 3.0;
        const double MIN_WINDOWS_HEIGHT = 0.75;
        double glassWidth;
        public static double readWidth()
        {
            double retVal = 0;
            do
            {
                Console.Write("Give width of window between " + MIN_WINDOWS_WIDTH + " and "
                                                      + MAX_WINDOWS_WIDTH + " : ");

                retVal = double.Parse(Console.ReadLine());
            } while ((retVal < MIN_WINDOWS_WIDTH) || (retVal > MAX_WINDOWS_WIDTH));
            return retVal;
        }
        public static double readHeight()
        {
            double retVal = 0;
            do
            {
                Console.Write("Give Height of window between " + MIN_WINDOWS_HEIGHT + " and "
                                                      + MAX_WINDOWS_HEIGHT + " : ");

                retVal = double.Parse(Console.ReadLine());
            } while ((retVal < MIN_WINDOWS_HEIGHT) || (retVal > MAX_WINDOWS_HEIGHT));
            return retVal;
        }

        
        public static double CalcDim(double width,double woodHeight)
        {
            //width
            return woodHeight - (2 * width);
        }
        public static double CalcDIM(double height, double woodHeight)
        {
            //height
            return woodHeight - (2 * height);
        }
        public static double CalcArea(double glassWidth, double hwglassheight)
        {
            //area
            return hwglassheight   * glassWidth;
        }
        public static double CalcAmt(double areaglass,double glassWidth, double hwglassheight)
        {
            //area
            return areaglass/( hwglassheight * glassWidth);
        }
        public static double CalWoodHeight(double height, double woodheight)
        {
            return height - (2 * woodheight);
        }
        public static double ConvMtoF(double ShorterWoodHeight) 
        {
            return ShorterWoodHeight * 3.25;
        }

        public static double CalcSum(double AreaWood1,double AreaWood2)
        {
            return AreaWood1 + AreaWood2;
        }
        public static void DisplayResults(double AmountGlass, double AmountWood)
        {
            Console.ForegroundColor = ConsoleColor.White;
             
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Amount of glass required in feet :"+AmountGlass);
            Console.WriteLine("The Amount of glass required in feet : "+AmountWood);
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();
            Console.WriteLine();
        }
        private void test()
        {

        }
            

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public   class WindowsDimensionsCalc
    {
        const double MAX_WINDOWS_WIDTH = 5.0;
        const double MIN_WINDOWS_WIDTH = 0.5;
        const double MAX_WINDOWS_HEIGHT = 3.0;
        const double MIN_WINDOWS_HEIGHT = 0.75;

        static double  width,  height, woodLength, glassArea;
        static string  widthStr;
        public static void DisplayRequirements()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This application will help you calculate the amount of wood and glass needed for a  windows!");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("APPLICATION REQUIREMENTS");
            Console.WriteLine("Please enter a height between 0.5 and 2.0 meters and a width value between 0.5 and  2.0 meters.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();   
            Console.WriteLine();
        }
        public  static double getWindowsWidth()
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
        public static double getWindowsHeight()
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

        public static Dimesions calc(double _width,double _height)
        {
            Dimesions d = new Assignment2.Dimesions();
            d = d.calc(_width, _height);
            return d;
        }
        public static void DisplayResults(Dimesions D)
        {
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("APPLICATION RESULTS");
            Console.WriteLine("\nThe length of wood is " + D.Woodlength.ToString()
                                                  + " feet");
            Console.WriteLine("\nThe area of glass is " + D.GlassArea.ToString()
                                                         + " square metres");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ResetColor();
            Console.WriteLine();
        }
    }
    public class Dimesions
    {
        double woodlength;
        double glassArea;

        public double Woodlength
        {
            get
            {
                return woodlength;
            }

            set
            {
                woodlength = value;
            }
        }

        

        public double GlassArea
        {
            get
            {
                return glassArea;
            }

            set
            {
                glassArea = value;
            }
        }

        public Dimesions calc(double width, double height)
        {
            Dimesions d = new Assignment2.Dimesions();
            d.Woodlength = 2 * (width + height) * 3.25;
            d.GlassArea = 2 * (width * height);

            return d;
        }
    }
}

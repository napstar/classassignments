using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //grade
            // GradeClass gradeClass = new Assignment2.GradeClass();
            //gradeClass.gradeMethod();

            //loops and arrays
            //LoopsAnd_Arrays LPA = new LoopsAnd_Arrays();
            //Console.WriteLine("\n\n***********************************************************");
            //Console.WriteLine("Print array in one line".ToUpper()+"\n\n");
            //LPA.printOneLine();
            //Console.WriteLine("\n\n***********************************************************\n\n");
            //Console.WriteLine("\n\n"+"Print even and odd numbers in an array".ToUpper()+"\n");
            //LPA.printOddAndEven();
            //Console.WriteLine("\n\n***********************************************************\n\n");
            //Console.ReadLine();

            //trig
            /* double acuteangle, adjside, oppside, hypotenuse;
             string input;

             Console.Write("Enter one of the acute angles :");
             input = Console.ReadLine();
             acuteangle = double.Parse(input);

             Console.Write("Enter the adjacent side :");
             input = Console.ReadLine();
             adjside = double.Parse(input);

             oppside = Trigonometry.calcOppSide(adjside, acuteangle);
             hypotenuse = Trigonometry.calcHypotenuseSide(adjside, oppside);
             Trigonometry.displayResults(oppside, hypotenuse);
             Console.ReadLine();*/
            //WindowsDimensionsCalc.DisplayRequirements();
            //double width = WindowsDimensionsCalc.getWindowsWidth();
            //double len = WindowsDimensionsCalc.getWindowsHeight();
            //Dimesions d = new Dimesions();
            //d = WindowsDimensionsCalc.calc(width, len);

            //WindowsDimensionsCalc.DisplayResults(d);
            const double woodheight = 2, hwglassheight = 4.0, hwglasswidth = 0.4, hwwoodwidth = 0.5;

            double windowHeight=  WindowsDimensionsCalc2.readHeight();
            double windowWidth=  WindowsDimensionsCalc2.readWidth();
            double glassWidth = WindowsDimensionsCalc2.CalcDim(windowWidth, woodheight);
            double glassHeight = WindowsDimensionsCalc2.CalcDIM(windowHeight, woodheight);
            double areaOfGlass = WindowsDimensionsCalc2.CalcArea(glassWidth, hwglassheight);
            double amtOfGlass = WindowsDimensionsCalc2.CalcAmt(areaOfGlass, glassWidth, hwglassheight);
            
            double ShorterwoodHeightFt = WindowsDimensionsCalc2.CalWoodHeight(windowHeight, woodheight);

            double ShorterWoodheightft = WindowsDimensionsCalc2.ConvMtoF(ShorterwoodHeightFt);
            double Woodheightft = WindowsDimensionsCalc2.ConvMtoF(woodheight);
            double WoodWidthft= WindowsDimensionsCalc2.ConvMtoF(windowWidth);
            double AreaWood1 = WindowsDimensionsCalc2.CalcArea(WoodWidthft, Woodheightft);
            double AreaWood2 = WindowsDimensionsCalc2.CalcArea(ShorterWoodheightft, Woodheightft);

            double AreaWood = WindowsDimensionsCalc2.CalcSum(AreaWood1, AreaWood2);
            double Amountofwood = WindowsDimensionsCalc2.CalcAmt(AreaWood, hwwoodwidth, Woodheightft);
            WindowsDimensionsCalc2.DisplayResults(amtOfGlass, Amountofwood);



            Console.ReadLine();

        }
     
    }
}

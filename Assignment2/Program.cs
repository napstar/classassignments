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
            double acuteangle, adjside, oppside, hypotenuse;
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
            Console.ReadLine();


        }
     
    }
}

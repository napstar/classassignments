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
            // GradeClass gradeClass = new Assignment2.GradeClass();
            //gradeClass.gradeMethod();
            LoopsAnd_Arrays LPA = new LoopsAnd_Arrays();
            Console.WriteLine("\n\n***********************************************************");
            Console.WriteLine("Print array in one line".ToUpper()+"\n\n");
            LPA.printOneLine();
            Console.WriteLine("\n\n***********************************************************\n\n");
            Console.WriteLine("\n\n"+"Print even and odd numbers in an array".ToUpper()+"\n");
            LPA.printOddAndEven();
            Console.WriteLine("\n\n***********************************************************\n\n");
            Console.ReadLine();
          
            
        }
     
    }
}

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
            Console.WriteLine("Print array in one line\n\n");
            LPA.printOneLine();
            Console.WriteLine("\n\nPrint even and odd numbers in an array\n");
            LPA.printOddAndEven();
           
            Console.ReadLine();
          
            
        }
     
    }
}

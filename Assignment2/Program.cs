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
            Console.WriteLine("Enter a letter grade(enter x to exit)");
            string strInput = string.Empty;
            while (true)
            {
                strInput = Console.ReadLine();
                if (strInput == "x")
                {
                    break;

                }
                else
                {
                    string strOutput = printResult(strInput);
                    Console.WriteLine("Range:{0} ", strOutput);
                }
               
                
            }
         
          
            //end
            //Console.ReadLine();
        }
        static string printResult(string strInput)
        {
            char charInput = strInput[0];
            string strOutput = string.Empty;
            switch (charInput)
            {
                case 'a':
                    {
                        strOutput=  "70 -100";
                        break;
                    }
                case 'b':
                    {
                        strOutput= "60-69";
                        break;
                    }
                case 'c':
                    {
                        strOutput= "50 - 59";
                        break;
                    }
                case 'd':
                    {
                        strOutput= "40 - 49";
                        break;
                    }

                default:
                    strOutput= "0-39";
                    break;
            }

            return strOutput;
        }
    }
}

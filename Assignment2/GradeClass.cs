using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class GradeClass
    {
         string printResult(string strInput)
        {
            string str = strInput.ToUpper();
            char charInput = str[0];
            string strOutput = string.Empty;
            switch (charInput)
            {
                case 'A':
                    {
                        strOutput = "70 -100";
                        break;
                    }
                case 'B':
                    {
                        strOutput = "60-69";
                        break;
                    }
                case 'C':
                    {
                        strOutput = "50 - 59";
                        break;
                    }
                case 'D':
                    {
                        strOutput = "40 - 49";
                        break;
                    }

                default:
                    strOutput = "0-39";
                    break;
            }

            return strOutput;
        }
        public void gradeMethod()
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
        }
    }
}

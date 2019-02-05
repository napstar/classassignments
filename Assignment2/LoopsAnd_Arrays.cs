using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class LoopsAnd_Arrays
    {
        int[] arr = new int[] { 15, 68, 4, 19, 99, 52, 53, 36, 74, 1, 85 };

        public void printOneLine()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString()+" ");
            }
        }
        public void printOddAndEven()
        {
            StringBuilder sb = new StringBuilder();
            //even
            for (int i = 0; i < arr.Length; i++)
            {
                int currentValue = arr[i];
                if (currentValue % 2 == 0)
                {
                    sb.Append(currentValue + " ");
                }
            }
            sb.AppendLine("");
            //odd
            for (int i = 0; i < arr.Length; i++)
            {
                int currentValue = arr[i];
                if (currentValue % 2!=0)
                {
                    sb.Append(currentValue+" ");
                }
            }
           
            
            sb.AppendLine("");
            Console.WriteLine(sb);
        }
    }
}

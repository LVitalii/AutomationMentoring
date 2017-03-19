using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    public static class Tasks
    {
        public static void SashaTask()
        {
            int[] arrInput = { 1, 7, 4 };
            int[] arrTarget = { 0, 5, 1, 3, 7, 8, 4 };

            //int[] arrInput = { 2, 5 };
            //int[] arrTarget = { 1, 5, 7, 2 };

            //int[] arrInput = { 3, 7, 4 };
            //int[] arrTarget = { 3, 5, 7, 6 };

            //int[] arrInput = { 1, 1, 2, 2, 3 };
            //int[] arrTarget = { 1, 2, 3 };

            //int[] arrInput = { 1, 1, 2, 2, 3 };
            //int[] arrTarget = { 1, 1, 9, 2, 3, 2, 4, 3 };

            int startIndex = 0;
            bool result = true;

            for (int i = 0; i < arrInput.Length; i++)
            {
                int index = Array.IndexOf(arrTarget, arrInput[i], startIndex);
                if (index >= 0)
                {
                    startIndex = index + 1;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            Console.WriteLine("Result is: " + result);
        }
    }
}

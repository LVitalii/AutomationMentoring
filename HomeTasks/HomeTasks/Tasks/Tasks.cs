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

        public static void Task1()
        {
            string[] arr = { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };
            foreach (string str in arr)
            {
                if (!str.Contains("ap"))
                    Console.WriteLine(str);
            }
        }

        public static void Task1Optional()
        {
            string[] arr = { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" };
            foreach (string str in arr)
            {
                if (!str.ToUpper().Contains("ap".ToUpper()))
                    Console.WriteLine(str);
            } 
        }

        public static void Task2()
        {
            string enteredValue = Console.ReadLine();
            int parsedValue;
            Int32.TryParse(enteredValue, out parsedValue);
            //Console.WriteLine(parsedValue);
            int sum = 0;
            for (int i = 1; i <= parsedValue; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum is: " + sum);
        }

        public static void Task4()
        {
            string enteredKey = "";
            bool willExit;

            do
            {
                Console.WriteLine("What is the color of Banana? \na.Red\nb.Green\nc.Yellow\nd.Blue\ne.Purple");
                enteredKey = Console.ReadLine();

                switch (enteredKey)
                {
                    case "a": Console.WriteLine("Wrong colour is selected. "); break;
                    case "b": Console.WriteLine("Wrong colour is selected. "); break;
                    case "c": Console.WriteLine("You've guessed. "); break;
                    case "d": Console.WriteLine("Wrong colour is selected. "); break;
                    case "e": Console.WriteLine("Wrong colour is selected. "); break;
                    default: Console.WriteLine("You entered value not in [a-e]"); break;
                }
                Console.WriteLine("Do you want to play one more time? Press y: for 'yes' or n: for 'no' ");

                enteredKey = Console.ReadLine();
                switch (enteredKey)
                {
                    case "y": willExit = false; break;
                    case "n": willExit = true; break;
                    default:
                        {
                            willExit = true;
                            Console.WriteLine("You entered another key. Thus Exit!");
                            break;
                        }
                }
            }
            while (!willExit);
        }

        public static void Task5()
        {
            bool willExit;
            do
            {
                Console.WriteLine("Enter the password");
                string enteredValue = Console.ReadLine();
                switch (enteredValue)
                {
                    case "root":
                        {
                            willExit = true;
                            Console.WriteLine("Congratulations. You've entered the rigth password");
                            break;
                        }
                    default:
                        {
                            willExit = false;
                            Console.WriteLine("Sorry, entered password is not right. You have to continue till guess the password!");
                            break;
                        }
                }
            }
            while (!willExit);

        }

        public static void Task6()
        {
            int[] arr = { 55, 35, 76, 81, 49, 71, 66, 77 };

            Console.WriteLine("Initial array: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\nResult values: ");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
                if (i == 71)
                    break;
            }
        }

        public static void Task1Collection()
        {
            Console.Write("Enter the number of values to be read: ");
            string numberEntered = Console.ReadLine();
            int number = 0;
            if (!Int32.TryParse(numberEntered, out number))
            {
                Console.WriteLine("Entered value cannot be parsed as integer");
                return;
            }
            int[] arr = { 1, 6, 34, 55, 11, 56, 97, 55, 6, 41, 32 };
            Console.WriteLine("These are the values:");
            for (int i = 0; i < number; i++)
            {
                Console.Write(arr[i]);
                if ((i + 1) < number)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }

        public static void Task2Collection()
        {
            Console.Write("Enter the number of the last values to be read: ");
            string numberEntered = Console.ReadLine();
            int number = 0;
            if (!Int32.TryParse(numberEntered, out number))
            {
                Console.WriteLine("Entered value cannot be parsed as integer");
                return;
            }
            int[] arr = { 1, 6, 34, 55, 11, 56, 97, 55, 6, 41, 32 };
            Console.WriteLine("These are the values:");
            for (int i = number; i > 0; i--)
            {
                Console.Write(arr[arr.Length - i]);
                if ((i - 1) > 0)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }

        }

    }
}

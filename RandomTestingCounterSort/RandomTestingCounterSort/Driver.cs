using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTestingCounterSort
{
    class Driver
    {
        //Class Level Variables
        public static int ARRAY_SIZE = 100000000;
        

        static void Main(string[] args)
        {
            int count = 1;

            do
            {
                WriteLine($"Pass: {count}");
                ArrayList mainArray = new ArrayList();
                ManyArrays(mainArray);
                count++;
            } while (count <= 1000);
            ReadKey();
        }//End Main Method

        public static void ManyArrays(ArrayList mainArray)
        {
            int[] secondaryArray = new int[ARRAY_SIZE];
            mainArray.Clear();
            FillArray.FillArrayData(mainArray, 3);
            PrintArray(mainArray);
            CountArray(mainArray, secondaryArray);
            PrintArray(secondaryArray);
            SortArray(mainArray, secondaryArray);
            PrintArray(mainArray);
            CheckArray(mainArray);
        }//End ManyArray

        public static void CheckArray(ArrayList mainMethod)
        {
            string message = "Array Sorted Successfully!";
            

            for (int i = 0; i < mainMethod.Count-1; i++)
            {
                //int place1 = (int) mainMethod[i];
                //int place2 = (int)mainMethod[i + 1];

                if ((int) mainMethod[i] > (int) mainMethod[i + 1])
                {
                    message = "Error, Incorrectly Sorted Array!";
                }//End if
            }//End for

            WriteLine(message);
        }//End CheckArray

        /// <summary>
        /// Expects: The mainArray and the secondaryArray
        /// Returns: Nothing
        /// Tasks: loops through the mainArray and counts the number of times
        ///     each number occurs.
        /// </summary>
        /// <param name="mainArray"></param>
        /// <param name="secondaryArray"></param>
        public static void CountArray(ArrayList mainArray, int[] secondaryArray)
        {
            foreach (int num in mainArray)
            {
                int value = (int)secondaryArray[num];
                secondaryArray[num] = value + 1;
            }//End foreach
        }//End CountArray

        /// <summary>
        /// Expects: The mainArray and the secondaryArray
        /// Returns: Nothing
        /// Tasks: Depending on the number in the secondaryArray, add the index
        ///     that number of times to the mainArray.
        /// </summary>
        /// <param name="mainArray"></param>
        /// <param name="secondaryArray"></param>
        public static void SortArray(ArrayList mainArray, int[] secondaryArray)
        {
            int value = 0;
            mainArray.Clear();
            foreach (int num in secondaryArray)
            {
                for (int lcv1 = 0; lcv1 < num; lcv1++)
                {
                    mainArray.Add(value);
                }//End for loop
                value++;
            }//End foreach loop
        }//End SortArray

        /// <summary>
        /// Expects: An ArrayList to print
        /// Returns: Nothing
        /// Tasks: When given an array, print the contents of the array.
        /// </summary>
        /// <param name="mainArray"></param>
        public static void PrintArray(ArrayList theArray)
        {
            int count = 0;

            foreach (int num in theArray)
            {
                Write(num + " ");
                count++;

                if (count == 25)
                {
                    WriteLine();
                    count = 0;
                }//End if
            }//End foreach
            WriteLine();
        }//End PrintArray

        /// <summary>
        /// Expects: An Array to print
        /// Returns: Nothing
        /// Tasks: When given an array, print the contents of the array.
        /// </summary>
        /// <param name="theArray"></param>
        public static void PrintArray(int[] theArray)
        {
            int count = 0;

            foreach (int num in theArray)
            {
                Write(num + " ");
                count++;

                if (count == 25)
                {
                    WriteLine();
                    count = 0;
                }//End if
            }//End foreach
            WriteLine();
        }//End PrintArray
    }//End Class
}//End Namespace

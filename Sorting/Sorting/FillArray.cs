/***********************************
 * Name: Dylan Buehler
 * Date: 2/12/19
 * Class: Data Structures
 * Filename: FillArray.cs
 ***********************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class FillArray
    {
        //Class Level Variable
        static int AMOUNT_OF_DATA = Driver.ARRAY_SIZE;

        /// <summary>
        /// Expects: The main array
        /// Returns: Nothing
        /// Tasks: Fills the main array with data
        /// </summary>
        /// <param name="mainArray"></param>
        public static void FillArrayData(ArrayList mainArray, int typeFill)
        {
            // TypeFill = 0 will do all the same data in the array.
            // TypeFill = 1 will do different values but sorted.
            // TypeFill = 2 will do different values reverse sorted.
            // TypeFill = 3 will do random data in the array.

            Random randNum = new Random();
            int normSort = 0;
            int revsSort = AMOUNT_OF_DATA - 1;

            for (int lcv1 = 0; lcv1 < AMOUNT_OF_DATA; lcv1++)
            {
                switch(typeFill)
                {
                    case 0:
                        mainArray.Add(5);
                        break;
                    case 1:
                        mainArray.Add(normSort);
                        normSort++;
                        break;
                    case 2:
                        mainArray.Add(revsSort);
                        revsSort--;
                        break;
                    case 3:
                        mainArray.Add(randNum.Next(0, AMOUNT_OF_DATA));
                        break;
                }//End Switch Statement
            }//End for loop
        }//End FillArray
    }//End Class
}//End Namespace

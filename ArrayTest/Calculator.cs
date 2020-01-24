using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayTest
{
   public class Calculator
    {

        public int[] AddArrays(int[] array1, int[] array2)
        {
            int[] array3 = new int[array1.Count()];
            for (int i = 0; i < array1.Length; i++)
            {
              
                 array3[i] = array1[i] + array2[i];
            }
           // int[] temp = new int[] { 0 };
            return array3;
        }



    }

    
}

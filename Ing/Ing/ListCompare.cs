using System;
using System.Collections.Generic;

namespace Ing
{
    public class ListCompare
    {
        static void Main()
        {
        }
        public bool VerifyArraysDifferences(String[] array1, String[] array2)
        {
            List<string> differenceNumber = new List<string>();
            List<string> repeatedNumber = new List<string>();           

            for (int i = 0; i < array1.Length; i++)
            {
                Boolean exist = false;

                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i].Equals(array2[j]))
                    {
                        repeatedNumber.Add(array1[i]);
                        exist = true;
                        break;
                    }                      
                }

                if (!exist)
                {
                    differenceNumber.Add(array1[i]);
                    Console.WriteLine(array1[i]);
                }
            }

            if (differenceNumber.Count == 0)
            {
                return false;
            }
            return true;               
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Check_If_N_and_Its_Double_Exist
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {4, 1 , 1, 8 };
            Console.WriteLine(CheckIfExist(arr));
            Console.WriteLine("Hello World!");
        }

        public static bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i + 1;
                while (j < arr.Length)
                {
                    if (arr[i] > arr[j] && arr[i] > 0)
                    {
                        if (2 * arr[j] == arr[i]) return true;
                    }
                    else
                    {
                        if (2 * arr[i] == arr[j]) return true;
                    }
                    j++;
                }
            }
            //HashSet<int> set = new HashSet<int>();
            //foreach(int i in arr)
            //{
            //    if (set.Contains(i * 2)) return true;

            //    if (i % 2 == 0 && set.Contains(i / 2)) return true;

            //    set.Add(i);
            //}
            return false;
        }
    }
}

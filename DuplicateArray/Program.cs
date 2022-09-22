using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 2, 4, 3, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine(arr[j]);
                    }
                }

            }
        }
    }
}

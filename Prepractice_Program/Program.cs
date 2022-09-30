using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepractice_Program
{
    //Move zeros to beginning or end of array. e.g. if given array is { 2 , 10 , 0 ,5 ,3, 0, 4 ,1}
    //then output array should be a. { 0,0,2,10,5,3,4,1} b. {2,10,5,3,4,1,0,0}


    internal class Program
    {
            static void zerosToEnd(int[] arr, int n)
            {
                
                int count = 0;

                for (int i = 0; i < n; i++)
                    if (arr[i] != 0)

                        arr[count++] = arr[i];

                while (count < n)
                    arr[count++] = 0;
            }
            static void modifyArr(int[] arr, int n)
            {
               
                if (n == 1)
                    return;

                for (int i = 0; i < n - 1; i++)
                {
                    if ((arr[i] != 0) && (arr[i] == arr[i + 1]))
                    {
                        arr[i] = 2 * arr[i];
                        arr[i + 1] = 0;

                        i++;
                    }
                }

                zerosToEnd(arr, n);
            }
            static void printArray(int[] arr, int n)
            {
                for (int i = 0; i < n; i++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
            }

        static void printArr(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
        }

       
        static void zeroToStart(int[] arr, int n)
        {

            int count1 = 0;

          
            for (int i = 0; i < n; i++)
                if (arr[i] != 1)
                    arr[count1++] = arr[i];

           
            while (count1 < n)
                arr[count1++] = 1;

      
            int lastNonOne = 0;

            for (int i = n - 1; i >= 0; i--)
            {

                if (arr[i] == 1)
                    continue;
                if (lastNonOne == 0)
                {
                    lastNonOne = i;
                }

            
                if (arr[i] != 0)
                    arr[lastNonOne--] = arr[i];
            }

                 // Put zeros to start of array
                 while (lastNonOne >= 0)
                    arr[lastNonOne--] = 0;
        }

      

          public static void Main()
          {
                int[] arr = { 2, 10, 0, 5, 3, 0, 4, 1 };
                int n = arr.Length;

                Console.Write("Original array: ");
                printArray(arr, n);

                modifyArr(arr, n);

                Console.Write("Zeros at End: ");
                printArray(arr, n); 
        
                zeroToStart(arr, n);

                Console.Write("Zeros at Start: ");
                printArr(arr, n);
          }
    }


}



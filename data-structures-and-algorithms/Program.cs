﻿namespace data_structures_and_algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] array = new int[] {1,2,3,4,5};
            int valuAdded = 7;

            int[] reverseArrat=InsertShiftArray(array,valuAdded);

            for (int i = 0; i < reverseArrat.Length; i++)
            {
                Console.WriteLine(reverseArrat[i]);
            }
            */

            int[] arr = { -131, -82, 0, 27, 42, 68, 179 };
            int key = 42;
            Console.WriteLine(BinarySearch(arr, key));

        }
        public static int[] Reverse(int[] array)
        {
            if (array.Length<0 || array==null)
            {
                throw new ArgumentNullException("array is null");   

            }
            else
            {
                int[] newArray = new int[array.Length];
                int index = 0;
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    newArray[index] = array[i];
                    index++;
                }
                return newArray;
            }
            
        }
 
        public static int[] InsertShiftArray(int[] array,int value) {
            if (array.Length < 0 || array == null)
            {
                throw new ArgumentNullException("array is null");

            }
            else
            {
                int[] newArray = new int[array.Length + 1];
                int medindex = array.Length / 2;

                for (int i = 0, j = 0; i <= array.Length; i++, j++)
                {
                    if (i == medindex)
                    {
                        newArray[i] = value;
                        j--;
                    }
                    else
                    {
                        newArray[i] = array[j];
                    }

                }
                return newArray;

            }


        }
        public static int BinarySearch(int[] arr, int key)
        {
            int h = arr.Length - 1;
            int l = 0;
            while (l <= h)
            {
                int m = (l + h) / 2;

                if (arr[m] == key)
                {
                    return m;
                }
                else
                {
                    if (key > arr[m])
                        l = m + 1;
                    else
                    {
                        h = m - 1;
                    }
                }

            }
            return -1;
        }
    }
    
}
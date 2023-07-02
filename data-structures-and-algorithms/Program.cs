
namespace data_structures_and_algorithms
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
            

            int[] arr = { -131, -82, 0, 27, 42, 68, 179 };
            int key = 42;
            Console.WriteLine(BinarySearch(arr, key));
*/
            Linked_List l1 = new Linked_List();
            //   l1.InsertFirst(15);
            // l1.InsertFirst(50);

            //  l1.InsertPosition(1, 20);
            //  l1.InsertLast(22);
            ///l1.InsertLast(33);
            //  l1.InsertFirst(33);
            //  l1.InsertLast(44);
            //l1.InsertLast(77);
            //  l1.InsertPosition(1, 20);
            // l1.SerchNode(20);
            l1.InsertFirst(2);
l1.InsertFirst(8);
           l1.InsertFirst(3);
            l1.InsertFirst(1);
            


           //Console.WriteLine(l1.Head.Item);
            //Console.WriteLine(l1.tail.Item);
           // Console.WriteLine(l1.tail.Item);
           
            Console.WriteLine(l1.SerchTailNode(0));
            Console.WriteLine(l1.PrintList()); 
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
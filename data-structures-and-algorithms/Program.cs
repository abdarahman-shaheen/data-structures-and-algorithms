﻿
using System.Collections;

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


            Linked_List l1 = new Linked_List();
            l1.InsertLast(1);
            l1.InsertLast(2);   
            l1.InsertLast(3);
            Linked_List l2 = new Linked_List();
            l2.InsertLast(4);
            l2.InsertLast(5);
            l2.InsertLast(6);
            l2.InsertLast(7);
            l2.InsertLast(8);
            Linked_List l3 = new Linked_List();
            l3 = Linked_List.zipList(l1, l2);
          
            Linked_List l4 = new Linked_List();
            l4.InsertFirstString("m");
            l4.InsertFirstString("o");
            l4.InsertFirstString("k");
            l4.InsertFirstString("k");
            l4.InsertFirstString("o");
            l4.InsertFirstString("m");
            Linked_List.LinkedPindromd(l4);
            Console.WriteLine(l4.PrintListString());   */
            //l1.InsertFirst(15);
            //l1.InsertFirst(50);
            //l1.InsertPosition(1, 20);
            //l1.InsertLast(22);
            //l1.InsertLast(33);
            //l1.InsertFirst(33);
            //l1.InsertLast(44);
            //l1.InsertLast(77);
            //l1.InsertPosition(1, 20);
            //l1.SerchNode(20);
            //l1.InsertFirst(2);
            //l1.InsertFirst(8);
            //l1.InsertFirst(3);
            //l1.InsertFirst(1);
            //Console.WriteLine(l1.Head.Item);
            //Console.WriteLine(l1.tail.Item);
            //Console.WriteLine(l1.tail.Item);
            //Console.WriteLine(l1.SerchTailNode(0));
            //Console.WriteLine(l1.PrintList()); 
            //     Stack stack = new Stack();
            //     stack.Push(1);
            //    stack.Push(2);
            //  stack.Push(3);

            // stack.Prints();

            //  Queue queue = new Queue();
            // queue.Enqueue(1);
            //  queue.Enqueue(2);
            //  queue.Enqueue(3);
            //  PeSudoQueue queue = new PeSudoQueue();
            // queue.Enqueue(1);
            // queue.Enqueue(2);
            // queue.Enqueue(3);
            // queue.Prints();            
            // AnimalShelter animalShelter = new AnimalShelter();

            // Enqueue
            //    Animal Rex = new Animal() { Species = "dog", Name = "Rex" };
            //   Animal Sam = new Animal() { Species = "cat", Name = "Sam" };
            //    Console.WriteLine("Add animal");
            //   animalShelter.Enqueue(Sam);
            //   animalShelter.Enqueue(Rex);

            //  animalShelter.PrintCount();

            //  Console.WriteLine("Remove animal ");
            //  animalShelter.Dequeue(Rex.Species);
            //  animalShelter.PrintCount();
            //Console.WriteLine(ValidatorBracket("{(})"));
            // Console.WriteLine(queue.Dequeue());
            //     char[] charArray = { 'A', 'B', 'C', 'D' ,'E'};
            //  Console.WriteLine(DuckGosse(charArray, 3)); 

            //BinarySearchTree<int> binarySeartchTree = new BinarySearchTree<int>();

            //binarySeartchTree.Add(20);
            //binarySeartchTree.Add(30);
            //binarySeartchTree.Add(50);
            //binarySeartchTree.Add(25);
            //binarySeartchTree.Add(40);
            //binarySeartchTree.Add(60);
            //binarySeartchTree.Add(80);


            //Console.WriteLine("Pre-Order Traversal");

            //string resultString = string.Join(",", binarySeartchTree.PreOrderTravarsel());
            //Console.WriteLine(resultString);


            //Console.WriteLine("In-order Traversal");
            //Console.WriteLine(string.Join(", ", binarySeartchTree.InorderTraversal()));

            //Console.WriteLine("Post-order Traversal");
            //Console.WriteLine(string.Join(", ", binarySeartchTree.PostorderTraversal()));
            //Console.WriteLine("maximum value in the tree is: " + binarySeartchTree.FindMaximumValue());
            {
                //BinaryTree<int> binaryTree = new BinaryTree<int>();
                //binaryTree.Add(2);
                //binaryTree.Add(7);
                //binaryTree.Add(5);
                //binaryTree.Add(2);
                //binaryTree.Add(6);
                //binaryTree.Add(9);
                //binaryTree.Add(5);
                //binaryTree.Add(11);
                //binaryTree.Add(4);
                //Console.WriteLine("Breadth-First Traversal: " + string.Join(" ", binaryTree.BFS(binaryTree.Root)));

                //BinaryTree<int> binaryTree = new BinaryTree<int>();
                //binaryTree.Add(2);
                //binaryTree.Add(7);
                //binaryTree.Add(5);
                //binaryTree.Add(2);
                //binaryTree.Add(6);
                //binaryTree.Add(9);
                //binaryTree.Add(5);
                //binaryTree.Add(11);
                //binaryTree.Add(4);
                //BinaryTree<string> fizzBuzzTree = binaryTree.FizzBuzzTree();
                //Console.WriteLine("Breadth-First Traversal: " + string.Join(" ", binaryTree.BFS(binaryTree.Root)));

                //Console.WriteLine("FizzBuzz Tree: " + string.Join(" ", fizzBuzzTree.BFS(fizzBuzzTree.Root)));

                int[] inputArray = { 5, 2, 9, 3, 4, 6 };
                int[] sortedArray = InsertionSort(inputArray);

                Console.WriteLine("Sorted Array:");
                foreach (int num in sortedArray)
                {
                    Console.Write(num + " ");
                }
            }


        }

       
            public static void Insert(int[] sorted, int value)
            {
                int i = 0;
                while (i < sorted.Length && value > sorted[i])
                {
                    i++;
                }
                while (i < sorted.Length)
                {
                    int temp = sorted[i];
                    sorted[i] = value;
                    value = temp;
                    i++;
                }
            }

            public static int[] InsertionSort(int[] input)
            {
                int[] sorted = new int[input.Length];
                sorted[0] = input[0];
                for (int i = 1; i < input.Length; i++)
                {
                    Insert(sorted, input[i]);
                }
                return sorted;
            }

            public static int[] Reverse(int[] array)
            {
                if (array.Length < 0 || array == null)
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

            public static int[] InsertShiftArray(int[] array, int value)
            {
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

            public static bool ValidatorBracket(string brackt)
            {
                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < brackt.Length; i++)
                {
                    if (brackt[i] == '{' || brackt[i] == '(' || brackt[i] == '[')
                    {
                        stack.Push(brackt[i]);
                    }
                    else if (brackt[i] == '}' || brackt[i] == ')' || brackt[i] == ']')
                    {
                        if (stack.Count == 0)
                            return false;

                        char top = stack.Peek();
                        if (brackt[i] == ')' && top == '(')
                        {
                            stack.Pop();
                        }
                        else if (brackt[i] == ']' && top == '[')
                        {
                            stack.Pop();
                        }
                        else if (brackt[i] == '}' && top == '{')
                        {
                            stack.Pop();
                        };

                    }

                }
                if (stack.Count == 0)
                {
                    return true;
                }
                return false;
            }

            public static char DuckGosse(char[] chars, int k)
            {
                Queue<char> queue = new Queue<char>();
                Queue<char> Temp = new Queue<char>();

                for (int i = 0; i < chars.Length; i++)
                {
                    queue.Enqueue(chars[i]);
                }
                while (queue.Count != 0)
                {
                    if (queue.Count == 1)
                    {
                        return queue.Dequeue();
                    }

                    for (int j = 1; j <= k; j++)
                    {
                        if (queue.Count == 0)
                        {
                            while (Temp.Count != 0)
                            {
                                queue.Enqueue(Temp.Dequeue());
                            }
                        }

                        if (j == k)
                        {
                            queue.Dequeue();
                            break;
                        }

                        Temp.Enqueue(queue.Dequeue());


                    }

                    while (Temp.Count != 0)
                    {
                        queue.Enqueue(Temp.Dequeue());

                    }



                }




                return '\n';



            }
        }

    }
    

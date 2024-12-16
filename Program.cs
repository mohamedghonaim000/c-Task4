using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace assigment04
{
    internal class Program
    {

        public static int [] merge(int [] arr1 , int [] arr2) {
            int i=0 ,j=0 , k = 0;
            int[] arr3 = new int[arr1.Length+arr2.Length];
            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] <= arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    j++;
                }
                k++;
            }
            while (i < arr1.Length)
            {
                arr3[k] = arr1[i];
                i++;
                k++;
            }

            while (j < arr2.Length)
            {
                arr3[k] = arr2[j];
                j++;
                k++;
            }

            return arr3;
        }
        public static int[] FindFrequency(int[] arr)
        {
            int max = arr.Max();
            int[] frequency = new int[max+1];
            for (int i = 0; i < arr.Length; i++)
            {
                frequency[arr[i]]++;
            }
            return frequency;
        }

        public static void FindTheMax(int[] arr)
        {
            int max = arr[0];
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("this array is empty");
            }
            else {
                for (int i = 0;  i < arr.Length;  i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }

                }
                Console.WriteLine($"the max number is {max}");
            }

        }

        public static void FindTheSecondlargst(int[] arr) {
            int secodLargest = arr.Min();
            int max = arr[0];
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("this array is empty");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }

                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > secodLargest && arr[i]<max)
                {
                    secodLargest = arr[i];
                }

            }
            Console.WriteLine($"second larget is {secodLargest}");





        }

        public static void checkThediffrance1(ref int x)
        {
            x = 12;
            Console.WriteLine(x);
        }

        public static void check_ref ( ref string str)
        {
            str = "ahmed";
            Console.WriteLine(str);
        }

        public static void OutPutParameter(int x , int y , out int mull , out int sub)
        {
            mull = x * y;
            sub = y - x;
        }

        public static int SumOfDigets (int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += (x % 10);
                x /= 10;
            }
            return sum;
        }

        public static bool IsPrime (int x)
        {
            if (x % Math.Sqrt(x)==0)
            {
                return false;
            }
            return true;
        }
        public static void MinMaxArray(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("this array is empty");
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }

                }
                Console.WriteLine($"the max number is {max}");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }

                }
                Console.WriteLine($"the min number is {min}");
            }

        }
        public static void Factorial (int x)
        {
            for (int i = 1; i <= x; i++)
            {
                if (x%i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        public static void changechar (string str ,int position ,  char newchar)
        {
            if (position < 0 || position > str.Length)
            {
                Console.WriteLine("enter a valid position");

            }
            else { 
                char[] newstr = str.ToCharArray();
                newstr[position] = newchar;
                Console.WriteLine(newstr);


            }


        } 


        static void Main(string[] args)
        {
            #region problem 01
            //Console.WriteLine("enter the coordinate of point 1");
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //int y1 = Convert.ToInt32(Console.ReadLine());
            //double slop1 = y1 / x1;

            //Console.WriteLine("enter the coordinate of point 2");
            //int x2 = Convert.ToInt32(Console.ReadLine());
            //int y2 = Convert.ToInt32(Console.ReadLine());
            //double slop2 = y2 / x2;

            //Console.WriteLine("enter the coordinate of point 3");
            //int x3 = Convert.ToInt32(Console.ReadLine());
            //int y3 = Convert.ToInt32(Console.ReadLine());
            //double slop3 = y3 / x3;

            //if (slop1 == slop2 && slop1 == slop3)
            //{
            //    Console.WriteLine("the there points lies in the same line");
            //}
            //else { Console.WriteLine("the threre points dosent lie in the same line"); }; 
            #endregion

            #region problem 02
            //Console.WriteLine("enter the duration of the task");
            //float Duration = float.Parse(Console.ReadLine());

            //if (Duration >= 2 && Duration <= 3)
            //{
            //    Console.WriteLine("they are considered highly efficient.");
            //}
            //else if (Duration > 3 && Duration <= 4)
            //{
            //    Console.WriteLine("they are instructed to increase their speed.");

            //}
            //else if (Duration > 4 && Duration <= 5)
            //{
            //    Console.WriteLine("they are provided with training to enhance their speed.");

            //}
            //else
            //{
            //    Console.WriteLine("they are required to leave the company.");
            //};

            #endregion

            #region problem 03 
            //Console.WriteLine("enter the size of identity matrix");
            //int n = int.Parse(Console.ReadLine());
            //if (n > 0)
            //{
            //    int[,] identityMatrix = new int[n, n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //        {
            //            if (i == j)
            //            {
            //                identityMatrix[i, j] = 1;
            //                Console.Write("1 ");

            //            }
            //            else
            //            {
            //                identityMatrix[i, j] = 0;

            //                Console.Write("0 ");
            //            }
            //        }
            //        Console.WriteLine();

            //    }
            //}
            //else { Console.WriteLine("please enter invalid positive number"); };
            #endregion

            #region problem 04
            //Console.WriteLine("enter the size of the array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int result = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter the arrau element {i + 1}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    result += arr[i];

            //}
            //Console.WriteLine($"the total summision of all elements in the array is {result}"); 
            #endregion


            #region problem 05 
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //int[] arr3 = merge(arr1, arr2);

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //} 
            #endregion


            #region problem 06
            //int[] arr = { 1, 2, 3, 4, 5, 5, 7, 9, 9 };
            //int[] arr2 = FindFrequency(arr);
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"{i} -> {arr2[i]}");

            //}

            #endregion

            #region problem 07 
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            //FindTheMax(arr); 
            #endregion

            #region problem 08
            //int[] arr = { 1, 2, 5, 3 };

            //FindTheSecondlargst(arr); 
            #endregion

            #region problem 09
            //string str = "iam mohamed mokhtar";
            //char[] delimiter = { ' ' };
            //string[] NewStr = str.Split(delimiter);
            //string[] Reversedstring = NewStr.Reverse().ToArray();
            //foreach (var item in Reversedstring)
            //{
            //    Console.Write(item + " ");
            //} 
            #endregion

            #region problem 10
            //Console.WriteLine("enter the numbers of rows");
            //int row = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the numbers of columns");
            //int coulumns = Convert.ToInt32(Console.ReadLine());

            //int[ , ] arr1 = new int[row , coulumns];

            //for (int i = 0; i < row; i++) {
            //    for (int j = 0; j < coulumns; j++) {
            //        Console.WriteLine($"enter the element {i}{j}");
            //        arr1[i , j ] = Convert.ToInt32(Console.ReadLine());
                    
            //    }
            //}

            //int[,] arr2 = new int[row, coulumns];

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < coulumns; j++)
            //    {
            //        arr2[i, j] = arr1[i , j]; 
            //        Console.Write(arr2 [i, j] + " ");

            //    }Console.WriteLine();
            //}
            #endregion

            #region problem 11
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion

            //////////////////////////////// funcitions /////////////////
            // passing by value mean that we pass aclone or acopy of the variable to funcition stored in the stack of the function
            //and there is no relation between the original value and the copy

            #region peoblem 01 
            //int x = 10;
            //checkThediffrance1(x);
            //Console.WriteLine(x); 
            // i modified the funcition
            //int x = 10;
            //checkThediffrance1(ref x);
            //Console.WriteLine(x);
            #endregion

            #region problem 02
            // the same as the last one when i pass a refrance type parameter with out ref it take aclone or acopy
            //but when i pass it by ref it take the same object in the heab

            //string str = "mohamed"; 
            //check_ref(str);
            //Console.WriteLine(str);

            //string str = "mohamed";
            //check_ref(ref str);
            //Console.WriteLine(str); 
            #endregion

            #region problem 03
            //int x = 9; int y = 10;
            //int mull = 0;
            //int sub = 0;
            //OutPutParameter(x, y, out mull, out sub);
            //Console.WriteLine(mull);
            //Console.WriteLine(sub); 
            #endregion

            #region problem 04
            //int x = 25;
            //int y = SumOfDigets(x);
            //Console.WriteLine(y); 
            #endregion


            #region problem 05
            //int x = 9;
            //Console.WriteLine(IsPrime(x));

            #endregion


            #region problem 06
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //MinMaxArray(arr); 
            #endregion

            #region problem 07
            //int x = 10;
            //Factorial(x); 
            #endregion

            #region problem 08
            //string str = "moohamed";
            //changechar(str, 1, 'x'); 
            #endregion















        }
    }
}

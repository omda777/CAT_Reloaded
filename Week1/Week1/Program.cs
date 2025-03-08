/*
 *  Author : Abdelrhman Emad 
 *  Date   : 8 - 3 - 2025
 *  Task   : Week1 - Cat Reloaded
 */


namespace Week1
{
    internal class Program
    {
        public static void GET_binary(int n)
        {
            if(n == 0) return;
            GET_binary(n/2);
            Console.Write("{0} ",n%2);
        }
        static void Main(string[] args)
        {
            #region Prompts the user to enter 10 numbers and stores them in an array. Finds and prints the largest number in the array using a loop.

            //int[] arr = new int[10];
            //Console.WriteLine("plz enter the element of array: ");
            //int max_num = int.MinValue;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Enter the element {0,2} : ", i+1);
            //    arr[i] = int.Parse(Console.ReadLine()); 

            //    if(arr[i] > max_num)
            //            max_num = arr[i];
            //}
            //Console.WriteLine($"The Max element in Array is :{max_num}");

            #endregion

            #region Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)

            //Console.Write("Enter the character:");
            //int ch = char.Parse(Console.ReadLine());
            //switch(ch) 
            //{
            //    case 'a':
            //    case 'A':
            //    case 'e':
            //    case 'E':
            //    case 'i':
            //    case 'I':
            //    case 'o':
            //    case 'O':
            //    case 'u':
            //    case 'U':
            //        {
            //            Console.WriteLine("vowel");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("consonant");
            //            break;
            //        }

            //}
            #endregion

            #region  Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("PLZ Enter the number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Multiplication Table for {number}\n");

            //for (int i = 1; i <= 12; i++)
            //{
            //    int result = number * i;
            //    Console.WriteLine($"{number,2} X {i,2} = { result ,3}");
            //}
            #endregion

            #region Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("PLZ Enter the number : ");
            //int number  = int.Parse(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("PLZ Enter number : ");
            //int num = int.Parse(Console.ReadLine());
            //GET_binary(num);

            #endregion

            #region Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //Console.Write("PLZ Enter the size of  Array : ");
            //int SizeArray = int.Parse(Console.ReadLine());
            //int [] arr1 = new int[SizeArray];
            //int [] arr2 = new int[SizeArray];
            //int [] result = new int[SizeArray*2];

            //Console.WriteLine("Enter the element for first Array :");
            //for (int i = 0; i < SizeArray; i++)
            //{
            //    Console.Write("Enter the element {0,2} : ", i + 1);
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Enter the element for second Array :");
            //for (int i = 0; i < SizeArray; i++)
            //{
            //    Console.Write("Enter the element {0,2} : ", i + 1);
            //    arr2[i] = int.Parse(Console.ReadLine());
            //} 

            //int p1 = 0 , p2 = 0 , k = 0 ;
            //for (k = 0; k < SizeArray ; k++ ,p1++)
            //{
            //    result[k] = arr1[p1];
            //}
            //for (; k < SizeArray*2 ; k++ ,p2++)
            //{
            //    result[k] = arr2[p2];
            //}
            //Array.Sort (result);

            //Console.WriteLine("The result After merge :");
            //for (int j = 0; j < SizeArray*2; j++)
            //{
            //    Console.Write("{0} ", result[j]);
            //}

            #endregion

            #region  Write a program in C# Sharp to find the second largest element in an array.

            //Console.Write("PLZ Enter the size of  Array : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n]; 
            //for(int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter the element {0} : ",i+1);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int mx = arr[0], second_max = arr[0];
            //for(int i = 1; i < n; i++)
            //{
            //    if(mx < arr[i])
            //    {
            //        second_max = mx;
            //        mx = arr[i];
            //    } 
            //}
            //Console.WriteLine("the second max element is : {0}",second_max);

            //// another solution 

            //Array.Sort(arr);
            //Console.WriteLine("the second max element is : {0}", arr[n-2]);

            #endregion

            #region  Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("PLZ Enter the size of  Array : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter the element {0} : ", i + 1);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

           
            //for (int i = n-1; i >= 0; i--)
            //{
            //    Console.Write("{0} ", arr[i]);
            //}

            //// another solution 
            //Console.WriteLine("\nAnother solution");
            //Array.Reverse(arr);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("{0} ", arr[i]);
            //}

            #endregion

        }
    }
}

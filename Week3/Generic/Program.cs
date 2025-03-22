using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace Week3
{
    internal class Program
    {

        public static void swap<T>(ref T u,ref T x)
        {
            T temp = u;
            u = x;
            x = temp;
        }

        static void Main(string[] args)
        {
            #region Create a generic method Swap<T> that swaps two variables of any type.

            // int x = 9 , y = 5 ;
            // Console.WriteLine($"before swap: x = {x} , y = {y}");
            // swap(ref x,ref y);
            // Console.WriteLine($"after swap: x = {x} , y = {y}");

            // string s = "Abdelrahman";
            //// swap(ref s, ref x); // cant swap string with int 
            #endregion


            #region Create a Dictionary<string, int> to store student names and their grades

            //student student = new student();

            //student.add("Abdelrahman emad", 4);
            //student.add("sara ziad", 3.5f);
            //student.add("mostafa yossef", 2.3f);
            //student.add("eslam emad", 4.6f);

            //student.display("Abdelrahman emad");

            //student.display("mohaned");

            #endregion


            #region Implement a Queue<string> to simulate a customer service line

            //Queue<string> customer = new Queue<string>();

            //customer.Enqueue("Abdelrahman emad");
            //customer.Enqueue("mostafa");
            //customer.Enqueue("ziad");
            //customer.Enqueue("mona");

            //while (customer.Count > 0)
            //{
                
            //   Console.WriteLine($"Serving... customer: {customer.Dequeue()}");
            //}

            #endregion
        }

    }
}

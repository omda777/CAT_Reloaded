using System;
using System.Threading.Tasks;

namespace week5
{
  
    class Program
    {
        static async Task<string> Fetched()
        {
            await Task.Delay(2000);
            return "Data fetched successfuly";
        }

        static async Task<List<int>> getnumber()
        {
            await Task.Delay(1000);
            List<int> list = new List<int> { 1, 2, 3, 4,};
            return list.Where(n => n % 2 == 0).ToList();
        }

        static async Task Main(string[] args)
        {
            #region task 1
            Console.WriteLine("befor fetching");
            string ans = await Fetched();
            Console.WriteLine(ans);
            #endregion

            #region task 2
            List<int> nums = await getnumber();
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            #endregion

        }
    }

}

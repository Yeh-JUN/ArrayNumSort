using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayNumSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 5, 6, 5, 6, 3, 9, 8 };

            Array.Sort(nums);
            foreach (var val in nums)
            {
                Console.Write(val + ",");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

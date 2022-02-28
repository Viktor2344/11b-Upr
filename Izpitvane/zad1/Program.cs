using System;
using System.Linq;
using System.Collections.Generic;


namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = nums[0];
            while (Array.Reverse(number))
            {
                Array.Reverse(number);
                break;
            }
            Console.WriteLine(string.Join(" , ", nums));
           
            


        }
    }
}

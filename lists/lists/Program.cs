﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
         static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int first = nums[0];
            while (nums.Contains(first))
            {
                nums.Remove(first);
            }

            //nums.RemoveAll(x => x == first)

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

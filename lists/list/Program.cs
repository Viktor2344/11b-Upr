using System;
using System.Linq;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command=="print")
                {
                    Console.WriteLine(String.Join(" ", nums));
                    break;
                }

                if (int.TryParse(command, out int n) == true)
                {
                    nums.Sort();
                    Console.WriteLine(string.Join(" ",nums));
                }
                switch (command)
                {
                    case "add": ConsoleCancelEventArgs index = int.Parse(input[1]);
                        var element = int.Parse(input[2]);
                        if (nums.Contains(element) == false) nums.Insert(index, element);
                        break;
                    case "contains": element = int.Parse(input[1]);
                        index = nums.IndexOf(element);
                        break;
                    case "remove": index = int.Parse(input[1]);
                        if (index < 0 || index >= )

                    
                }

            }
        }
    }
}

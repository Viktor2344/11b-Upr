using System;
using System.Linq;
using System.Collections.Generic;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", nums));
                    break;
                }

                string[] elements = command.Split();

                switch (elements[0])
                {
                    case "Instert":
                        int index = int.Parse(number[1]);
                        int number = int.Parse(number[2]);
                        nums.Insert(index, number);
                        break;

                    case "Find":
                        int numbersToSearch = int.Parse(number[1]);
                        Console.WriteLine(nums.IndexOf(numbersToSearch));
                        break;

                    case "Del":
                        int numbersToDel = int.Parse(number[1]);
                        Console.WriteLine(nums.IndexOf(numbersToDel));
                        break;
                }
            }
        }
    }
}

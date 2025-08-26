using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] result = TwoSum(new int[] { 2, 7, 11, 15 }, 9);

        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
    
    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = i;
            }
        }

        return Array.Empty<int>();
    }
}
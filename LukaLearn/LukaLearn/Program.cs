using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0, 1]
        //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].

        int[] nums = { 1, 3, 10, 4 };
        int target = 13;
        int result = TwoSum(nums, target);
        Console.WriteLine($"[{nums[0]}, {nums[1]}]");
    }

    public static void TwoSum()
    {
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"{nums[0]} + {nums[1]");
        }
    }
}

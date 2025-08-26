using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

        //You may assume that each input would have exactly one solution, and you may not use the same element twice.

        //You can return the answer in any order.

        //Example 1:

        //Input: nums = [2, 7, 11, 15], target = 9
        //Output: [0, 1]
        //Explanation: Because nums[0] +nums[1] == 9, we return [0, 1].
        //Example 2:

        //Input: nums = [3, 2, 4], target = 6
        //Output: [1, 2]
        //Example 3:

        //Input: nums = [3, 3], target = 6
        //Output: [0, 1]

        //Constraints:

        //        2 <= nums.length <= 104
        //        - 109 <= nums[i] <= 109
        //        - 109 <= target <= 109
        //Only one valid answer exists.

        //step one: gather up massive numbers in a cycle
        //step two: compare gathered massive numbers to target number
        //step three: implement function for code to not repeat gathered numbers
        //step four: add up gathered numbers and compare the sum to the target number, if incorrect, repeat until it's correct

        //int[] nums = [1, 4, 10, 2];
        int target = 5;

        for ()
        {
            //int[] nums1 = [0];
            //int[] nums2 = [1];
            //int[] nums3 = [2];
            //int[] nums4 = [3];
            int[] nums = [1, 4, 10, 2];

            Console.WriteLine($"{nums}");

            int sum = 5;
        }    
    }
}
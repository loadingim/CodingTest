using System;
using System.Collections.Generic;
using System.Linq;
namespace Day_2
{
    internal class Program
    {

        class Solution
        {
            List<int> number = new List<int>();
            List<int> countNum = new List<int>();
            int answer = -1;
            public int solution(int[] nums)
            {
                nums = nums.Distinct().ToArray();
                if (nums.Length >= 3 && nums.Length <= 50)
                {
                    foreach (int i in nums)
                    {
                        if (i < 1 || i > 1000)
                        {
                            return answer;
                        }
                    }
                    for (int i = 0; i < nums.Length - 2; i++)
                    {
                        for (int j = i + 1; j < nums.Length - 1; j++)
                        {
                            for (int a = j + 1; a < nums.Length; a++)
                            {
                                number.Add(nums[i] + nums[j] + nums[a]);
                            }
                        }
                    }
                    for (int i = 0; i < number.Count; i++)
                    {
                        int count = 0;
                        for (int j = 2; j < number[i] - 1; j++)
                        {

                            if (number[i] % j == 0)
                            {
                                count++;
                            }
                        }
                        if (count == 0)
                        {
                            countNum.Add(number[i]);
                        }
                    }

                }
                return answer = countNum.Count;
            }
        }
        static void Main(string[] args)
        {
            Solution solo = new Solution();
            int[] number = new int[5] { 1, 2, 7, 6, 4};
            int count = solo.solution(number);
            Console.WriteLine(count);
        }
    }
}

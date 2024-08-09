using System;
using System.Collections.Generic;
using System.Linq;
namespace Day_2
{
    // <summary
    // 2024년 8월 6일
    // 문제 : 문제 설명
    // 주어진 숫자 중 3개의 수를 더했을 때 소수가 되는 경우의 개수를 구하려고 합니다.숫자들이 들어있는 배열 nums가 매개변수로 주어질 때,
    // nums에 있는 숫자들 중 서로 다른 3개를 골라 더했을 때 소수가 되는 경우의 개수를 return 하도록 solution 함수를 완성해주세요.
    // 제한사항
    // nums에 들어있는 숫자의 개수는 3개 이상 50개 이하입니다.
    // nums의 각 원소는 1 이상 1,000 이하의 자연수이며, 중복된 숫자가 들어있지 않습니다.
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/12977
    // </summary>
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
        static void Main1(string[] args)
        {
            Solution solo = new Solution();
            int[] number = new int[5] { 1, 2, 7, 6, 4 };
            int count = solo.solution(number);
            Console.WriteLine(count);
        }
    }
}

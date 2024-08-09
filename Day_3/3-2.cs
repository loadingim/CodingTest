using System;
using System.Collections;
using System.Collections.Generic;

namespace Day_3
{
    // <summary
    // 2024년 8월 9일
    // 문제 : 문제 설명
    // 중앙값은 어떤 주어진 값들을 크기의 순서대로 정렬했을 때 가장 중앙에 위치하는 값을 의미합니다. 예를 들어 1, 2, 7, 10, 11의 중앙값은 7입니다.
    // 정수 배열 array가 매개변수로 주어질 때, 중앙값을 return 하도록 solution 함수를 완성해보세요.
    // 제한사항
    // 1 ≤ array의 길이 ≤ 100
    // 0 ≤ array 원소 ≤ 1,000
    // array의 길이는 홀수입니다.
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/120811
    // </summary>

    public class Solution
    {
        public int solution(int[] array)
        {
            int answer = 0;
            Array.Sort(array);
            if (array.Length > 0 && array.Length < 100 && array[array.Length - 1] < 1000 && array[0] > -1000 && array.Length % 2 == 1)
            {
                answer = array[array.Length/2];
            }
            return answer;
        }
        static void Main11(string[] args)
        {
            Solution solo = new Solution();
            solo.solution([10, 7, 2, 1, 11, 3,4,5,6,22,33,44,55,66,77,88,99,100,63]);

           

        }
    }
}

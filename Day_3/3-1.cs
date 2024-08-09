using System;

public class Solution
{
    // <summary
    // 2024년 8월 9일
    // 문제 : 문제 설명
    // 정수 배열 array가 매개변수로 주어질 때, 가장 큰 수와 그 수의 인덱스를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
    // 소수는 1과 자기 자신으로만 나누어지는 수를 의미합니다. (1은 소수가 아닙니다.)
    // 제한사항
    // 1 ≤ array의 길이 ≤ 100
    // 0 ≤ array 원소 ≤ 1,000
    // array에 중복된 숫자는 없습니다.
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/120899
    // </summary>
    public int[] solution(int[] array)
    {
        int[] answer = new int[2];
        int[] arrayTest = array;
        array = array.Distinct().ToArray();
        Array.Sort(arrayTest);

        if (array.Length >= 1 && array.Length <= 100 && arrayTest[arrayTest.Length - 1] < 1000 && arrayTest[0] > 0)
        {
            answer[0] = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    answer[0] = array[i];
                    answer[1] = i;
                }
                else if(array[i] < array[i + 1])
                {
                    answer[0] = array[i+1];
                    answer[1] = i+1;
                }
            }
        }
        return answer;
    }
    static void Mai1(string[] args)
    {
        Solution solo = new Solution();
        solo.solution([1, 8, 3]);

    }
}

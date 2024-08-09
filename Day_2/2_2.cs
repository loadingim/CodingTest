﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    // <summary
    // 2024년 8월 6일
    // 문제 : 문제 설명
    // 1부터 입력받은 숫자 n 사이에 있는 소수의 개수를 반환하는 함수, solution을 만들어 보세요.
    // 소수는 1과 자기 자신으로만 나누어지는 수를 의미합니다. (1은 소수가 아닙니다.)
    // 제한사항
    // n은 2이상 1000000이하의 자연수입니다.
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/12921
    // </summary>


    public class _2_2
    {
        public class Solution
        {
            int answer;
            public int solution(int n)
            {
                int limit = n;
                bool[] primeNumber = new bool[limit + 1];
                if (n >= 2 && n <= 100000)
                {
                    for (int i = 2; i <= n; i++)
                    {
                        primeNumber[i] = true;
                    }

                    for (int i = 2; i * i <= n; i++)    
                    {
                        if (primeNumber[i])
                        {
                            for (int j = i * i ; j <= n; j += i)
                            {
                                primeNumber[j] = false;
                            }
                        }
                    }
                    for (int i = 2; i <= n; i++)
                    {
                        if (primeNumber[i])
                        {
                            answer++;
                        }
                    }

                }
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution solo = new Solution();

            Console.WriteLine(solo.solution(100000));

        }
    }
}

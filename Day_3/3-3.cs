using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    // <summary
    // 2024년 8월 9일
    // 문제 : 문제 설명
    // 문자열로 구성된 리스트 strings와, 정수 n이 주어졌을 때, 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다.
    // 예를 들어 strings가["sun", "bed", "car"] 이고 n이 1이면 각 단어의 인덱스 1의 문자 "u", "e", "a"로 strings를 정렬합니다.
    // 제한사항
    // strings는 길이 1 이상, 50이하인 배열입니다.
    // strings의 원소는 소문자 알파벳으로 이루어져 있습니다.
    // strings의 원소는 길이 1 이상, 100이하인 문자열입니다.
    // 모든 strings의 원소의 길이는 n보다 큽니다.
    // 인덱스 1의 문자가 같은 문자열이 여럿 일 경우, 사전순으로 앞선 문자열이 앞쪽에 위치합니다.
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/12915
    // </summary>

    internal class _3_3
    {
        public class Solution
        {
            public string[] solution(string[] strings, int n)
            {
                string[] answer = new string[] { };
                int num = 0;
                bool loop = true;
                for (int i = 0; i < strings.Length - 1; i++)
                {
                    for (int j = 0; j < strings.Length - i - 1; j++)
                    {
                        if (strings[j][n] > strings[j + 1][n])
                        {
                            string temp = strings[j];
                            strings[j] = strings[j + 1];
                            strings[j + 1] = temp;
                        }
                        else if (strings[j][n] == strings[j + 1][n])
                        {
                            loop = true;
                            while (loop)
                            {
                                if (strings[j][num] == strings[j + 1][num] && strings[j].Length == strings[])
                                {
                                    num++;
                                }
                                else if (strings[j][num] > strings[j + 1][num] )
                                {

                                    string temp = strings[j];
                                    strings[j] = strings[j + 1];
                                    strings[j + 1] = temp;

                                    loop = false;
                                    num = 0;
                                }
                                else
                                {
                                    loop = false;
                                }
                            }
                        }
                    }
                }
                return answer = strings;
            }
        }

        static void Main()
        {
            string[] st = new string[] { "abc", "abcg ","abce", "cdx", "abcd" };

            /*Solution solo = new Solution();
            st = solo.solution(st, 2);*/

            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    // <summary
    // 2024년 8월 12일
    // 문제 : 단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.
    // 재한사항
    // s는 길이가 1 이상, 100이하인 스트링입니다.
    // URL : https://school.programmers.co.kr/learn/courses/30/lessons/12903
    // </summary>
    public class Solution
    {
        public string solution(string s)
        {
            int i;
            string answer = "";
            if (s.Length % 2 == 0)
            {
                i = s.Length / 2;
                answer += s[i-1];
                answer += s[i];
            }
            else if (s.Length % 2 != 0)
            {
                i = s.Length / 2;
                answer += s[i];
            }
            
            return answer;
        }
    }
    internal class _1_2
    {
        static void Main(string[] args)
        {
            Solution solo = new Solution();
            string d = "qwer";
            string f = "abcde";
            d = solo.solution(d);
            f = solo.solution(f);

            Console.WriteLine(d);
            Console.WriteLine(f);
        }
    }
}

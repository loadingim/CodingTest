using System;
namespace Day_4
{
    public class Program
    {
        public class Solution
        {
            List<string> strings = new List<string>();
            public int solution(string s)
            {
                string temp = "";
                int count = 0;
                int i = 0;

                int ft = 0;
                int st = 0;

                while (i < s.Length)
                {
                    char x = s[i];

                    Console.WriteLine(x);

                    while (i < s.Length)
                    {
                        if (s[i] == x)
                        {
                            temp += s[i];
                            ft++;
                        }
                        else
                        {
                            st++;
                            temp += s[i];
                        }

                        if (ft == st)
                        {
                            break;  
                        }

                        i++;
                    }

                    strings.Add(temp);
                    temp = "";
                    count++;
                    i++;
                }

                for (int n = 0; n < strings.Count; n++)
                {
                    Console.WriteLine($"{strings[n]}");
                }

                return count;
            }
        }

        static void Main(string[] args)
        {
            Solution solo = new Solution();

            Console.WriteLine(solo.solution("abracadabra"));
        }
    }
}

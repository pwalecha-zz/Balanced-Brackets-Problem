using System;
using System.Collections.Generic;

namespace Balanced_Brackets
{
    class Program
    {
        private const char openingBracket = '(';
        private const char openingSqBrackett = '[';
        private const char openingBrace = '{';
        private const char closinggBracket = ')';
        private const char closingSqgBracket = ']';
        private const char closingBrace = '}';
        static char[] allowedOpeningBrackets = new char[] { openingBracket, openingSqBrackett, openingBrace };
        static char[] allowedClosingBrackets = new char[] { closinggBracket, closingSqgBracket, closingBrace };
        static Dictionary<char, char> dic = new Dictionary<char, char>();
        
        private static void InitializeCollection()
        {
            dic.Add(openingBrace, closingBrace);
            dic.Add(openingSqBrackett, closingSqgBracket);
            dic.Add(openingBracket, closinggBracket);
        }

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            string[] expressions = new string[t];
            for (int a0 = 0; a0 < t; a0++)
            {
                string expression = Console.ReadLine();
                expressions[a0] = expression;
            }

            for (int a0 = 0; a0 < t; a0++)
            {
                bool val = CheckForBalancedBracket(expressions[a0]);
                Console.WriteLine(val ? "YES" : "NO");
            }
        }

        static bool CheckForBalancedBracket(string input)
        {
            Stack<char> stack = new Stack<char>();
            for(int i = 0; i < input.Length; i++)
            {
                if (allowedOpeningBrackets.Contains(input[i]))
                    stack.Push(input[i]);
                else if (stack.Count > 0 && allowedClosingBrackets.Contains(input[i]) && dic[stack.Peek()] == input[i])
                    stack.Pop();
                else
                {
                    return false;
                }
                    
            }

            return (stack.Count == 0) ? true : false;
        }
    }
}

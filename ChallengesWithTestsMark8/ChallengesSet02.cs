using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char letter in alphabet)
            {
                if (letter == c)
                {
                    return true;
                }
            }
            return false;
            //return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            var div = num % 2;
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            } else
            {
                return numbers.Min() + numbers.Max();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int res = 0;
            if (str1.Length > str2.Length)
            {
                return res = str2.Length;
            } else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int result = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return result;
            } else
            {
                foreach (var number in numbers)
                {
                    result += number;
                }
                return result;
            }
        }

        public int SumEvens(int[] numbers)
        {
            int result = 0;
            if (numbers == null || numbers.Length == 0)
            {
                return result;
            } else
            {
                foreach (var number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        result += number;
                    }
                }
                return result;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var result = 0;
            if (numbers == null || numbers.Count() == 0)
            {
                return false;
            }
            else
            {
                foreach (var number in numbers)
                {
                    result += number;
                }
                return result % 2 != 0;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            long res = 0;
            for (var i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    res++;
                }
            }
            return res;
        }
    }
}

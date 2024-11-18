using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (words == null || words.Count() == 0 || words.Contains(null)) { return containsWord; }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                containsWord = words.Any(x => x.ToLower().Contains(word.ToLower()));
            }
            else
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            bool isPrimeNumber = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrimeNumber = true;
                }
            }

            if (num == 2 || num == 3)
            {
                isPrimeNumber = true;
            }

            if (num == 1)
            {
                isPrimeNumber = false;
            }

            return isPrimeNumber;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uindex;

            for (int i = 0; i < str.Length; i++)
            {
                uindex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uindex = false;
                    }
                }
                if (uindex == true)
                {
                    index = i;
                }
            }

            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxConsecutiveCount = 0;
            int tempCount;

            for (int i = 0; i < numbers.Length; i++)
            {
                tempCount = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if ((numbers[i] != numbers[j]))
                    {
                        break;
                    }
                    tempCount++;
                    if (tempCount > 1 && tempCount > maxConsecutiveCount) { maxConsecutiveCount = tempCount; }
                }
            }

            return maxConsecutiveCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> result = new List<double>();
            if (elements == null || n < 1) { return new double[0]; }

            for (int i = n - 1; i < elements.Count(); i += n)
            {
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}

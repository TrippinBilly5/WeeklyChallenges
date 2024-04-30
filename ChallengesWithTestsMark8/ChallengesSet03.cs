using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var val in vals)
            {
                if (!val) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            var sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsNumber);
            string lettersUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lettersLower = "abcdefghijklmnopqrstuvwxyz";
            string numbers = "1234567890";
            bool hasLettersUpper = false;
            bool hasLettersLower = false;
            bool hasNumbers = false;
            foreach (char c in password)
            {
                if (lettersUpper.Contains(c))
                {
                    hasLettersUpper = true;
                }
                if (lettersLower.Contains(c))
                {
                    hasLettersLower = true;
                }
                if (numbers.Contains(c))
                {
                    hasNumbers = true;
                }
            }
            if (hasLettersUpper && hasLettersLower && hasNumbers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return char.Parse(val.Substring(0, 1));
            //return val[0];
            //return val.FirstOrDefault();
        }

        public char GetLastLetterOfString(string val)
        {
            return char.Parse(val.Substring(val.Length - 1, 1));
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] result = new int[50];
            int counter = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    result[counter] = i;
                    counter++;
                }
            }
            return result;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            //string[] result = new string[words.Length];
            //string temp;
            //for (int i = 0; i < words.Length; i++)
            //{
            //    temp = "";
            //    foreach (char c in words[i])
            //    {
            //        temp += char.IsLetter(c) ? c.ToString().ToUpper() : c.ToString();
            //    }
            //    result[i] = temp;
            //}
            //return result;
        }
    }
}

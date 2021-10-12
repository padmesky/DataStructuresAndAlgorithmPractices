using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAndAlgorithmPractise
{
    class Program
    {
        Dictionary<char, int> letterFrequency = new Dictionary<char, int>();
        int sLenth;
        public int UniqueLetterString(string s)
        {

            char[] charArray = s.ToCharArray();
            sLenth = charArray.Length;
            NumOfIndistinctChars(charArray);
            return NumberOfUniqueChars(charArray);
        }
        private void NumOfIndistinctChars(char[] charArray) 
        {
            
            for (int i= 0; i<charArray.Length; i++) 
            {
                if (letterFrequency.ContainsKey(charArray[i]))
                {
                    letterFrequency[charArray[i]]++;
                }
                else 
                {
                    letterFrequency.Add(charArray[i], 1);
                }
            }
        }

        private int Factoriel(int n)
        {
            int result=1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public int NumberOfUniqueChars(char[] charArray)
        {
            int totalCount = 0;
            for (int i = charArray.Length; i >=1 ; i--)
            {
                totalCount = (Convert.ToInt32(Math.Pow(i, 2)) + i) / 2;
            }
            foreach (var item in letterFrequency.Where(p => p.Value>1))
            {
                totalCount -= (Factoriel(sLenth) / (Factoriel(item.Value) * Factoriel(sLenth - item.Value))) * ((sLenth - item.Value) / sLenth);
            }
            return totalCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int number; //= UniqueLetterString("ABA");
            //Console.WriteLine(number.ToString());
            //number = UniqueLetterString("ABC");
            //Console.WriteLine(number.ToString());
            //number = UniqueLetterString("LEETCODE");
            //Console.WriteLine(number.ToString());

        }
    }
}

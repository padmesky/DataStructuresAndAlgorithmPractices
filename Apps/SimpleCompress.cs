using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithmPractise.Apps
{
    public class SimpleCompress
    {
        public string Compress(string input)
        {
            int repeat = 1;
            char currentChar = input[0];
            StringBuilder compressedString = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                if (currentChar != input[i])
                {
                    AppendCompressedChar(repeat, currentChar, compressedString);
                    currentChar = input[i];
                    repeat = 1;
                }
                else
                {
                    repeat++;
                }
            }
            AppendCompressedChar(repeat, currentChar, compressedString);
            return compressedString.ToString();
        }

        private static void AppendCompressedChar(int repeat, char currentChar, StringBuilder compressedString)
        {
            compressedString.Append(currentChar);
            if (repeat > 1)
            {
                compressedString.Append(repeat.ToString());
            }
        } 
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithmPractise.Apps
{
    public class Warmup
    {
        public int[] RunningSum(int[] inputs) 
        {
            int[] sumArray = new int[inputs.Length];
            int sum = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                sum = sum + inputs[i];
                sumArray[i] = sum;
            }
            return sumArray;
        }

        public int[] NumOfSmaller(int[] inputs)
        {
            int[] numSmaller = new int[inputs.Length];
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int maxElement = int.MinValue;
            int count = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                maxElement = Math.Max(maxElement, inputs[i]);
                if (counts.ContainsKey(inputs[i]))
                {
                    counts[inputs[i]]++;
                }
                else {
                    counts.Add(inputs[i], 1);
                } 
            }
            
            for (int i = 0; i < maxElement+1; i++)
            {
                if (counts.ContainsKey(i))
                {
                    counts[i] += count;
                    count = counts[i];
                }
                else 
                {
                    counts.Add(i, count);
                }
            }

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == 0)
                {
                    numSmaller[i] = 0;
                }
                else 
                {
                    numSmaller[i] = counts[inputs[i]-1];
                }               
            }
            return numSmaller;
        }
    }
}

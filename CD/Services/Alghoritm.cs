using CD.Constants_Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CD.Service
{
    public class Alghoritm
    {
        Stopwatch stopwatch = new Stopwatch();
        List<Tuple<int, decimal>> deltaAverage = new List<Tuple<int, decimal>>();

        public List<int> GetData(Tuple<int, decimal> delataAverage , int[] input)
        {
            List<int> outPut = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                outPut.Add(i);
            }
            return outPut;
        }

        public List<Tuple<int, decimal>> DeltaAverageByBlockSize(int blockSize, int[] input)
        {
            int sum = 0;
            decimal average = 0;
            decimal minVal = input[0];
            int minIndex = 0;
            stopwatch.Start();

            for (int i = 0; i < blockSize; i++)
            {
                sum += BitCount(input[i]);

                average = sum / (decimal)(i + 1);

                if(average < minVal)
                {
                    minVal = average;
                    minIndex = i;
                 }

                deltaAverage.Add(new Tuple<int, decimal>(i + 1, Math.Truncate(10 * average) / 10));
            }

            stopwatch.Stop();
            TotalTime.Alghoritm = stopwatch.Elapsed;

            return deltaAverage;
        }

        private int BitCount(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            if (number < 0)
            {
                number *= -1;
            }

            int result = (int)Math.Log(number, 2.0) + 1;

            return result;
        }
    }
}

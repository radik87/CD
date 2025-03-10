using CD.Constants_Models;
using System;
using System.Diagnostics;

namespace CD.Service
{
    public class Alghoritm
    {
        Stopwatch stopwatch = new Stopwatch();
        public (int index, decimal average) DeltaAverageByBlockSize(int blockSize, int[] input)
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
                    minIndex = i + 1;
                 }
            }

            stopwatch.Stop();
            TotalTime.Alghoritm = stopwatch.Elapsed;

            return (minIndex, Math.Truncate(10 * minVal) / 10);
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

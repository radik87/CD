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

        public List<Tuple<int, decimal>> AverageByBlockSize(int blockSize, int[] input)
        {
            int sum = 0;
            decimal average = 0;

            stopwatch.Start();

            for (int i = 0; i < blockSize; i++)
            {
                sum += BitCount(input[i]);
                average = sum / (decimal)(i + 1);
                deltaAverage.Add(new Tuple<int, decimal>(i + 1, Math.Round(average, 1)));
            }

            stopwatch.Stop();
            TotalTime.Alghoritm = stopwatch.Elapsed;

            return deltaAverage;
        }

        public static int[] GenerateBigarr()
        {
            int[] bigArr = new int[1000001];

            Random rnd = new Random();

            for (int i = 0; i < 100000; i++)
            {
                bigArr[i] = rnd.Next(1234, 999999);
            }
            return bigArr;
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

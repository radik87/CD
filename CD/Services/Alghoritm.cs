using CD.Constants_Models;
using System;
using System.Diagnostics;

namespace CD.Service
{
    public class Alghoritm
    {
        private readonly Stopwatch _stopwatch;
        public Alghoritm(Stopwatch stopwatch)
        {
            _stopwatch = stopwatch;
        }
        public double AverageByBlockSize(int blockSize, int[] input)
        {
            int sum = 0;
            double average = 0;

            _stopwatch.Start();

            for (int i = 0; i < blockSize; i++)
            {
                sum += BitCount(input[i]);
            }

            _stopwatch.Stop();
            TotalTime.Alghoritm += _stopwatch.Elapsed;

            return average = sum / (double)blockSize;
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

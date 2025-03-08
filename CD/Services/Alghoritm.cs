using System;

namespace CD.Service
{
    internal class Alghoritm
    {
        internal double AverageByBlockSize(int blockSize, int[] input)
        {
            int sum = 0;
            double average = 0;

            for (int i = 0; i < blockSize; i++)
            {
                sum += BitCount(input[i]);
            }

            return average = sum / (double)blockSize;
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

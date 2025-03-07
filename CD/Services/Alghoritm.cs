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

        private int BitCount(int val)
        {
            if (val == 0)
            {
                return 1;
            }

            if (val < 0)
            {
                val *= -1;
            }

            int res = (int)Math.Log(val, 2.0) + 1;

            return res;
        }
    }
}

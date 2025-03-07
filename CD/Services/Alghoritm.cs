using System;

namespace CD.Service
{
    internal class Alghoritm
    {
        internal int GetSumBites(int [] input)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += BitCount(input[i]);
            }

            return sum;
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

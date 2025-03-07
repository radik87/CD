using System;

namespace CD.Service
{
    internal class Alghoritm
    {
        internal static int BitCount(int val)
        {
            if(val == 0)
            {
                return 1;
            }

            if(val < 0)
            {
                val *= -1;
            }

            int res = (int)Math.Log(val, 2.0) + 1;

            return res;
        }
    }
}

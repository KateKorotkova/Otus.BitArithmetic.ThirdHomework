using System;
using System.Collections.Generic;
using System.Text;

namespace Otus.BitArithmetic.ThirdHomework.Logic
{
    public class PopCnt
    {
        private static int[] _oneCounterCache;

        static PopCnt()
        {
            _oneCounterCache = new int[256];
            for (var i = 0; i < _oneCounterCache.Length; i++)
            {
                _oneCounterCache[i] = CalculateViaCycle((ulong) i);
            }
        }

        private static int CalculateViaCycle(ulong mask)
        {
            var count = 0;
            while (mask > 0)
            {
                count++;

                mask &= mask - 1;
            }

            return count;
        }

        public static int CalculateViaCache(ulong mask)
        {
            var counter = 0;
            while (mask > 0)
            {
                counter += _oneCounterCache[mask & 255];
                mask >>= 8;
            }

            return counter;
        }
    }
}

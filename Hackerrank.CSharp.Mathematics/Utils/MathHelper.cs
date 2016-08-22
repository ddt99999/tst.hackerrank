using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.CSharp.Utils
{
    public class MathHelper
    {
        public static long ComputeGreatCommonDivisorRec(long a, long b)
        {
            return b == 0 ? a : ComputeGreatCommonDivisorRec(b, a % b);
        }

        public static int ComputeGreatCommonDivisor(int a, int b)
        {
            int x = Math.Max(a, b);
            int y = Math.Min(a, b);
            int r = 0;

            while (y != 0)
            {
                r = x % y;
                x = y;
                y = r;
            }

            return x;
        }

        public static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        public static void Print(int[] arr, int pos)
        {
            if (pos == arr.Length)
                return;

            Console.WriteLine(arr[pos] + " ");

            Print(arr, pos + 1);
        }

        public static long ComputeGreatCommonDivisor(long a, long b)
        {
            long x = Math.Max(a, b);
            long y = Math.Min(a, b);
            long r = 0;

            while (y != 0)
            {
                r = x % y;
                x = y;
                y = r;
            }

            return x;
        }
    }
}

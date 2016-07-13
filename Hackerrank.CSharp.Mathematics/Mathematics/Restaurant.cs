using Hackerrank.CSharp.Core;
using Hackerrank.CSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.CSharp.Mathematics
{
    public class Restaurant : IApplication
    {
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                var arr = Array.ConvertAll(arr_temp, UInt16.Parse);

                UInt16 l = arr[0];
                UInt16 b = arr[1];

                var gcd = l == b ? l : MathHelper.ComputeGreatCommonDivisor(l, b);

                Console.WriteLine((l/gcd)*(b/gcd));
            }
        }
    }
}

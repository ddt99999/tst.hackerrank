using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.CSharp.Codility
{
    public class SameNumberOccurenceCombination
    {
        // basically use the dict to find the unique items then use permutation to get
        // all combination of the positions

        public Dictionary<int, int> table = new Dictionary<int, int>();

        public int GetCombination(int n, int k)
        {
            if (k > n) return 0;
            if (k * 2 > n) k = n - k;
            if (k == 0) return 1;

            int result = n;

            for (int i = 2; i <= k; ++i)
            {
                result *= (n - i + 1);
                result /= i;
            }

            return result;
        }

        public int solution(int[] A)
        {
            int count = 0;
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            for (int i = 0; i < A.Length; i++)
            {
                if (table.TryGetValue(A[i], out count))
                {
                    count++;
                    table[A[i]] = count;
                }

                else
                {
                    table.Add(A[i], 1);
                }

            }
            int sum = 0;
            foreach (var value in table.Values)
            {
                sum += GetCombination(value, 2);
            }

            return sum;
        }
    }
}

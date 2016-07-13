using Hackerrank.CSharp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.CSharp.Mathematics
{
    /*
    Watson gives an integer  to Sherlock and asks him: What is the number of divisors of  that are divisible by 2?.

    Input Format 
    First line contains , the number of testcases. This is followed by  lines each containing an integer .

    Output Format 
    For each testcase, print the required answer in one line.

    Constraints 
    Sample Input

    2
    9
    8
    Sample Output

    0
    3
    Explanation 
    9 has three divisors 1, 3 and 9 none of which is divisible by 2. 
    8 has four divisors 1,2,4 and 8, out of which three are divisible by 2.
        
    */
    public class SherlockAndDivisor : IApplication
    {
        public static int GetDivisorCountDivisibleByN(int number, int n)
        {
            if (number < 0 || n < 0)
                throw new IndexOutOfRangeException("Have to be positive");

            int count = n > 1 ? 0 : 1; // if n = 1, count = 1 else count = 0

            if (n % 2 == 0)
            {
                for (int i = n; i <= number; i += n)
                {
                    //if ((number & (i - 1)) == 0)
                    if (number - i*(number/i) == 0)
                        count++;
                }
            }
            else
            {
                for (int i = n; i <= number; i += n)
                {
                    if ((number % i) == 0)
                        count++;
                }
            }

            return count;
        }

        public void Execute()
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (var i = 0; i < n; i++)
            //{
                //var numString = Console.ReadLine();
                //var number = Int32.Parse(numString);

                Console.WriteLine(GetDivisorCountDivisibleByN(8, 2));
            //}
        }
    }
}

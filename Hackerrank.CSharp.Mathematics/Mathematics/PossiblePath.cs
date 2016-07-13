using Hackerrank.CSharp.Core;
using Hackerrank.CSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.CSharp.Mathematics
{
    /// <summary>

    /// </summary>
    /*
    Let gcd(a, b) be the largest positive integer that divides both a and b. Assume
    gcd(0, 0) = 0. Negative a and b are allowed, but gcd(a, b) is always nonnegative.
    When traveling from (a, b) to a next point, the gcd of the points is maintained.
    To show this, we first notice that any common divisor of a and b divides a + b and
    a−b. So in particular, the greatest one, gcd(a, b), divides a+b and a−b. Therefore,
    gcd(a, b) divides gcd(a + b, b) and gcd(a − b, b). Also, a = (a + b) − b = (a − b) + b, so
    by the same argument, gcd(a+b, b) and gcd(a−b, b) also divides gcd(a, b). Therefore
    they must all be equal.

    So, if gcd(a, b) 6= gcd(x, y), the answer is immediately “NO”, because we can
    only reach points with the same gcd. The more surprising fact is that if gcd(a, b) =
    gcd(x, y), then the answer is “YES”!

    To show this, first note that the individual traversal operations are reversible.
    For example, from (a, b), if we go to (a + b, b), we can go back to (a, b) because
    (a, b) = ((a + b) − b, b). Specifically, the first and third kinds of traversals are reverse
    operations of each other, and the same is true for the second and fourth. So instead
    of saying “(a, b) can reach (x, y)”, we say instead “(a, b) is connected to (x, y)” to
    emphasize the reversibility of the traversal.

    Lemma 0.1. A point (a, b) where g = gcd(a, b) is connected to one of the following
    points: (g, 0), (0, g), (−g, 0), (0, −g).
    Proof. For g = 0, the only point is (0, 0), so the result holds.
    For a fixed g > 0, we’ll prove the statement for all points (a, b) with gcd(a, b) = g
    by induction on increasing |a|+|b|. The number |a|+|b| is always a positive multiple
    of g.

    For the base case, if |a|+|b| = g, then (a, b) is already one of (g, 0), (0, g), (−g, 0),
    (0, −g), so the result holds.
    Now suppose we want to show the result for (a, b) with |a| + |b| > g. Then:
    • If |a| ≤ |b|, then either a − b or a + b has smaller absolute value than b, so we
    go to either (a, a + b) or (a, a − b).
    • If |a| > |b|, then either a − b or a + b has smaller absolute value than a, so we
    go to either (a + b, b) or (a − b, b).

    In any case, we end up with a smaller sum of absolute values, which by induction
    hypothesis is connected to one of (g, 0), (0, g), (−g, 0), (0, −g). Therefore the
    inductive case holds.
    That a − b or a + b has smaller absolute value than max(|a|, |b|) follows from the
    fact that neither of a and b are zero (if one of them is zero and |a| + |b| > g then
    gcd(a, b) > g).
    Now,
    • (g, 0) is connected to (0, −g) because (g, 0) → (g, 0 − g) = (g, −g) → (g + (−g), −g) = (0, −g)
    • (g, 0) is connected to (0, g) because (g, 0) → (g, g + 0) = (g, g) → (g − g, g) = (0, g)
    • (g, 0) is connected to (−g, 0) because (g, 0) is connected to (0, −g) (using the first property), 
    which is connected to (−g, 0) (using the second property).

    Therefore, (g, 0), (0, g), (−g, 0) and (0, −g) are all connected to each other.
    So if gcd(a, b) = gcd(x, y), (x, y) is connected to (a, b) because:
    1. (a, b) is connected to one of (g, 0), (0, g), (−g, 0), (0, −g),
    2. (x, y) is connected to one of (g, 0), (0, g), (−g, 0), (0, −g),
    3. (g, 0), (0, g), (−g, 0) and (0, −g) are all connected to each other.
        
    */
    public class PossiblePath : IApplication
    {
        /*
            Adam is standing at point (a,b) in an infinite 2D grid. He wants to know if he can reach point (x,y) or not. The only operation he can do is to move to point (a+b,b), (a,a+b), (a-b,b), or (a,a-b) from some point (a,b). It is given that he can move to any point on this 2D grid,i.e., the points having positive or negative X(or Y) co-ordinates.

            Tell Adam whether he can reach (x,y) or not.

            Input Format 
            The first line contains an integer, T, followed by T lines, each containing 4 space separated integers i.e. a b x y

            Output Format 
            For each test case, display YES or NO that indicates if Adam can reach (x,y) or not.

            Constraints 
            1 ≤ T ≤ 1000 
            1 ≤ a,b,x,y ≤ 1018

            Sample Input

            3
            1 1 2 3
            2 1 2 3
            3 3 1 1
            Sample Output

            YES
            YES
            NO
            Explanation

            (1,1) -> (2,1) -> (2,3).
        */
        public void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);

                long a = arr[0];
                long b = arr[1];
                long x = arr[2];
                long y = arr[3];

                Console.WriteLine(MathHelper.ComputeGreatCommonDivisor(a, b) == MathHelper.ComputeGreatCommonDivisor(x, y) ? "YES" : "NO");
            }
        }
    }
}

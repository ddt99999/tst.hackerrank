using Hackerrank.CSharp.Core;
using Hackerrank.CSharp.DataStructure;
using Hackerrank.CSharp.Mathematics;
using Hackerrank.CSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankChallenge
{
    public class Solution
    {
        static void Main(string[] args)
        {
            var app = new ReverseArray(new int[] { 1, 4, 3, 2 });
            app.Execute();

            MathHelper.Print(app.Array, 0);

            Console.ReadKey();
        }
    }
}

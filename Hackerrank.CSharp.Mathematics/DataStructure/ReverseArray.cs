using Hackerrank.CSharp.Core;
using Hackerrank.CSharp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hackerrank.CSharp.DataStructure
{
    /* <summary>
        An array is a type of data structure that stores elements of the same type in a contiguous block of memory. In an array, , of size , each memory location has some unique index,  (where ), that can be referenced as  (you may also see it written as ).

        Given an array, , of  integers, print each element in reverse order as a single line of space-separated integers.

        Note: If you've already solved our C++ domain's Arrays Introduction challenge, you may want to skip this.

        Input Format

        The first line contains an integer,  (the number of integers in ). 
        The second line contains  space-separated integers describing .

        Constraints

        Output Format

        Print all  integers in  in reverse order as a single line of space-separated integers.

        Sample Input

        4
        1 4 3 2
        Sample Output

        2 3 4 1
    </summary> */
    public class ReverseArray : IApplication
    {
        public int[] Array { get; private set; }

        public ReverseArray(int[] array)
        {
            Array = array;
        }

        private void Reverse(int[] array, int top, int bottom)
        {
            if (top == bottom || top > bottom)
                return;

            MathHelper.Swap(ref array[top], ref array[bottom]);

            Reverse(array, top + 1, bottom - 1);
        }

        public void Execute()
        {
            if (Array.Length == 0 || Array.Length == 1)
                return;
            Reverse(Array, 0, Array.Length - 1);
        }
    }
}

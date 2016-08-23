using Hackerrank.CSharp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.CSharp.DataStructure
{
    /*
    There are  strings. Each string's length is no more than  characters. There are also  queries. For each query, you are given a string, and you need to find out how many times this string occurred previously.

    Input Format

    The first line contains , the number of strings.
    The next  lines each contain a string.
    The nd line contains , the number of queries.
    The following  lines each contain a query string.

    Sample Input

    4
    aba
    baba
    aba
    xzxb
    3
    aba
    xzxb
    ab
    Sample Output

    2
    1
    0
    Explanation

    Here, "aba" occurs twice, in the first and third string. The string "xzxb" occurs once in the fourth string, and "ab" does not occur at all. 
    */
    public class SparseArray : IApplication
    {
        public Dictionary<string, int> StringDatabase { get; private set; }
        public List<string> Queries { get; private set; }
        public List<int> Results { get; private set; }

        public SparseArray(Dictionary<string, int> stringDb)
        {
            StringDatabase = new Dictionary<string, int>();
            Queries = new List<string>();
            Results = new List<int>();
        }

        public void BuildDatabase(List<string> data)
        {
            var count = 0;

            data.ForEach(x =>
            {
                if (StringDatabase.TryGetValue(x, out count))
                {
                    count++;
                    StringDatabase[x] = count;
                }
                else
                {
                    StringDatabase.Add(x, 1);
                }
            });
        }

        public void GetQueries(List<string> queries)
        {
            queries.ForEach(x => Queries.Add(x));
        }

        public void Execute()
        {
            var count = 0;
            Queries.ForEach(x => 
            {
                if (StringDatabase.TryGetValue(x, out count))
                {
                    Results.Add(count);
                }
            });
        }
    }
}

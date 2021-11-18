using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsForPracticing.Algo.GridTraveller;

public class GridTravellerSolver
{
    public uint Solve(uint rows, uint columns)
    {
        var memo = new Dictionary<string, uint>();
        return MemoizedGridTraveller(rows, columns, memo);
    }

    public uint MemoizedGridTraveller(uint r, uint c, Dictionary<string, uint> memo)
    {
        string key = $"{r},{c}";

        if (memo.TryGetValue(key, out uint value))
            return value;

        if (r == 1 && c == 1) return 1;
        if (r == 0 || c == 0) return 0;

        var answer = MemoizedGridTraveller(r - 1, c, memo) + MemoizedGridTraveller(r, c - 1, memo);
        memo.Add(key, answer);

        return memo[key];
    }
}


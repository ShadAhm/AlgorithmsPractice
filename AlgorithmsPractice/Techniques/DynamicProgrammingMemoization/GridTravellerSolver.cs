namespace AlgorithmsPractice.Techniques.DynamicProgrammingMemoization
{
    public class GridTravellerSolver
    {
        /* What is the minimum number of moves for you to be travel from the top-left of a grid
         * to the bottom right of the grid. 
         * 
         * No diagonal movements. E.g:
         * 
         * |s| | | 
         * | | | | 
         * | | |e| 
         * 
         * Answer: 4
         */
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
}

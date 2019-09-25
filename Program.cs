using System;
using System.Linq;
using static System.Console;

namespace highest_rank_num
{
    class Program
    {
        static void Main(string[] args)
        {
            // var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 };
            // var arr = new int[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 };
            // var arr = new int[] { 12, 12, 10, 10, 10, 8, 8, 8, 1, 3, 4, 7, 13, 13, 15, 12 };
            // var arr = new int[] { 1, 1, 1, 1, 1, 2, 2, 8 };
            // var arr = new int[] { 1 };
            // var arr = new int[] { 12, 12, 10, 10, 10, 8, 8, 8, 1, 3, 4, 7, 13, 13, 15, 12, 1, 1, 1, 1, 1, 2, 2, 8, 3, 6, 9, 18, 20, 25, 40, 25, 50, 90, 100, 3, 6, 2, 12, 19, 17, 12, 12, 50, 50, 50, 50, 50, 50 };
            // var arr = new int[] { 0, 0, 0, 1 };
            // var arr = new int[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10, 12, 10, 8, 12, 7, 6, 4, 10, 10,12, 12, 10, 8, 12, 7, 6, 4, 10, 12, 10, 10, 10, 12, 8, 12, 7, 6, 4, 10, 12 };
            // var arr = new int[] { 5, 3, 5, 6, 4, 11, 10, 3, 4, 10, 4, 5, 4, 8, 6, 6, 4, 4, 6, 6, 5, 3, 6, 4, 6, 5, 7, 10, 9, 5, 8, 7, 5, 10, 7, 6, 8, 4, 9, 3, 10, 7, 8, 3, 9, 3, 5, 10, 8, 6, 10, 10, 8, 6, 10, 6, 10, 9, 3, 7, 3, 8, 4, 4, 11, 8, 9, 10 };
            var arr = new int[] { 10, 12, 8, 12, 7, 6, 4, 10, 12, 10 };
            // var arr = new int[] { 9, 10, 4, 3, 9, 3, 11, 11, 5, 9, 9 };
            // var arr = new int[] { 8, 11 };
            HighestRank(arr);
        }

        public static int HighestRank(int[] arr)
        {
            
            var groups = arr.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            int mode = groups.First(g => g.Count() == maxCount).Key;

            int high = arr.OrderByDescending(i => i).First();

            if (maxCount == 1)
            {
                WriteLine(high);
                return high;
            }


            WriteLine(mode);
            return mode;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tetris_Duo
{
    class Models
    {
        private static readonly int[][] firstdBlock =
             {
                new[] { 1 },
                new[] { 1 },
                new[] { 1 },
                new[] { 1 }
            };

        private static readonly int[][] secondBlock =
            {
                new[] { 0, 1 },
                new[] { 0, 1 },
                new[] { 1, 1 }
            };

        private static readonly int[][] thirdBlock =
            {
                new[] { 1, 0 },
                new[] { 1, 0 },
                new[] { 1, 1 }
            };

        private static readonly int[][] fourthBlock =
           {
                new[] { 1, 1 },
                new[] { 1, 1 }
            };

        private static readonly int[][] fifthBlock =
          {
                new[] { 0, 1, 1 },
                new[] { 1, 1, 0 }
            };

        private static readonly int[][] sixthBlock =
         {
                new[] { 1, 1, 1 },
                new[] { 0, 1, 0 }
            };

        private static readonly int[][] seventhBlock =
         {
                new[] { 1, 1, 0 },
                new[] { 0, 1, 1 }
            };

        public static List<int[][]> AllBlocks =>
            new List<int[][]> { fifthBlock, secondBlock, thirdBlock, fourthBlock, fifthBlock, sixthBlock, seventhBlock };

    }

}

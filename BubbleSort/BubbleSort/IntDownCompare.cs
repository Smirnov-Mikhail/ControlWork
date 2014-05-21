namespace BubbleSortNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class comparison int to reduction.
    /// </summary>
    public class IntDownCompare : IComparer<int>
    {
        /// <summary>
        ///  Method for comparison int to reduction.
        /// </summary>
        /// <param name="first"> First number. </param>
        /// <param name="second"> Second number. </param>
        /// <returns></returns>
        public int Compare(int first, int second)
        {
            if (first == second)
                return 0;
            else if (first > second)
                return -1;
            else
                return 1;
        }
    }
}

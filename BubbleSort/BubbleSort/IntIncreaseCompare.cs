namespace BubbleSortNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class comparison int to increase.
    /// </summary>
    public class IntIncreaseCompare : IComparer<int>
    {
        /// <summary>
        /// Method for comparison int to increase.
        /// </summary>
        /// <param name="first"> First number. </param>
        /// <param name="second"> Second number. </param>
        /// <returns></returns>
        public int Compare(int first, int second)
        {
            if (first == second)
                return 0;
            else if (first > second)
                return 1;
            else
                return -1;
        }
    }
}

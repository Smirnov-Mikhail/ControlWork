namespace BubbleSortNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class comparison string to increase.
    /// </summary>
    public class StringLengthIncreaseCompare : IComparer<string>
    {
        /// <summary>
        /// Method for comparison string to increase.
        /// </summary>
        /// <param name="first"> First line. </param>
        /// <param name="second"> Second line. </param>
        /// <returns></returns>
        public int Compare(string first, string second)
        {
            if (first.Length == second.Length)
                return 0;
            else if (first.Length > second.Length)
                return 1;
            else
                return -1;
        }
    }
}

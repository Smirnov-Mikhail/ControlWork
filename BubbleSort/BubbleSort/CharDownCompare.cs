namespace BubbleSort
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class comparison char to reduction.
    /// </summary>
    public class CharDownCompare : IComparer<char>
    {
        /// <summary>
        /// Method for comparison char to reduction.
        /// </summary>
        /// <param name="first"> First symbol. </param>
        /// <param name="second"> Second symbol. </param>
        /// <returns></returns>
        public int Compare(char first, char second)
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

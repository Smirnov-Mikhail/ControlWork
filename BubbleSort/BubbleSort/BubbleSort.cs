namespace BubbleSortNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Bubble sorting.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BubbleSort<T>
    {
        /// <summary>
        /// Method for sorting.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="comparer"></param>
        public static void Sort(ref T[] array, IComparer<T> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i; j < array.Length; j++)
                    if (comparer.Compare(array[i], array[j]) == 1)
                        Swap(ref array, i, j);
        }

        /// <summary>
        /// Swap elements.
        /// </summary>
        /// <param name="array"> Array in which this elements. </param>
        /// <param name="firstIndex"> Swaped element. </param>
        /// <param name="secondIndex"> Swaped element. </param>
        private static void Swap(ref T[] array, int firstIndex, int secondIndex)
        {
            T temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}

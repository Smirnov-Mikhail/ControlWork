namespace Queue
{
    using System.Collections.Generic;

    public class Queue<T>
    {
        public Queue()
        {
            list = new List<QueueElement<T>>();
        }

        /// <summary>
        /// Add element in the end of Queue.
        /// </summary>
        /// <param name="value"> Added element. </param>
        /// <param name="priority"> Priority of element. </param>
        public void Enqueue(T value, int priority)
        {
            QueueElement<T> newElement;
            newElement.priority = priority;
            newElement.value = value;
            list.Add(newElement);
        }

        /// <summary>
        /// Return element with the highest priority.
        /// </summary>
        /// <returns></returns>
        public object Dequeue()
        {
            if (list.Count == 0)
                throw new EmptyQueueException();

            int IndexMaxPriority = 0;
            T result = default(T);

            for (int i = 0; i < list.Count; i++)
                if (list[i].priority > list[IndexMaxPriority].priority)
                    IndexMaxPriority = i;

            result = list[IndexMaxPriority].value;
            QueueElement<T> temp;
            temp.value = result;
            temp.priority = IndexMaxPriority;
            list.Remove(temp);

            return result;
        }

        /// <summary>
        /// Test queue for empty.
        /// </summary>
        /// <returns></returns>
        public bool TestForEmpty()
        {
            return list.Count == 0;
        }

        /// <summary>
        /// Element of Queue.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private struct QueueElement<T>
        {
            public T value;
            public int priority;
        }

        private List<QueueElement<T>> list;
    }
}

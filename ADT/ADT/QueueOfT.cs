using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public class Queue<T>
    {
        private LinkedList<T> queue = new LinkedList<T>();
        public int Count { get { return queue.Count; } }
        public bool IsEmpty
        {
            get
            {
                if (Count == 0)
                    return true;
                else
                    return false;
            }
        }

        public void Enqueue(T o)
        {
            queue.Append(o);
        }

        public T Dequeue()
        {
            T obj = queue.First;
            queue.DeleteAt(0);
            return obj;
        }

    }
}

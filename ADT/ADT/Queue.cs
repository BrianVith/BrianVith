using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public class Queue
    {
        private LinkedList queue = new LinkedList();
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

        public void Enqueue(object o)
        {
            queue.Append(o);
        }

        public object Dequeue()
        {
            object obj = queue.First;
            queue.DeleteAt(0);
            return obj;
        }

    }
}

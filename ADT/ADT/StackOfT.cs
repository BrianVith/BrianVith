using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public class Stack<T>
    {
        private LinkedList<T> stack = new LinkedList<T>();
        public int Count { get { return stack.Count; } }
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

        public void Push(T o)
        {
            stack.Append(o);
        }

        public T Pop()
        {
            T obj = stack.Last;
            stack.DeleteAt(Count - 1);
            return obj;

        }

        public T Peek()
        {
            return stack.Last;
        }


    }
}

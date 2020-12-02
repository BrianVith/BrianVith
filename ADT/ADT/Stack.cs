using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public class Stack
    {
        private LinkedList stack = new LinkedList();
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

        public void Push(object o)
        {
            stack.Append(o);
        }

        public object Pop()
        {
            object obj = stack.Last;
            stack.DeleteAt(Count-1);
            return obj;
        }

        public object Peek()
        {
            return stack.Last;
        }


    }
}

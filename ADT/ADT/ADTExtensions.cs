using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public static class ADTExtensions
    {
        public static void ForEach<T>(this LinkedList<T> linkedList, Action<T> action)
        {
            foreach (T item in linkedList)
            {
                action(item);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public interface ILinkedList<T>
    {
        int Count { get; }
        T First { get; }
        T Last { get; }

        void Insert(T o);
        void Append(T o);
        void InsertAt(int index, T o);
        void DeleteAt(int index);
        T ItemAt(int index);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public interface ILinkedList
    {

        int Count { get; }
        object First { get; }
        object Last { get; }

        void Insert(object o);
        void Append(object o);
        void InsertAt(int index, object o);
        void DeleteAt(int index);
        object ItemAt(int index);
    }
}

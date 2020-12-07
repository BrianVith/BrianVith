using System;
using System.Collections.Generic;
using System.Text;

namespace ADT
{
    public class LinkedList : ILinkedList
    {
        private class Node
        {
            public object Data { get; set; }
            public Node Next { get; set; }
            public Node Prev { get; set; }

            public override string ToString()
            {
                return Data.ToString();
            }
        }

        private Node head;

        private int count;
        public int Count
        {
            get { return count; }
        }

        public object First
        {
            get { return ItemAt(0); }
        }

        public object Last
        {
            get { return ItemAt(count-1); }
        }

        public void Insert(object o)
        {
            InsertAt(0, o);
        }

        public void Append(object o)
        {
            InsertAt(count, o);
        }

        public void InsertAt(int index, object o)
        {
            Node newNode = new Node();
            newNode.Data = o;

            if (head == null)
            {
                head = newNode;
                head.Prev = null;
                count++;
                return;
            }

            if (index == 0)
            {
                newNode.Next = head;
                head.Prev = newNode;
                newNode.Prev = null;
                head = newNode;
                count++;
                return;
            }

            Node current = head;
            int c = 0;


            while (c < index - 1)
            {
                current = current.Next;
                c++;
            }

            if (current.Next == null)
            {
                current.Next = newNode;
                newNode.Prev = current;
                newNode.Next = null;
                count++;
                return;
            }

            Node storeNext = current.Next;
            current.Next = newNode;
            newNode.Prev = current;
            newNode.Next = storeNext;
            storeNext.Prev = newNode;
            count++;
        }
        public void DeleteAt(int index)
        {
            Node current = head;

            if (index == 0)
            {
                head = head.Next;
                if (head != null)
                    head.Prev = null;
                count--;
                return;
            }

            int c = 0;
            while (c < index)
            {
                current = current.Next;
                c++;
            }

            Node storePrev = current.Prev;

            if (current.Next == null)
            {
                storePrev.Next = null;
                count--;
                return;
            }

            Node storeNext = current.Next;

            current.Next = storeNext;
            storeNext.Prev = storePrev;
            storePrev.Next = storeNext;
            current = null;
            count--;
        }
        public object ItemAt(int index)
        {
            if (head == null)
            {
                return null;
            }

            Node current = head;

            int c = 0;
            while(c < index)
            {
                current = current.Next;
                c++;
            }

            return current.Data;
        }

        public string RoundtripString()
        {
            string roundTrip = "";
            Node current = head;
            roundTrip += head.Data;
            while (current.Next != null)
            {
                current = current.Next;
                roundTrip += "\n" + current.Data;
            }

            while (current.Prev != null)
            {
                current = current.Prev;
                roundTrip += "\n" + current.Data;
            }

            return roundTrip;
        }

        public void Reverse()
        {
            Node current = head;
            Node temp = null;
            while (current != null)
            {
                temp = current.Prev;
                current.Prev = current.Next;
                current.Next = temp;
                if (current.Prev == null) head = current;
                current = current.Prev;
            }
        }

        public void Swap(int index)
        {
            Node current = head;

            if (ItemAt(index) != null && ItemAt(index + 1) != null)
            {
                int c = 0;
                while (c < index)
                {
                    current = current.Next;
                    c++;
                }

                Node storeNext = current.Next;
                Node storeNextNext = current.Next.Next;
                Node storePrev = current.Prev;

                if (storeNextNext != null)
                    storeNextNext.Prev = current;

                if (storePrev != null)
                {
                    storePrev.Next = storeNext;
                    storeNext.Prev = storePrev;
                }

                current.Prev = storeNext;
                current.Next = storeNext.Next;
                storeNext.Next = current;

                if (index == 0)
                {
                    head = storeNext;
                }
            }
        }

        //public override string ToString()
        //{
        //    Node current = head;
        //    string str = "";
        //    for (int i = 0; i < Count; i++)
        //    {
        //        if (i == 0)               
        //            str += $"{current}";              
        //        else
        //        {
        //          str += $"\n{current}";                                  
        //        }
        //        current = current.Next;
        //    }
        //    return str;
        //}

        public override string ToString()
        {
            Node current = head;
            string str = "";
            while(current != null)
            {
                str += current;

                if (current.Next != null)
                    str += "\n";

                current = current.Next;
            }
            return str;
        }


    }
}

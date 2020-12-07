using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
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
        public static void ForEach(this LinkedList<ClubMember> linkedList, Action<ClubMember> action)
        {
            foreach (ClubMember clubMember in linkedList)
            {
                action(clubMember);
            }
        }

    }
}

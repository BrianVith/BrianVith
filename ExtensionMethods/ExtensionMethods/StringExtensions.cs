using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    public static class StringExtensions
    {

        public static string Shift(this string str, int shift)
        {

            if (shift > 0)
            {
                string shiftSaved = str.Substring((str.Length - shift));
                str = str.Remove(str.Length - shift);
                str = str.Insert(0, shiftSaved);
            }
            return str;
        }
    }
}

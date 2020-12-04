using System;

namespace BonusApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, double, double> one;
            Func<int, int> two;

            //one = delegate (int x, int y) { int result = x + y; return result; };
            //one = (x,y) => { double result = x + y; return result; }; // lambda statement

            one = (x,y) => x + y; // lambda statement
            Console.WriteLine("one: " + one(1,2)); // 1 + 2 = 3

            //two = delegate (int x) { int result = 0; for (int i = 0; i < 10; i++) { result += x; } return result; };
            two = x => { int result = 0; for (int i = 0; i < 10; i++) { result += x; } return result; }; // lambda statement
            Console.WriteLine("two: " + two(9)); // 9 * 10 = 90
            
            two = x => x * 10; // lambda expression
            Console.WriteLine("two: " + two(9)); // 9 * 10 = 90

            //two = delegate (int x) { return x * x; };
            two = x => x * x; // lamda expression
            Console.WriteLine("two again: " + two(5)); // 5^2 = 25

        }
    }
}

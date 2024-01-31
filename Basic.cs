using System;

namespace UnitTestingLibrary
{
    public class Basic
    {
        public static Func<int, int, int> add = (a, b) => a + b;
        public static Func<int, int, int> mul = (a, b) => a * b;
        public static Func<int, int, int> sub = (a, b) => a - b;
        public static Func<int, int, int> div = (a, b) => a / b;
    }
}

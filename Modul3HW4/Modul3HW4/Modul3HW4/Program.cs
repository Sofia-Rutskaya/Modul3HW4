using System;

namespace Modul3HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var first = new FirstTask();
            first.CountSum += first.Sum;
            first.CountSum += first.Sum;
            first.SumMethod(2, 5);
            var second = new SecondTask();
            second.LINQ();
        }
    }
}

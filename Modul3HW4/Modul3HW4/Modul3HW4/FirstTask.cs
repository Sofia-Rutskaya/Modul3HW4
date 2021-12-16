using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class FirstTask
    {
        public event Func<double, double, double> CountSum;

        public double Sum(double x, double y) => x + y;

        public static void TryCatch(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void SumMethod(double x, double y)
        {
            TryCatch(() => MethodCountSum(x, y));

            void MethodCountSum(double x, double y)
            {
                double sumMethod = 0;
                foreach (Func<double, double, double> item in CountSum.GetInvocationList())
                {
                    sumMethod += item.Invoke(x, y);
                }

                Console.WriteLine($"Sum Method: {sumMethod}");
            }
        }
    }
}

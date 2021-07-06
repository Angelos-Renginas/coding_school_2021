using System;

namespace Session_23_Exercises {
    public class FibonacciCalculator : IFibonacciCalculator {


        private readonly IFibonacciCalculator fibonacciCalculator;

        public FibonacciCalculator(IFibonacciCalculator fibonacciCalculator) {
            this.fibonacciCalculator = fibonacciCalculator;
        }

        public long FibonacciSeries(long n) {
            if (n == 0) {
                return 0;
            }
            if (n == 1) {
                return 1;
            }
            if (n > 1 && n <= 99) {
                int a = 0, b = 1, c = 0;

                for (int i = 1; i < n; i++) {
                    c = a + b;
                    Console.Write(" {0}", c);
                    a = b;
                    b = c;
                }
                return c;
            }
            if (n < 0) {
                throw new ArgumentException("n cannot be less than 0", nameof(n));
            }
            throw new ArgumentException("Fibonacci result number is too big", nameof(n));
        }
    }
}

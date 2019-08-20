using System;

namespace factorial_with_test
{
    public class Factorial
    {
        public int getFactorialNumber(int number)
        {
            return
                number == 0
                ? 1
                : number * getFactorialNumber(number - 1);
        }
    }
}

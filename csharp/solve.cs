using System;
using System.Numerics;

public static class ParenthesisCounter
{
    public static BigInteger CountWellFormedParenthesis(int n)
    {
        if (n < 0) throw new ArgumentException("");

        BigInteger result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= 2 * n - i;
            result /= i + 1;
        }

        return result / (n + 1);
    }
}

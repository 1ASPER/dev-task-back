using System.Numerics;

public static class ParenthesesCounter {
    public static BigInteger CountWellFormedParenthesis(int nCouples) {
        if (nCouples < 0) throw new ArgumentException("nCouples must be non-negative");
        return Catalan(nCouples);
    }

    private static BigInteger Catalan(int n) {
        BigInteger result = 1;
        for (int i = 1; i <= n; i++) {
            result = result * (2 * (2 * n - i + 1)) / (i + 1);
        }
        return result;
    }
}
using NUnit.Framework;
using System.Numerics;

[TestFixture]
public class ParenthesisCounterTests
{
    [TestCase(0, 1)]
    [TestCase(1, 1)]
    [TestCase(2, 2)]
    [TestCase(3, 5)]
    [TestCase(4, 14)]
    [TestCase(15, 9694845)]
    public void CatalanValues_AreCorrect(int input, long expected)
    {
        var result = ParenthesisCounter.CountWellFormedParenthesis(input);
        Assert.That((long)result, Is.EqualTo(expected));
    }
}

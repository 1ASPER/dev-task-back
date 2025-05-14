using NUnit.Framework;
using System.Numerics;

[TestFixture]
public class ParenthesesCounterTests {
    [Test]
    public void Test_n1() {
        Assert.AreEqual(BigInteger.Parse("1"), ParenthesesCounter.CountWellFormedParenthesis(1));
    }

    [Test]
    public void Test_n15() {
        Assert.AreEqual(BigInteger.Parse("9694845"), ParenthesesCounter.CountWellFormedParenthesis(15));
    }
}
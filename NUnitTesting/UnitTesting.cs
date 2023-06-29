using FluentAssertions;
using NUnit.Framework;

namespace NUnitTesting;

public class UnitTesting
{
    private int _valoreIniziale;

    [SetUp]
    public void Init()
    {
        _valoreIniziale = 42;
    }

    [Test]
    public void SimpleTest()
    {
        _valoreIniziale.Should().BeGreaterThan(0);
    }

    [TestCase(1, true)]
    [TestCase(2, true)]
    [TestCase(-44, false)]
    public void MultipleTest(int value, bool expected)
    {
        var actual = _valoreIniziale + value;

        if (expected)
        {
            actual.Should().BePositive();
        }
        else
        {
            actual.Should().BeNegative();
        }
    }
}

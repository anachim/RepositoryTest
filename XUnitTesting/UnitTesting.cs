using FluentAssertions;
using Xunit;

namespace XUnitTesting;

public class UnitTesting
{
    private int _valoreIniziale;

    public UnitTesting()
    {
        _valoreIniziale = 42;
    }

    [Fact]
    public void SimpleTest()
    {
        _valoreIniziale.Should().BeGreaterThan(0);
    }

    [Theory]
    [InlineData(1, true)]
    [InlineData(2, true)]
    [InlineData(-44, false)]
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
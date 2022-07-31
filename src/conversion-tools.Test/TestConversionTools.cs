using Xunit;
using FluentAssertions;
using conversion_tools;
using System;

namespace conversion_tools.Test;

public class TestFirstRequirement{
    [Theory]
    [InlineData("1", 1)]
    public void TestConvertStrToInt(string entry, int expected)
    {
        var classForTest = new ConversionTools();
        classForTest.strVariable = entry;
        classForTest.strVariable.Should().Be(entry);

        var response = classForTest.strVariable is string;
        response.Should().Be(true);

        classForTest.ConvertStrToInt();
        classForTest.intVariable.Should().Be(expected);

        var response1 = classForTest.intVariable is int;
        response1.Should().Be(true);
    }
}

public class TestSecondRequirement{
    [Theory]
    [InlineData("1.0", 1.0)]
    public void TestConvertStrToDouble(string entry, double expected)
    {
        var classForTest = new ConversionTools();
        classForTest.strVariable = entry;
        classForTest.strVariable.Should().Be(entry);

        var response = classForTest.strVariable is string;
        response.Should().Be(true);

        classForTest.ConvertStrToDouble();
        classForTest.doubleVariable.Should().Be(expected);

        var response1 = classForTest.doubleVariable is double;
        response1.Should().Be(true);
    }
}

public class TestThirdRequirement{
    [Theory]
    [InlineData(1, "1")]
    public void TestConvertIntToStr(int entry, string expected)
    {
        throw new NotImplementedException();
    }
}

public class TestFourthRequirement{
    [Theory]
    [InlineData(4.1, "4.1")]
    public void TestConvertDoubleToStr(double entry, string expected)
    {
        throw new NotImplementedException();
    }
}

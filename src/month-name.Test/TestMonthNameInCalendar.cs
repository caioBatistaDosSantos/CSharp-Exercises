using Xunit;
using FluentAssertions;
using System;

namespace month_name.Test;

public class TestMonthNameInCalendar
{
    [Theory]
    [InlineData(1, "Janeiro")]
    [InlineData(2, "Fevereiro")]
    [InlineData(3, "Março")]
    [InlineData(4, "Abril")]
    public void TestMonthNameInCalendarSucess(int month, string expected)
    {
        var result = MonthNameInCalendar.MonthName(month);
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(0, "inválido")]
    public void TestMonthNameInCalendarOutOfRange(int month, string expected)
    {
        var result = MonthNameInCalendar.MonthName(month);
        result.Should().Be(expected);
    }
}
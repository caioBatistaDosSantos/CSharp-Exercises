using Xunit;
using FluentAssertions;
using System;

namespace ShippingCalculator.Test
{
    public class TestShippingCalculator
    {
        [Theory]
        [InlineData(43, 25)]
        [InlineData(55, 20)]
        [InlineData(101, 15)]
        [InlineData(201, 0)]
        public void TestCalculateShippingSuccess(double orderPrice, int resultExpected)
        {
          var response = new ShippingCalculator();

          response.CalculateShipping(orderPrice).Should().Be(resultExpected);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        public void TestCalculateShippingException(double orderPrice)
        {
          var response = new ShippingCalculator();

          // https://fluentassertions.com/exceptions/
          Action error = () =>  response.CalculateShipping(orderPrice);
          error.Should().Throw<Exception>();
        }
    }
}

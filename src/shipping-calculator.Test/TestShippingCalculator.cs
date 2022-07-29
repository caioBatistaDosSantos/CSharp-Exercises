using Xunit;
using FluentAssertions;
using System;

namespace ShippingCalculator.Test
{
    public class TestShippingCalculator
    {
        [Theory]
        [InlineData(43, 25)]
        public void TestCalculateShippingSuccess(double orderPrice, int resultExpected)
        {
          throw new NotImplementedException();   
        }

        [Theory]
        [InlineData(2)]
        public void TestCalculateShippingException(double orderPrice)
        {
          throw new NotImplementedException();   
        }
    }
}

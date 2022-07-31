using Xunit;
using System.IO;
using System;
using election_day;
using FluentAssertions;

namespace election_day.Test;

[Collection("Sequential")]
public class TestFirstReq
{
    [Theory]
    [InlineData(1)]
    public void TestGetCountVoters(int countVoters)
    {
        using (var input = new StringReader(countVoters.ToString()))
        {
            Console.SetIn(input);
            var instanceClass = new BallotBox();

            var response = instanceClass.GetCountVoters();
            response.Should().Be(countVoters);
        }
    }
}

using Xunit;
using FluentAssertions;
using System.IO;
using System;

namespace test_message.Test;

public class TestPrint
{
    [Theory]
    [InlineData("Olá Mundo", "Olá Mundo")]
    [InlineData("Hello World", "Hello World")]
    [InlineData("testando", "testando")]
    [InlineData("test", "test")]
    [InlineData("xablau", "xablau")]
    public void TestPrintMsgSucess(string Send, string Expected)
    {
        using (var NewOutput = new StringWriter())
        {
            Console.SetOut(NewOutput);

            Message.PrintMsg(Send);

            string result = NewOutput.ToString().Trim();

            result.Should().Be(Expected);      
        }
    }
}
using FluentAssertions;
using Xunit;

namespace CharacterCounter.Test;

public class TestCharacterCounter
{    

        [Theory]
        [InlineData("1", 1)]
        [InlineData("Isso é um texto", 15)]
        [InlineData("Eu sou uma pessoa desenvolvedora formada na Trybe", 49)]
        public void TestCharacterCounterSuccess(string text, int resultExpected)
        {
            var expect = new CharacterCounter();

            expect.Action(text).Should().Be(resultExpected);
        }

        [Theory]
        [InlineData(null)]
        public void TestCharacterCounterException(string text)
        {
            var expect = new CharacterCounter();

            Action act = () =>  expect.Action(text);

            act.Should().Throw<NullReferenceException>();
        }
}
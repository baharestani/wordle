using Xunit;
using FluentAssertions;
using System;
using Wordle;

namespace wordle.tests
{
    public class GameTests
    {
        [Theory]
        [InlineData("word to guess", "short")]
        [InlineData("word to guess", "longer than word to guess")]
        public void CheckThrowsErrorWhenLengthMismatches(string word, string guess)
        {
            var game = new Game(word);
            var act = () => game.Check(guess);
            act.Should().Throw<Exception>();
        }
    }
}
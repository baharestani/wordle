using Xunit;
using FluentAssertions;
using System;
using Wordle;
using System.Linq;

namespace wordle.tests
{
    public class GameTests
    {
        [Theory]
        [InlineData("word", "wor")]
        [InlineData("word", "words")]
        public void CheckThrowsErrorWhenLengthMismatches(string word, string guess)
        {
            var game = new Game(word);
            var act = () => game.Check(guess);
            act.Should().Throw<Exception>();
        }

        [Fact]
        public void CheckReturnsValidResult()
        {
            const string Guess = "road";
            var game = new Game("word");
            var result = game.Check(Guess).ToArray();
            result[Guess.IndexOf("r")].Should().Be(InspectionResults.Present);
            result[Guess.IndexOf("o")].Should().Be(InspectionResults.Exact);
            result[Guess.IndexOf("a")].Should().Be(InspectionResults.Absent);
            result[Guess.IndexOf("d")].Should().Be(InspectionResults.Exact);
        }

    }
}
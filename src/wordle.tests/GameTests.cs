using Xunit;
using FluentAssertions;
using System;
using Wordle;
using System.Linq;
using Moq;

namespace wordle.tests
{
    public class GameTests
    {
        [Theory]
        [InlineData("word", "wor")]
        [InlineData("word", "words")]
        public void CheckThrowsErrorWhenLengthMismatches(string word, string guess)
        {
            var wordProvider = new Mock<IWordProvider>();
            wordProvider.Setup(p => p.GetWord()).Returns(word);
            var game = new Game(wordProvider.Object);

            var act = () => game.Check(guess);

            act.Should().Throw<Exception>();
        }

        [Fact]
        public void CheckReturnsValidResult()
        {
            const string Guess = "road";
            var wordProvider = new Mock<IWordProvider>();
            wordProvider.Setup(p => p.GetWord()).Returns("word");
            var game = new Game(wordProvider.Object);

            var result = game.Check(Guess);

            result[Guess.IndexOf("r")].Should().Be(InspectionResults.Present);
            result[Guess.IndexOf("o")].Should().Be(InspectionResults.Exact);
            result[Guess.IndexOf("a")].Should().Be(InspectionResults.Absent);
            result[Guess.IndexOf("d")].Should().Be(InspectionResults.Exact);
        }

    }
}
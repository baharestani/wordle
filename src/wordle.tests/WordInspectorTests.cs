using FluentAssertions;
using Xunit;

namespace Wordle.Tests
{
    public class WordInspectorTests
    {
        [Fact]
        public void InspectWhenCharDoesntExistReturnsAbsent()
        {
            var inspector = new WordInspector();
            inspector.Inspect("word", 'a', 0).Should().Be(WordInspectionResults.Absent);
        }

        [Fact]
        public void InspectWhenLetterInPlaceReturnsFits()
        {
            var inspector = new WordInspector();
            inspector.Inspect("word", 'w', 0).Should().Be(WordInspectionResults.Fits);
        }

        [Fact]
        public void InspectWhenLetterExistsInWrongIndexReturnsPresent()
        {
            var inspector = new WordInspector();
            inspector.Inspect("word", 'o', 0).Should().Be(WordInspectionResults.Present);
        }

    }
}
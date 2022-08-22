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
            inspector.Inspect("word", 'a', 0).Should().Be(InspectionResults.Absent);
        }

        [Fact]
        public void InspectWhenLetterInPlaceReturnsFits()
        {
            var inspector = new WordInspector();
            inspector.Inspect("word", 'w', 0).Should().Be(InspectionResults.Exact);
        }

        [Fact]
        public void InspectWhenLetterExistsInWrongIndexReturnsPresent()
        {
            var inspector = new WordInspector();
            inspector.Inspect("word", 'o', 0).Should().Be(InspectionResults.Present);
        }

    }
}
namespace Wordle
{
    public class RandomWordProvider : IWordProvider
    {
        private string[] words = new[]
        {
            "trade",
            "coder",
            "bread",
            "march"
        };

        public string GetWord()
        {
            var i = new Random().NextInt64(0, words.Length - 1);
            return words[i];
        }
    }
}
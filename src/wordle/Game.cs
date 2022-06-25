using System;

namespace Wordle
{
    public class Game
    {

        private string word;
        private readonly WordInspector inspector = new WordInspector();

        public Game(IWordProvider wordProvider)
        {
            this.word = wordProvider.GetWord();
        }

        public InspectionResults[] Check(string guess)
        {
            if (guess.Length != word.Length)
            {
                throw new Exception();
            }

            var results = new InspectionResults[guess.Length];
            for (byte i = 0; i < guess.Length; i++)
            {
                results[i] = inspector.Inspect(word, guess[i], i);
            }

            return results;
        }
    }
}
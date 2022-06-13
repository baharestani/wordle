using System;

namespace Wordle
{
    public class Game
    {

        private string word;
        private readonly WordInspector inspector = new WordInspector();

        public Game(string word)
        {
            this.word = word;
        }

        public IEnumerable<InspectionResults> Check(string guess)
        {
            if (guess.Length != word.Length)
            {
                throw new Exception();
            }

            for (byte i = 0; i < guess.Length; i++)
            {
                yield return inspector.Inspect(word, guess[i], i);
            }
        }
    }
}
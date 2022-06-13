using System;

namespace wordle.tests
{
    internal class Game
    {
        private string word;

        public Game(string word)
        {
            this.word = word;
        }

        internal void Check(string guess)
        {
            if (guess.Length != word.Length)
            {
                throw new Exception();
            }
        }
    }
}
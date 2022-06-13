using System;

namespace Wordle
{
    public class Game
    {
        private string word;

        public Game(string word)
        {
            this.word = word;
        }

        public void Check(string guess)
        {
            if (guess.Length != word.Length)
            {
                throw new Exception();
            }
        }
    }
}
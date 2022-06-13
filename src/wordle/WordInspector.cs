namespace Wordle
{
    public class WordInspector
    {
        public WordInspectionResults Inspect(string word, char letter, byte index)
        {
            if (word[index] == letter)
            {
                return WordInspectionResults.Fits;
            }

            if (word.Contains(letter))
            {
                return WordInspectionResults.Present;
            }

            return WordInspectionResults.Absent;
        }
    }
}
namespace Wordle
{
    public class WordInspector
    {
        public InspectionResults Inspect(string word, char letter, byte index)
        {
            if (word[index] == letter)
            {
                return InspectionResults.Exact;
            }

            if (word.Contains(letter))
            {
                return InspectionResults.Present;
            }

            return InspectionResults.Absent;
        }
    }
}
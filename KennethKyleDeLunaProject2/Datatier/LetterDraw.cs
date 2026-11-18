using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject2.Datatier
{
    public class LetterDraw
    {
        private readonly Random _random = new Random();

        private static readonly Dictionary<char, int> _letterFrequencies = new Dictionary<char, int>
        {
            { 'A', 6 }, { 'B', 2 }, { 'C', 2 }, { 'D', 3 }, { 'E', 11 },
            { 'F', 2 }, { 'G', 2 }, { 'H', 5 }, { 'I', 6 }, { 'J', 1 },
            { 'K', 1 }, { 'L', 4 }, { 'M', 2 }, { 'N', 6 }, { 'O', 8 },
            { 'P', 2 }, { 'Q', 1 }, { 'R', 6 }, { 'S', 6 }, { 'T', 9 },
            { 'U', 3 }, { 'V', 2 }, { 'W', 3 }, { 'X', 1 }, { 'Y', 3 },
            { 'Z', 1 }
        };

        public List<char> DrawLetters(int count)
        {
            var letters = new List<char>();
            for (int i = 0; i < count; i++)
            {
                char letter = DrawLetter();
                letters.Add(letter);
            }
            return letters;
        }

        private char DrawLetter()
        {
            int totalFrequency = 0;
            foreach (var frequency in _letterFrequencies.Values)
            {
                totalFrequency += frequency;
            }
            int randomValue = _random.Next(totalFrequency);
            int cumulativeFrequency = 0;
            foreach (var kvp in _letterFrequencies)
            {
                cumulativeFrequency += kvp.Value;
                if (randomValue < cumulativeFrequency)
                {
                    return kvp.Key;
                }
            }
            throw new InvalidOperationException("Failed to draw a letter.");
        }
    }
}

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
            { 'P', 2 }, { 'Q', 1 }, { 'R', 5 }, { 'S', 6 }, { 'T', 9 },
            { 'U', 3 }, { 'V', 2 }, { 'W', 3 }, { 'X', 1 }, { 'Y', 3 },
            { 'Z', 1 }
        };

        public List<char> DrawLetters(int count)
        {
            List<char> bag = new List<char>();
            foreach (var kvp in _letterFrequencies)
            {
                for (int i = 0; i < kvp.Value; i++)
                {
                    bag.Add(kvp.Key);
                }
            }

            var letters = new List<char>();
            for (int i = 0; i < count && bag.Count > 0; i++)
            {
                int index = _random.Next(bag.Count);
                letters.Add(bag[index]);
                bag.RemoveAt(index);
            }
            return letters;
        }
    }
}

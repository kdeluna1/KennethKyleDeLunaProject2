using System;
using System.Collections.Generic;
using System.Text;
using KennethKyleDeLunaProject2.Model;

namespace KennethKyleDeLunaProject2.Datatier
{
    internal class DictionaryLoader
    {
        private readonly HashSet<string> _validWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Contains the total word count.
        /// </summary>
        public int WordCount => _validWords.Count;

        /// <summary>
        /// Gets the dictionary file from a given file path and extracts its contents.
        /// </summary>
        /// <param name="filePath"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="InvalidOperationException"></exception>
        public void LoadDictionary(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !System.IO.File.Exists(filePath))
            {
                throw new ArgumentException("Dictionary cannot be loaded.", nameof(filePath));
            }
            
            string jsonContent = System.IO.File.ReadAllText(filePath);
            var wordGroups = System.Text.Json.JsonSerializer.Deserialize<List<WordGroups>>(jsonContent);

            _validWords.Clear();
            if (wordGroups == null)
            {
                throw new InvalidOperationException("Failed to deserialize the dictionary.");
            }

            foreach (var group in wordGroups)
            {
                foreach (var word in group.Words)
                {
                    _validWords.Add(word.Trim().ToUpperInvariant());
                }
            }
        }

        /// <summary>
        /// Checks if a specific word is valid or not.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public bool IsValidWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return false;
            }
            return _validWords.Contains(word.Trim().ToUpperInvariant());
        }
    }
}

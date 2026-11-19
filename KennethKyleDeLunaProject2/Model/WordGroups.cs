using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace KennethKyleDeLunaProject2.Model
{
    /// <summary>
    /// Represents a group of words that start with the same letter
    /// </summary>
    public class WordGroups
    {
        /// <summary>
        /// The letter of the words
        /// </summary>
        [JsonPropertyName("letter")]
        public string Letter { get; set; } = string.Empty;

        /// <summary>
        /// The list of words that sttart with the same letter
        /// </summary>
        [JsonPropertyName("words")]
        public List<string> Words { get; set; } = [];

    }
}

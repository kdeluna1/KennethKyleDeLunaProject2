using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace KennethKyleDeLunaProject2.Model
{
    internal class WordGroups
    {
        [JsonPropertyName("letter")]
        public string Letter { get; set; } = string.Empty;

        [JsonPropertyName("words")]
        public List<string> Words { get; set; } = [];

    }
}

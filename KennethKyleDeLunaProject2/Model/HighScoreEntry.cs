using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject2.Model
{
    public class HighScoreEntry
    {
        public string PlayerName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int MaxTimeSeconds { get; set; }
        public DateTime DateAchieved { get; set; }
    }
}

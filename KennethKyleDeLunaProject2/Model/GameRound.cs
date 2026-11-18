using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject2.Model
{
    public class GameRound
    {
        public int RoundNumber { get; set; }
        public int RoundScore { get; set; }
        public string AvailableLetters { get; set; } = string.Empty;
        public int RoundMaxTimeSeconds { get; set; }
        public List<ValidWordAttempt> ValidWords { get; set; } = new List<ValidWordAttempt>();
        public List<InvalidWordAttempt> InvalidWords { get; set; } = new List<InvalidWordAttempt>();
    }
}

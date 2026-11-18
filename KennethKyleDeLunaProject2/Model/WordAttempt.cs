using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject2.Model
{
    public abstract class WordAttempt
    {
        public string Word { get; set; } = string.Empty;
        public string GameTimeAttempted { get; set; } = string.Empty;
        public int RoundMaxTimeSeconds { get; set; }

    }

    public class ValidWordAttempt : WordAttempt
    {
        public int WordScore { get; set; }
    }

    public class InvalidWordAttempt : WordAttempt
    {
        public string InvalidReason { get; set; } = string.Empty;
    }
}

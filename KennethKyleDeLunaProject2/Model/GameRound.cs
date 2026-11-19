using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject2.Model
{
    /// <summary>
    /// The base class of a game round object.
    /// </summary>
    public class GameRound
    {
        /// <summary>
        /// The round number
        /// </summary>
        public int RoundNumber { get; set; }
        /// <summary>
        /// The score gained in the round
        /// </summary>
        public int RoundScore { get; set; }
        /// <summary>
        /// The drawn letters available in the round
        /// </summary>
        public string AvailableLetters { get; set; } = string.Empty;
        /// <summary>
        /// The chosen amount of time for the rround in seconds
        /// </summary>
        public int RoundMaxTimeSeconds { get; set; }
        /// <summary>
        /// The list of valid words submitted duringg the round
        /// </summary>
        public List<ValidWordAttempt> ValidWords { get; set; } = new List<ValidWordAttempt>();
        /// <summary>
        /// The list of invalid words submitted during tthe attempt
        /// </summary>
        public List<InvalidWordAttempt> InvalidWords { get; set; } = new List<InvalidWordAttempt>();
    }
}

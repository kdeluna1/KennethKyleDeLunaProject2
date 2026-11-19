using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject2.Model
{
    /// <summary>
    /// The base class for high score entry objects
    /// </summary>
    public class HighScoreEntry
    {
        /// <summary>
        /// The name of the player 
        /// </summary>
        public string PlayerName { get; set; } = string.Empty;
        /// <summary>
        /// The score of the round attempt
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// the set timer of the round
        /// </summary>
        public int MaxTimeSeconds { get; set; }
        /// <summary>
        /// The date and time when the high score was made
        /// </summary>
        public DateTime DateAchieved { get; set; }
    }
}

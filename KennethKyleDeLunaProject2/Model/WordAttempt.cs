using System;
using System.Collections.Generic;
using System.Text;

namespace KennethKyleDeLunaProject2.Model
{
    /// <summary>
    /// The base abstract class for word attempt objects
    /// </summary>
    public abstract class WordAttempt
    {
        /// <summary>
        /// The word submittted
        /// </summary>
        public string Word { get; set; } = string.Empty;
        /// <summary>
        /// The time left on the timer in seconds when the word was submitted
        /// </summary>
        public string GameTimeAttempted { get; set; } = string.Empty;
        /// <summary>
        /// The timer set for the round in seconds when the word was submitted
        /// </summary>
        public int RoundMaxTimeSeconds { get; set; }

    }

    /// <summary>
    /// The child class for valid words that inherits properties from the WordAttempt base class
    /// </summary>
    public class ValidWordAttempt : WordAttempt
    {
        /// <summary>
        /// The score gained from submitting the word
        /// </summary>
        public int WordScore { get; set; }
    }

    /// <summary>
    /// The child class for invalid words that inherits properties from the WordAttempt base class
    /// </summary>
    public class InvalidWordAttempt : WordAttempt
    {
        /// <summary>
        /// The reason why the word was invalid
        /// </summary>
        public string InvalidReason { get; set; } = string.Empty;
    }
}

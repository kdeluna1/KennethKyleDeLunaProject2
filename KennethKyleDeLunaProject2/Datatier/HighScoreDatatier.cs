using KennethKyleDeLunaProject2.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace KennethKyleDeLunaProject2.Datatier
{
    /// <summary>
    /// 
    /// </summary>
    public class HighScoreDatatier
    {

        private readonly string _filePath;
        private const int MaxHighScores = 10;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        public HighScoreDatatier(string filePath = "highscores.json")
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Loads scores from an existing hihsscores json file or creates an empty score list if none was found
        /// </summary>
        /// <returns></returns>
        public List<HighScoreEntry> LoadScores()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return new List<HighScoreEntry>();
                }

                string json = File.ReadAllText(_filePath);
                return JsonSerializer.Deserialize<List<HighScoreEntry>>(json) ?? new List<HighScoreEntry>();
            }
            catch
            {
                return new List<HighScoreEntry>();
            }
        }

        /// <summary>
        /// Saves the high score record
        /// </summary>
        /// <param name="scores"></param>
        public void SaveScores(List<HighScoreEntry> scores)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(scores, options);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Checks if a round is valid to be placed as a high score record
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public bool QualifiesForHighScore(int score)
        {
            if (score <= 0){
                return false;
            }
            var scores = LoadScores();
            if (scores.Count < MaxHighScores)
            {
                return true;
            }
                
            return score > scores.Min(s => s.Score);
        }

        /// <summary>
        /// Adds the high score to the json file
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="score"></param>
        /// <param name="maxTimeSeconds"></param>
        public void AddHighScore(string playerName, int score, int maxTimeSeconds)
        {
            var scores = LoadScores();
            scores.Add(new HighScoreEntry
            {
                PlayerName = playerName.Trim(),
                Score = score,
                MaxTimeSeconds = maxTimeSeconds,
                DateAchieved = DateTime.Now
            });

            scores = scores.OrderByDescending(s => s.Score).ThenBy(s => s.MaxTimeSeconds).Take(MaxHighScores).ToList();

            SaveScores(scores);
        }

        /// <summary>
        /// Sorts the high scores by their overall points earned
        /// </summary>
        /// <returns></returns>
        public List<HighScoreEntry> GetSortedByOverallScore()
        {
            return LoadScores()
                .OrderByDescending(s => s.Score)
                .ToList();
        }

        /// <summary>
        /// Sorts the high scores by their time and then score descending
        /// </summary>
        /// <returns></returns>
        public List<HighScoreEntry> GetSortedByTimeAndScore()
        {
            return LoadScores()
                .OrderBy(s => s.MaxTimeSeconds)
                .ThenByDescending(s => s.Score)
                .ToList();
        }

        /// <summary>
        /// Resets the high score list
        /// </summary>
        public void ResetScores()
        {
            SaveScores(new List<HighScoreEntry>());
        }
    }
}

using KennethKyleDeLunaProject2.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

namespace KennethKyleDeLunaProject2.Datatier
{
    public class HighScoreDatatier
    {

        private readonly string _filePath;
        private const int MaxHighScores = 10;

        public HighScoreDatatier(string filePath = "highscores.json")
        {
            _filePath = filePath;
        }

        public List<HighScoreEntry> loadScores()
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

        public void saveScores(List<HighScoreEntry> scores)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(scores, options);
            File.WriteAllText(_filePath, json);
        }

        public bool qualifiesForHighScore(int score)
        {
            if (score <= 0){
                return false;
            }
            var scores = loadScores();
            if (scores.Count < MaxHighScores)
            {
                return true;
            }
                
            return score > scores.Min(s => s.Score);
        }

        public void addHighScore(string playerName, int score, int maxTimeSeconds)
        {
            var scores = loadScores();
            scores.Add(new HighScoreEntry
            {
                PlayerName = playerName.Trim(),
                Score = score,
                MaxTimeSeconds = maxTimeSeconds,
                DateAchieved = DateTime.Now
            });

            scores = scores.OrderByDescending(s => s.Score).ThenBy(s => s.MaxTimeSeconds).Take(MaxHighScores).ToList();

            saveScores(scores);
        }

        public List<HighScoreEntry> GetSortedByOverallScore()
        {
            return loadScores()
                .OrderByDescending(s => s.Score)
                .ToList();
        }

        public List<HighScoreEntry> GetSortedByTimeAndScore()
        {
            return loadScores()
                .OrderBy(s => s.MaxTimeSeconds)
                .ThenByDescending(s => s.Score)
                .ToList();
        }

        public void ResetScores()
        {
            saveScores(new List<HighScoreEntry>());
        }
    }
}

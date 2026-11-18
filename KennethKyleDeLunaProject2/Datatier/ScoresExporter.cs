using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace KennethKyleDeLunaProject2.Datatier
{
    public static class ScoresExporter
    {
        public static void ExportScoresToFile(string filePath, List<Model.GameRound> gameRounds)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("Invalid export file path.");
            }

            var exportPayload = new
            {
                ExportedAt = DateTime.Now,
                TotalRoundsPlayed = gameRounds.Count,
                Rounds = gameRounds
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(exportPayload, options);
            File.WriteAllText(filePath, json);
        }
    }
}

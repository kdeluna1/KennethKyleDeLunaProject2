using KennethKyleDeLunaProject2.Datatier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KennethKyleDeLunaProject2.Forms
{
    /// <summary>
    /// Main class of high score view form.
    /// </summary>
    public partial class HighScoresForm : Form
    {
        private readonly HighScoreDatatier _highScoreService;

        /// <summary>
        /// Initializes a new high score form
        /// </summary>
        /// <param name="highScoreService"></param>
        public HighScoresForm(HighScoreDatatier highScoreService)
        {
            InitializeComponent();
            _highScoreService = highScoreService;
            RefreshGridByScore();
        }

        private void ScoreSortButton_Click(object sender, EventArgs e)
        {
            RefreshGridByScore();
        }

        private void TimeScoreSortButton_Click(object sender, EventArgs e)
        {
            RefreshGridByTimeAndScore();
        }

        private void FormatColumns()
        {
            highScoresGridView.Columns["PlayerName"]?.HeaderText = "Player Name";
            highScoresGridView.Columns["Score"]?.HeaderText = "Score";
            highScoresGridView.Columns["MaxTimeSeconds"]?.HeaderText = "Round Time (sec)";
            highScoresGridView.Columns["DateAchieved"]?.HeaderText = "Date";
        }

        private void BoardResetButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset the high score board?", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _highScoreService.SaveScores(new List<Model.HighScoreEntry>());
                RefreshGridByScore();
            }
        }

        private void RefreshGridByScore()
        {
            var data = _highScoreService.GetSortedByOverallScore();
            highScoresGridView.DataSource = null;
            highScoresGridView.DataSource = data;
            FormatColumns();
        }

        private void RefreshGridByTimeAndScore()
        {
            var data = _highScoreService.GetSortedByTimeAndScore();
            highScoresGridView.DataSource = null;
            highScoresGridView.DataSource = data;
            FormatColumns();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using KennethKyleDeLunaProject2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KennethKyleDeLunaProject2
{
    /// <summary>
    /// Main class of round summary forms
    /// </summary>
    public partial class RoundSummaryForm : Form
    {
        /// <summary>
        /// Creates an instance of a round summary form with the given game round attempt
        /// </summary>
        /// <param name="attempt"></param>
        public RoundSummaryForm(GameRound attempt)
        {
            InitializeComponent();
            roundCompleteLabel.Text = $"Round {attempt.RoundNumber} Complete!";
            int validCount = attempt.ValidWords?.Count ?? 0;
            roundDetailsLabel.Text = $"You scored {attempt.RoundScore} points in this round. ({validCount} Valid Words)";

            if (attempt.ValidWords != null)
            {
                foreach (var word in attempt.ValidWords)
                {
                    var listViewItem = new ListViewItem(word.Word);
                    listViewItem.SubItems.Add(word.WordScore.ToString());
                    listViewItem.SubItems.Add(word.GameTimeAttempted);
                    roundSummaryListView.Items.Add(listViewItem);
                }
            }
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}

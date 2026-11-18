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
    public partial class RoundSummaryForm : Form
    {
        public RoundSummaryForm(GameRound? attempt)
        {
            InitializeComponent();
            roundCompleteLabel.Text = $"Round {attempt?.RoundNumber} Complete!";
            roundDetailsLabel.Text = $"You scored {attempt?.RoundScore} points in this round. ({attempt?.ValidWords?.Count} Valid Words)";
            foreach (var word in attempt?.ValidWords ?? new List<ValidWordAttempt>())
            {
                var listViewItem = new ListViewItem(word.Word);
                listViewItem.SubItems.Add(word.WordScore.ToString());
                listViewItem.SubItems.Add(word.GameTimeAttempted);
                roundSummaryListView.Items.Add(listViewItem);
            }
        }
    }
}

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
    public partial class HighScoresForm : Form
    {
        private readonly HighScoreDatatier _highScoreService;

        public HighScoresForm(HighScoreDatatier highScoreService)
        {
            InitializeComponent();
            _highScoreService = highScoreService;
        }

        private void scoreSortButton_Click(object sender, EventArgs e)
        {

        }

        private void timeScoreSortButton_Click(object sender, EventArgs e)
        {

        }

        private void boardResetButton_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }
    }
}

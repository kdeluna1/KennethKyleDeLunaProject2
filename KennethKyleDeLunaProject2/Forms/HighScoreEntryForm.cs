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
    /// The main form of high sscore entries
    /// </summary>
    public partial class HighScoreEntryForm : Form
    {
        /// <summary>
        /// The name of the player of the round
        /// </summary>
        public string PlayerName => nameTextBox.Text.Trim();

        /// <summary>
        /// Initializes a new high score entry form
        /// </summary>
        public HighScoreEntryForm()
        {
            InitializeComponent();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a valid name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}

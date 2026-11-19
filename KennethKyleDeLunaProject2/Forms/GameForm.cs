using KennethKyleDeLunaProject2.Datatier;
using KennethKyleDeLunaProject2.Forms;
using KennethKyleDeLunaProject2.Model;
using System.Text;

namespace KennethKyleDeLunaProject2
{
    public partial class GameForm : Form
    {
        private readonly DictionaryLoader _dictionaryLoader = new DictionaryLoader();
        private readonly LetterDraw _letterDraw = new LetterDraw();
        private readonly Random _random = new Random();
        private readonly List<(int wordLength, int score)> _wordScores = new List<(int, int)>
        {
            (3, 90), (4, 160), (5, 250), (6, 460), (7, 490)
        };
        private GameRound? _currentRound;
        private List<GameRound> _gameRounds = new List<GameRound>();
        private int _gameTimeInSeconds = 60;
        private int _timeRemainingInSeconds = 60;
        private bool _isRoundActive = false;
        private bool _isFirstClick = true;
        private bool _isInputSynced = false;
        private class LetterButton
        {
            /// <summary>
            /// The char assigned to the button
            /// </summary>
            public char Letter { get; set; }
            /// <summary>
            /// Determines whether the letter is selected or enttttered by the user
            /// </summary>
            public bool IsSelected { get; set; }
        }
        private List<LetterButton> _letterButtons = new List<LetterButton>();
        private List<Button> _uiButtons = new List<Button>();
        private List<char> _currentLetters = new List<char>();
        private HighScoreDatatier _highScoreService = new HighScoreDatatier(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "highscores.json"));

        /// <summary>
        /// Initializes a new instance of the GameForm window
        /// </summary>
        public GameForm()
        {
            InitializeComponent();
            LoadDictionary();
            _uiButtons = new List<Button>
            {
                letterButton1, letterButton2, letterButton3,
                letterButton4, letterButton5, letterButton6, letterButton7
            };
            gameTimer.Stop();

        }

        private void LoadDictionary()
        {
            try
            {
                string dictionaryFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dictionary.json");
                _dictionaryLoader.LoadDictionary(dictionaryFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dictionary: " + ex.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private string GameTimerFormat(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!_isRoundActive)
            {
                return;
            }

            _timeRemainingInSeconds--;
            UpdateTimerDisplay();

            if (_timeRemainingInSeconds <= 0)
            {
                gameTimer.Stop();
                EndRound();
            }
        }

        private void UpdateTimerDisplay()
        {
            timerLabel.Text = $"Time: {GameTimerFormat(_timeRemainingInSeconds)}";
            timerLabel.ForeColor = _timeRemainingInSeconds <= 10 ? Color.Red : Color.Black;
        }

        private void StartRound()
        {
            _isRoundActive = true;
            _currentLetters = _letterDraw.DrawLetters(7);
            _letterButtons = _currentLetters.Select(l => new LetterButton { Letter = l, IsSelected = false }).ToList();
            validWordsListBox.Items.Clear();
            _currentRound = new GameRound
            {
                RoundNumber = _gameRounds.Count + 1,
                RoundScore = 0,
                AvailableLetters = new string(_currentLetters.ToArray()),
                RoundMaxTimeSeconds = _gameTimeInSeconds
            };
            _timeRemainingInSeconds = _gameTimeInSeconds;
            InputControlsActive(true);
            RefreshLetterButtons();
            _isFirstClick = false;
            twistButton.Text = "TWIST!";
            gameTimer.Start();
        }

        private void EndRound()
        {
            gameTimer.Stop();
            _isRoundActive = false;
            InputControlsActive(false);
            if (_currentRound != null)
            {
                _gameRounds.Add(_currentRound);
                using (Form summaryForm = new RoundSummaryForm(_currentRound))
                {
                    summaryForm.ShowDialog(this);
                }
                if (_highScoreService.QualifiesForHighScore(_currentRound.RoundScore))
                {
                    using (var highScoreForm = new HighScoreEntryForm())
                    {
                        if (highScoreForm.ShowDialog(this) == DialogResult.OK)
                        {
                            _highScoreService.AddHighScore(highScoreForm.PlayerName, _currentRound.RoundScore, _gameTimeInSeconds);
                        }
                    }
                }
            }

            gamePointersLabel.Text = "Round over! Go to Game -> New Game to play again.";

        }

        private void RefreshLetterButtons()
        {

            for (int i = 0; i < _letterButtons.Count; i++)
            {
                _uiButtons[i].Text = _letterButtons[i].Letter.ToString();
                if (_letterButtons[i].IsSelected)
                {
                    _uiButtons[i].BackColor = Color.SteelBlue;
                    _uiButtons[i].ForeColor = Color.White;
                }
                else
                {
                    _uiButtons[i].BackColor = SystemColors.Control;
                    _uiButtons[i].ForeColor = Color.Black;
                }
            }
        }

        private void HandleLetterClick(Button clickedButton)
        {
            if (!_isRoundActive) return;

            int index = _uiButtons.IndexOf(clickedButton);
            if (index == -1 || index >= _letterButtons.Count) return;

            _isInputSynced = true;
            try
            {
                var tile = _letterButtons[index];
                tile.IsSelected = !tile.IsSelected;

                char letter = char.ToUpperInvariant(tile.Letter);
                string currentText = wordTextBox.Text.ToUpperInvariant();

                if (tile.IsSelected)
                {
                    wordTextBox.Text = currentText + letter;
                }
                else
                {
                    int lastPos = currentText.LastIndexOf(letter);
                    if (lastPos >= 0)
                    {
                        wordTextBox.Text = currentText.Remove(lastPos, 1);
                    }
                }

                wordTextBox.SelectionStart = wordTextBox.Text.Length;
                RefreshLetterButtons();
            }
            finally
            {
                _isInputSynced = false;
            }
        }

        private void LetterButton1_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton1);
        }

        private void LetterButton2_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton2);
        }

        private void LetterButton3_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton3);
        }

        private void LetterButton4_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton4);
        }

        private void LetterButton5_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton5);
        }

        private void LetterButton6_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton6);
        }

        private void LetterButton7_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton7);
        }

        private void TwistButton_Click(object sender, EventArgs e)
        {
            if (_isFirstClick)
            {
                _isFirstClick = false;
                InputControlsActive(true);
                StartRound();
            }

            List<LetterButton> selectedLetters = _letterButtons.Where(lb => lb.IsSelected).ToList();
            for (int i = _letterButtons.Count - 1; i > 0; i--)
            {
                int index = _random.Next(i + 1);
                (_letterButtons[i], _letterButtons[index]) = (_letterButtons[index], _letterButtons[i]);
            }

            foreach (var letterObj in selectedLetters)
            {
                int index = _letterButtons.IndexOf(letterObj);
                if (index != -1)
                {
                    _letterButtons[index].IsSelected = true;
                }
            }

            RefreshLetterButtons();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SubmitWordAttempt();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void InputControlsActive(bool isActive)
        {
            foreach (var button in _uiButtons)
            {
                button.Enabled = isActive;
            }
            addButton.Enabled = isActive;
            clearButton.Enabled = isActive;
        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartRound();
        }

        private void ClearTextBox()
        {
            wordTextBox.Text = "";
            foreach (var letterObj in _letterButtons)
            {
                letterObj.IsSelected = false;
            }
            RefreshLetterButtons();
        }

        private void SetTime(int seconds, ToolStripMenuItem menuItem)
        {
            _gameTimeInSeconds = seconds;
            oneMinuteToolStripMenuItem.Checked = (menuItem == oneMinuteToolStripMenuItem);
            twoMinutesToolStripMenuItem.Checked = (menuItem == twoMinutesToolStripMenuItem);
            threeMinutesToolStripMenuItem.Checked = (menuItem == threeMinutesToolStripMenuItem);
            StartRound();
        }
        private void OneMinuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTime(60, oneMinuteToolStripMenuItem);
        }

        private void TwoMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTime(120, twoMinutesToolStripMenuItem);
        }

        private void ThreeMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTime(180, threeMinutesToolStripMenuItem);
        }

        private void WordTextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                return;
            }

            char inputChar = char.ToUpperInvariant(e.KeyChar);

            var availableButton = _letterButtons.FirstOrDefault(lb => char.ToUpperInvariant(lb.Letter) == inputChar && !lb.IsSelected);

            if (availableButton == null)
            {
                e.Handled = true;
            }
            else
            {
                e.KeyChar = inputChar;
            }
        }

        private void WordTextBox_Changed(object? sender, EventArgs e)
        {
            if (_isInputSynced) return;

            _isInputSynced = true;
            try
            {
                foreach (var lb in _letterButtons)
                {
                    lb.IsSelected = false;
                }

                var validChars = new List<char>();

                foreach (char ch in wordTextBox.Text.ToUpperInvariant())
                {
                    var match = _letterButtons.FirstOrDefault(
                        lb => char.ToUpperInvariant(lb.Letter) == ch && !lb.IsSelected);

                    if (match != null)
                    {
                        match.IsSelected = true;
                        validChars.Add(ch);
                    }
                }

                string sanitized = new string(validChars.ToArray());
                if (wordTextBox.Text != sanitized)
                {
                    int cursor = wordTextBox.SelectionStart;
                    wordTextBox.Text = sanitized;
                    wordTextBox.SelectionStart = Math.Min(cursor, wordTextBox.Text.Length);
                    return;
                }

                RefreshLetterButtons();

            }
            finally
            {
                _isInputSynced = false;
            }
        }

        private void WordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SubmitWordAttempt();
            }
        }

        private bool CanFormFromAvailableLetters(string word)
        {
            List<char> availableLetters = _currentLetters.Select(c => char.ToUpperInvariant(c)).ToList();
            foreach (char ch in word.ToUpperInvariant())
            {
                if (!availableLetters.Remove(ch))
                {
                    return false;
                }
            }
            return true;
        }

        private void SubmitWordAttempt()
        {
            string word = wordTextBox.Text.ToString().Trim();
            string time = GameTimerFormat(_timeRemainingInSeconds);
            if (word.Length < 3)
            {
                gamePointersLabel.Text = "Word must be at least 3 letters long.";
                gamePointersLabel.ForeColor = Color.Red;
                ClearTextBox();
                return;
            }

            if (!CanFormFromAvailableLetters(word))
            {
                gamePointersLabel.Text = "Word uses invalid or unavailable characters.";
                gamePointersLabel.ForeColor = Color.Red;
                _currentRound?.InvalidWords?.Add(new InvalidWordAttempt
                {
                    Word = word,
                    GameTimeAttempted = GameTimerFormat(_timeRemainingInSeconds),
                    RoundMaxTimeSeconds = _gameTimeInSeconds,
                    InvalidReason = "Word uses invalid or unavailable characters."
                });
                ClearTextBox();
                return;
            }

            if (_currentRound?.ValidWords?.Any(v => v.Word == word) == true)
            {
                gamePointersLabel.Text = "Word has already been submitted.";
                gamePointersLabel.ForeColor = Color.Orange;
                _currentRound?.InvalidWords?.Add(new InvalidWordAttempt
                {
                    Word = word,
                    GameTimeAttempted = GameTimerFormat(_timeRemainingInSeconds),
                    RoundMaxTimeSeconds = _gameTimeInSeconds,
                    InvalidReason = "Word has already been submitted."
                });
                ClearTextBox();
                return;
            }

            if (!_dictionaryLoader.IsValidWord(word))
            {
                gamePointersLabel.Text = $"'{word}' is not a valid word.";
                gamePointersLabel.ForeColor = Color.Red;
                _currentRound?.InvalidWords?.Add(new InvalidWordAttempt
                {
                    Word = word,
                    GameTimeAttempted = GameTimerFormat(_timeRemainingInSeconds),
                    RoundMaxTimeSeconds = _gameTimeInSeconds,
                    InvalidReason = "Word is invalid."
                });
                ClearTextBox();
                return;
            }

            int score = _wordScores.FirstOrDefault(ws => ws.wordLength == word.Length).score;
            _currentRound?.ValidWords?.Add(new ValidWordAttempt
            {
                Word = word,
                GameTimeAttempted = GameTimerFormat(_timeRemainingInSeconds),
                RoundMaxTimeSeconds = _gameTimeInSeconds,
                WordScore = score
            });
            _currentRound?.RoundScore += score;
            validWordsListBox.Items.Add($"{word} - {score} points at {GameTimerFormat(_timeRemainingInSeconds)}");
            scoreLabel.Text = $"Score: {_currentRound?.RoundScore ?? 0}";
            gamePointersLabel.Text = $"'{word}' added for {score} points.";
            gamePointersLabel.ForeColor = Color.Green;
            ClearTextBox();
        }

        private void ExportHighToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_gameRounds.Count == 0)
            {
                MessageBox.Show("No rounds have been played yet.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.Title = "Export Game Rounds";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ScoresExporter.ExportScoresToFile(saveFileDialog.FileName, _gameRounds);
                        MessageBox.Show("Game rounds exported successfully.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting game rounds: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ScoreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var hsForm = new HighScoresForm(_highScoreService))
            {
                hsForm.ShowDialog(this);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

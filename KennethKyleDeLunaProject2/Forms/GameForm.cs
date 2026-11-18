using KennethKyleDeLunaProject2.Datatier;
using KennethKyleDeLunaProject2.Model;
using System.Text;

namespace KennethKyleDeLunaProject2
{
    public partial class gameForm : Form
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
        private class LetterButton
        {
            public char Letter { get; set; }
            public bool IsSelected { get; set; }
        }
        private List<LetterButton> _letterButtons = new List<LetterButton>();
        private List<Button> _uiButtons = new List<Button>();
        private List<char> _currentLetters = new List<char>();

        public gameForm()
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

        private string gameTimerFormat(int seconds)
        {
            int mins = seconds / 60;
            int secs = seconds % 60;
            return $"{mins:D2}:{secs:D2}";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
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
                endRound();
            }
        }

        private void UpdateTimerDisplay()
        {
            timerLabel.Text = $"Time: {gameTimerFormat(_timeRemainingInSeconds)}";
            timerLabel.ForeColor = _timeRemainingInSeconds <= 10 ? Color.Red : Color.Black;
        }

        private void startRound()
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
            inputControlsActive(true);
            refreshLetterButtons();
            _isFirstClick = false;
            twistButton.Text = "TWIST!";
            gameTimer.Start();
        }

        private void endRound()
        {
            gameTimer.Stop();
            _isRoundActive = false;
            inputControlsActive(false);
            if (_currentRound != null)
            {
                _gameRounds.Add(_currentRound);
                using (Form summaryForm = new RoundSummaryForm(_currentRound))
                {
                summaryForm.ShowDialog(this);
                }
            }
            
            gamePointersLabel.Text = "Round over! Go to Game -> New Game to play again.";

        }

        private void refreshLetterButtons()
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
            if (index != -1 && index < _letterButtons.Count)
            {
                _letterButtons[index].IsSelected = !_letterButtons[index].IsSelected;
                refreshLetterButtons();
            }

            if (_letterButtons[index].IsSelected)
            {
                wordTextBox.Text += _letterButtons[index].Letter;
            }
            else
            {
                wordTextBox.Text = wordTextBox.Text.Replace(_letterButtons[index].Letter.ToString(), "");
            }
        }

        private void letterButton1_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton1);
        }

        private void letterButton2_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton2);
        }

        private void letterButton3_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton3);
        }

        private void letterButton4_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton4);
        }

        private void letterButton5_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton5);
        }

        private void letterButton6_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton6);
        }

        private void letterButton7_Click(object sender, EventArgs e)
        {
            HandleLetterClick(letterButton7);
        }

        private void twistButton_Click(object sender, EventArgs e)
        {
            if (_isFirstClick)
            {
                _isFirstClick = false;
                inputControlsActive(true);
                startRound();
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

            refreshLetterButtons();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            submitWordAttempt();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void inputControlsActive(bool isActive)
        {
            foreach (var button in _uiButtons)
            {
                button.Enabled = isActive;
            }
            addButton.Enabled = isActive;
            clearButton.Enabled = isActive;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startRound();
        }

        private void clearTextBox()
        {
            wordTextBox.Text = "";
            foreach (var letterObj in _letterButtons)
            {
                letterObj.IsSelected = false;
            }
            refreshLetterButtons();
        }

        private void setTime(int seconds, ToolStripMenuItem menuItem)
        {
            _gameTimeInSeconds = seconds;
            oneMinuteToolStripMenuItem.Checked = (menuItem == oneMinuteToolStripMenuItem);
            twoMinutesToolStripMenuItem.Checked = (menuItem == twoMinutesToolStripMenuItem);
            threeMinutesToolStripMenuItem.Checked = (menuItem == threeMinutesToolStripMenuItem);
            startRound();
        }
        private void oneMinuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTime(60, oneMinuteToolStripMenuItem);
        }

        private void twoMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTime(120, twoMinutesToolStripMenuItem);
        }

        private void threeMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTime(180, threeMinutesToolStripMenuItem);
        }

        private void wordTextBox_KeyPress(object? sender, KeyPressEventArgs e)
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

        private void wordTextBox_Changed(object? sender, EventArgs e)
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

            refreshLetterButtons();
        }

        private void wordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                submitWordAttempt();
            }
        }

        private bool canFormFromAvailableLetters(string word)
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

        private void submitWordAttempt()
        {
            string word = wordTextBox.Text.ToString().Trim();
            string time = gameTimerFormat(_timeRemainingInSeconds);
            if (word.Length < 3)
            {
                gamePointersLabel.Text = "Word must be at least 3 letters long.";
                gamePointersLabel.ForeColor = Color.Red;
                clearTextBox();
                return;
            }

            if (!canFormFromAvailableLetters(word))
            {
                gamePointersLabel.Text = "Word uses invalid or unavailable characters.";
                gamePointersLabel.ForeColor = Color.Red;
                _currentRound?.InvalidWords?.Add(new InvalidWordAttempt
                {
                    Word = word,
                    GameTimeAttempted = gameTimerFormat(_timeRemainingInSeconds),
                    RoundMaxTimeSeconds = _gameTimeInSeconds,
                    InvalidReason = "Word uses invalid or unavailable characters."
                });
                clearTextBox();
                return;
            }

            if (_currentRound?.ValidWords?.Any(v => v.Word == word) == true)
            {
                gamePointersLabel.Text = "Word has already been submitted.";
                gamePointersLabel.ForeColor = Color.Orange;
                _currentRound?.InvalidWords?.Add(new InvalidWordAttempt
                {
                    Word = word,
                    GameTimeAttempted = gameTimerFormat(_timeRemainingInSeconds),
                    RoundMaxTimeSeconds = _gameTimeInSeconds,
                    InvalidReason = "Word has already been submitted."
                });
                clearTextBox();
                return;
            }

            if (!_dictionaryLoader.IsValidWord(word))
            {
                gamePointersLabel.Text = $"'{word}' is not a valid word.";
                gamePointersLabel.ForeColor = Color.Red;
                _currentRound?.InvalidWords?.Add(new InvalidWordAttempt
                {
                    Word = word,
                    GameTimeAttempted = gameTimerFormat(_timeRemainingInSeconds),
                    RoundMaxTimeSeconds = _gameTimeInSeconds,
                    InvalidReason = "Word is invalid."
                });
                clearTextBox();
                return;
            }

            int score = _wordScores.FirstOrDefault(ws => ws.wordLength == word.Length).score;
            _currentRound?.ValidWords?.Add(new ValidWordAttempt
            {
                Word = word,
                GameTimeAttempted = gameTimerFormat(_timeRemainingInSeconds),
                RoundMaxTimeSeconds = _gameTimeInSeconds,
                WordScore = score
            });
            _currentRound?.RoundScore += score;
            validWordsListBox.Items.Add($"{word} - {score} points at {gameTimerFormat(_timeRemainingInSeconds)}");
            scoreLabel.Text = $"Score: {_currentRound?.RoundScore ?? 0}";
            gamePointersLabel.Text = $"'{word}' added for {score} points.";
            gamePointersLabel.ForeColor = Color.Green;
            clearTextBox();
        }

        private void exportHighToolStripMenuItem_Click(object sender, EventArgs e)
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
                        ScoresExporter.ExportScoresToFile( saveFileDialog.FileName, _gameRounds);
                        MessageBox.Show("Game rounds exported successfully.", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting game rounds: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

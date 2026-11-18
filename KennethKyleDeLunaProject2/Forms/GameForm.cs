using KennethKyleDeLunaProject2.Datatier;
using KennethKyleDeLunaProject2.Model;

namespace KennethKyleDeLunaProject2
{
    public partial class gameForm : Form
    {
        private readonly DictionaryLoader _dictionaryLoader = new DictionaryLoader();
        private readonly LetterDraw _letterDraw = new LetterDraw();
        private GameRound? _currentRound;
        private readonly Random _random = new Random();
        private int _gameTimeInSeconds = 60;
        private int _timeRemainingInSeconds = 60;
        private int _score = 0;
        private bool _isRoundActive = false;
        private bool _isFirstClick = true;
        private class LetterButton
        {
            public char Letter { get; set; }
            public bool IsSelected { get; set; }
        }
        private List<LetterButton> _letterButtons = new List<LetterButton>();
        private List<Button> _uiButtons = new List<Button>();

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
            return $"Time: {mins:D2}:{secs:D2}";
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
            timerLabel.Text = gameTimerFormat(_timeRemainingInSeconds);
            timerLabel.ForeColor = _timeRemainingInSeconds <= 10 ? Color.Red : Color.Black;
        }

        private void startRound()
        {
            _isRoundActive = true;
            List<char> _currentLetters = _letterDraw.DrawLetters(7);
            _letterButtons = _currentLetters.Select(l => new LetterButton { Letter = l, IsSelected = false }).ToList();
            _currentRound = new GameRound
            {
                RoundScore = 0
            };
            _timeRemainingInSeconds = _gameTimeInSeconds;
            inputControlsActive(true);
            refreshLetterButtons();
            gameTimer.Start();
        }

        private void endRound()
        {
            gameTimer.Stop();
            _isRoundActive = false;
            inputControlsActive(false);
            using (var summaryForm = new RoundSummaryForm(_currentRound))
            {
                summaryForm.ShowDialog(this);
            }

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
                twistButton.Text = "TWIST!";
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

        }

        private void undoButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void inputControlsActive(bool isActive)
        {
            foreach (var button in _uiButtons)
            {
                button.Enabled = isActive;
            }
            addButton.Enabled = isActive;
            undoButton.Enabled = isActive;
            clearButton.Enabled = isActive;
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startRound();
        }
    }
}

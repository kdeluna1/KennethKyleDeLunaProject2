using KennethKyleDeLunaProject2.Datatier;
using KennethKyleDeLunaProject2.Model;
using KennethKyleDeLunaProject2;

namespace KennethKyleDeLunaProject2
{
    public partial class gameForm : Form
    {
        private readonly DictionaryLoader _dictionaryLoader = new DictionaryLoader();
        private GameRound? _currentRound;
        private int _gameTimeInSeconds = 60;
        private int _timeRemainingInSeconds = 60;
        private int _score = 0;
        private bool _isRoundActive = false;
        private bool _isFirstClick = true;

        public gameForm()
        {
            InitializeComponent();
            LoadDictionary();
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
            _currentRound = new GameRound
            {
                RoundScore = 0
            };
            _timeRemainingInSeconds = _gameTimeInSeconds;
            inputControlsActive(true);
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

        private void letterButton1_Click(object sender, EventArgs e)
        {

        }

        private void letterButton2_Click(object sender, EventArgs e)
        {

        }

        private void letterButton3_Click(object sender, EventArgs e)
        {

        }

        private void letterButton4_Click(object sender, EventArgs e)
        {

        }

        private void letterButton5_Click(object sender, EventArgs e)
        {

        }

        private void letterButton6_Click(object sender, EventArgs e)
        {

        }

        private void letterButton7_Click(object sender, EventArgs e)
        {

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
            letterButton1.Enabled = isActive;
            letterButton2.Enabled = isActive;
            letterButton3.Enabled = isActive;
            letterButton4.Enabled = isActive;
            letterButton5.Enabled = isActive;
            letterButton6.Enabled = isActive;
            letterButton7.Enabled = isActive;
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

using KennethKyleDeLunaProject2.Datatier;

namespace KennethKyleDeLunaProject2
{
    public partial class gameForm : Form
    {
        private readonly DictionaryLoader _dictionaryLoader = new DictionaryLoader();
        private int _gameTimeInSeconds = 60;
        private int _timeRemainingInSeconds = 60;
        private int _score = 0;
        private bool _isRoundActive = false;
        private bool _isFirstClick = true;

        public gameForm()
        {
            InitializeComponent();
            LoadDictionary();

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

        }

        private void startRound()
        {

        }
        private void endRound()
        {

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
    }
}

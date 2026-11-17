using KennethKyleDeLunaProject2.Datatier;

namespace KennethKyleDeLunaProject2
{
    public partial class gameForm : Form
    {
        private readonly DictionaryLoader _dictionaryLoader = new DictionaryLoader();
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

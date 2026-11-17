namespace KennethKyleDeLunaProject2
{
    partial class gameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            letterButton1 = new Button();
            lettersGroupBox = new GroupBox();
            twistButton = new Button();
            letterButton7 = new Button();
            letterButton6 = new Button();
            letterButton5 = new Button();
            letterButton4 = new Button();
            letterButton3 = new Button();
            letterButton2 = new Button();
            addButton = new Button();
            undoButton = new Button();
            clearButton = new Button();
            wordTextBox = new TextBox();
            groupBox1 = new GroupBox();
            validWordsListBox = new ListBox();
            gamePointersLabel = new Label();
            timerLabel = new Label();
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            timeToolStripMenuItem = new ToolStripMenuItem();
            oneMinuteToolStripMenuItem = new ToolStripMenuItem();
            twoMinutesToolStripMenuItem = new ToolStripMenuItem();
            threeMinutesToolStripMenuItem1 = new ToolStripMenuItem();
            scoreToolStripMenuItem = new ToolStripMenuItem();
            scoreToolStripMenuItem1 = new ToolStripMenuItem();
            exportHighToolStripMenuItem = new ToolStripMenuItem();
            exportScoresToolStripMenuItem = new ToolStripMenuItem();
            scoreLabel = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            lettersGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // letterButton1
            // 
            resources.ApplyResources(letterButton1, "letterButton1");
            letterButton1.Name = "letterButton1";
            letterButton1.UseVisualStyleBackColor = true;
            letterButton1.Click += letterButton1_Click;
            // 
            // lettersGroupBox
            // 
            lettersGroupBox.Controls.Add(twistButton);
            lettersGroupBox.Controls.Add(letterButton7);
            lettersGroupBox.Controls.Add(letterButton6);
            lettersGroupBox.Controls.Add(letterButton5);
            lettersGroupBox.Controls.Add(letterButton4);
            lettersGroupBox.Controls.Add(letterButton3);
            lettersGroupBox.Controls.Add(letterButton2);
            lettersGroupBox.Controls.Add(letterButton1);
            resources.ApplyResources(lettersGroupBox, "lettersGroupBox");
            lettersGroupBox.Name = "lettersGroupBox";
            lettersGroupBox.TabStop = false;
            // 
            // twistButton
            // 
            resources.ApplyResources(twistButton, "twistButton");
            twistButton.Name = "twistButton";
            twistButton.UseVisualStyleBackColor = true;
            twistButton.Click += twistButton_Click;
            // 
            // letterButton7
            // 
            resources.ApplyResources(letterButton7, "letterButton7");
            letterButton7.Name = "letterButton7";
            letterButton7.UseVisualStyleBackColor = true;
            letterButton7.Click += letterButton7_Click;
            // 
            // letterButton6
            // 
            resources.ApplyResources(letterButton6, "letterButton6");
            letterButton6.Name = "letterButton6";
            letterButton6.UseVisualStyleBackColor = true;
            letterButton6.Click += letterButton6_Click;
            // 
            // letterButton5
            // 
            resources.ApplyResources(letterButton5, "letterButton5");
            letterButton5.Name = "letterButton5";
            letterButton5.UseVisualStyleBackColor = true;
            letterButton5.Click += letterButton5_Click;
            // 
            // letterButton4
            // 
            resources.ApplyResources(letterButton4, "letterButton4");
            letterButton4.Name = "letterButton4";
            letterButton4.UseVisualStyleBackColor = true;
            letterButton4.Click += letterButton4_Click;
            // 
            // letterButton3
            // 
            resources.ApplyResources(letterButton3, "letterButton3");
            letterButton3.Name = "letterButton3";
            letterButton3.UseVisualStyleBackColor = true;
            letterButton3.Click += letterButton3_Click;
            // 
            // letterButton2
            // 
            resources.ApplyResources(letterButton2, "letterButton2");
            letterButton2.Name = "letterButton2";
            letterButton2.UseVisualStyleBackColor = true;
            letterButton2.Click += letterButton2_Click;
            // 
            // addButton
            // 
            resources.ApplyResources(addButton, "addButton");
            addButton.Name = "addButton";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // undoButton
            // 
            resources.ApplyResources(undoButton, "undoButton");
            undoButton.Name = "undoButton";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // clearButton
            // 
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // wordTextBox
            // 
            resources.ApplyResources(wordTextBox, "wordTextBox");
            wordTextBox.Name = "wordTextBox";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(validWordsListBox);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // validWordsListBox
            // 
            resources.ApplyResources(validWordsListBox, "validWordsListBox");
            validWordsListBox.FormattingEnabled = true;
            validWordsListBox.Name = "validWordsListBox";
            // 
            // gamePointersLabel
            // 
            resources.ApplyResources(gamePointersLabel, "gamePointersLabel");
            gamePointersLabel.Name = "gamePointersLabel";
            // 
            // timerLabel
            // 
            resources.ApplyResources(timerLabel, "timerLabel");
            timerLabel.Name = "timerLabel";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, timeToolStripMenuItem, scoreToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            resources.ApplyResources(gameToolStripMenuItem, "gameToolStripMenuItem");
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            resources.ApplyResources(newGameToolStripMenuItem, "newGameToolStripMenuItem");
            // 
            // timeToolStripMenuItem
            // 
            timeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { oneMinuteToolStripMenuItem, twoMinutesToolStripMenuItem, threeMinutesToolStripMenuItem1 });
            timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            resources.ApplyResources(timeToolStripMenuItem, "timeToolStripMenuItem");
            // 
            // oneMinuteToolStripMenuItem
            // 
            oneMinuteToolStripMenuItem.Checked = true;
            oneMinuteToolStripMenuItem.CheckOnClick = true;
            oneMinuteToolStripMenuItem.CheckState = CheckState.Checked;
            oneMinuteToolStripMenuItem.Name = "oneMinuteToolStripMenuItem";
            resources.ApplyResources(oneMinuteToolStripMenuItem, "oneMinuteToolStripMenuItem");
            // 
            // twoMinutesToolStripMenuItem
            // 
            twoMinutesToolStripMenuItem.CheckOnClick = true;
            twoMinutesToolStripMenuItem.Name = "twoMinutesToolStripMenuItem";
            resources.ApplyResources(twoMinutesToolStripMenuItem, "twoMinutesToolStripMenuItem");
            // 
            // threeMinutesToolStripMenuItem1
            // 
            threeMinutesToolStripMenuItem1.CheckOnClick = true;
            threeMinutesToolStripMenuItem1.Name = "threeMinutesToolStripMenuItem1";
            resources.ApplyResources(threeMinutesToolStripMenuItem1, "threeMinutesToolStripMenuItem1");
            // 
            // scoreToolStripMenuItem
            // 
            scoreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scoreToolStripMenuItem1, exportHighToolStripMenuItem, exportScoresToolStripMenuItem });
            scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            resources.ApplyResources(scoreToolStripMenuItem, "scoreToolStripMenuItem");
            // 
            // scoreToolStripMenuItem1
            // 
            scoreToolStripMenuItem1.Name = "scoreToolStripMenuItem1";
            resources.ApplyResources(scoreToolStripMenuItem1, "scoreToolStripMenuItem1");
            // 
            // exportHighToolStripMenuItem
            // 
            exportHighToolStripMenuItem.Name = "exportHighToolStripMenuItem";
            resources.ApplyResources(exportHighToolStripMenuItem, "exportHighToolStripMenuItem");
            // 
            // exportScoresToolStripMenuItem
            // 
            exportScoresToolStripMenuItem.Name = "exportScoresToolStripMenuItem";
            resources.ApplyResources(exportScoresToolStripMenuItem, "exportScoresToolStripMenuItem");
            // 
            // scoreLabel
            // 
            resources.ApplyResources(scoreLabel, "scoreLabel");
            scoreLabel.Name = "scoreLabel";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // gameForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scoreLabel);
            Controls.Add(timerLabel);
            Controls.Add(gamePointersLabel);
            Controls.Add(groupBox1);
            Controls.Add(wordTextBox);
            Controls.Add(clearButton);
            Controls.Add(undoButton);
            Controls.Add(addButton);
            Controls.Add(lettersGroupBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "gameForm";
            lettersGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button letterButton1;
        private GroupBox lettersGroupBox;
        private Button letterButton7;
        private Button letterButton6;
        private Button letterButton5;
        private Button letterButton4;
        private Button letterButton3;
        private Button letterButton2;
        private Button twistButton;
        private Button addButton;
        private Button undoButton;
        private Button clearButton;
        private TextBox wordTextBox;
        private GroupBox groupBox1;
        private ListBox validWordsListBox;
        private Label gamePointersLabel;
        private Label timerLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripMenuItem oneMinuteToolStripMenuItem;
        private ToolStripMenuItem twoMinutesToolStripMenuItem;
        private ToolStripMenuItem threeMinutesToolStripMenuItem1;
        private ToolStripMenuItem scoreToolStripMenuItem;
        private ToolStripMenuItem scoreToolStripMenuItem1;
        private ToolStripMenuItem exportHighToolStripMenuItem;
        private ToolStripMenuItem exportScoresToolStripMenuItem;
        private Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

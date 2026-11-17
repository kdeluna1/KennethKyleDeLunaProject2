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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameForm));
            button1 = new Button();
            lettersGroupBox = new GroupBox();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            addButton = new Button();
            undoButton = new Button();
            clearButton = new Button();
            textBox1 = new TextBox();
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
            lettersGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lettersGroupBox
            // 
            lettersGroupBox.Controls.Add(button8);
            lettersGroupBox.Controls.Add(button7);
            lettersGroupBox.Controls.Add(button6);
            lettersGroupBox.Controls.Add(button5);
            lettersGroupBox.Controls.Add(button4);
            lettersGroupBox.Controls.Add(button3);
            lettersGroupBox.Controls.Add(button2);
            lettersGroupBox.Controls.Add(button1);
            resources.ApplyResources(lettersGroupBox, "lettersGroupBox");
            lettersGroupBox.Name = "lettersGroupBox";
            lettersGroupBox.TabStop = false;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            resources.ApplyResources(addButton, "addButton");
            addButton.Name = "addButton";
            addButton.UseVisualStyleBackColor = true;
            // 
            // undoButton
            // 
            resources.ApplyResources(undoButton, "undoButton");
            undoButton.Name = "undoButton";
            undoButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
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
            // gameForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(scoreLabel);
            Controls.Add(timerLabel);
            Controls.Add(gamePointersLabel);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
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

        private Button button1;
        private GroupBox lettersGroupBox;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button8;
        private Button addButton;
        private Button undoButton;
        private Button clearButton;
        private TextBox textBox1;
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
    }
}

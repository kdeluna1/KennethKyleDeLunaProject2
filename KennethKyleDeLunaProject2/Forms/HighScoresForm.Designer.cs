namespace KennethKyleDeLunaProject2.Forms
{
    partial class HighScoresForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            highScoresGridView = new DataGridView();
            scoreSortButton = new Button();
            boardResetButton = new Button();
            closeButton = new Button();
            timeScoreSortButton = new Button();
            ((System.ComponentModel.ISupportInitialize)highScoresGridView).BeginInit();
            SuspendLayout();
            // 
            // highScoresGridView
            // 
            highScoresGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            highScoresGridView.Location = new Point(12, 12);
            highScoresGridView.Name = "highScoresGridView";
            highScoresGridView.RowHeadersVisible = false;
            highScoresGridView.Size = new Size(776, 366);
            highScoresGridView.TabIndex = 0;
            highScoresGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            highScoresGridView.ReadOnly = true;
            // 
            // scoreSortButton
            // 
            scoreSortButton.Location = new Point(12, 397);
            scoreSortButton.Name = "scoreSortButton";
            scoreSortButton.Size = new Size(209, 41);
            scoreSortButton.TabIndex = 1;
            scoreSortButton.Text = "Sort by Score";
            scoreSortButton.UseVisualStyleBackColor = true;
            scoreSortButton.Click += scoreSortButton_Click;
            // 
            // boardResetButton
            // 
            boardResetButton.Location = new Point(473, 397);
            boardResetButton.Name = "boardResetButton";
            boardResetButton.Size = new Size(145, 41);
            boardResetButton.TabIndex = 3;
            boardResetButton.Text = "Reset Board";
            boardResetButton.UseVisualStyleBackColor = true;
            boardResetButton.Click += boardResetButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(641, 397);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(147, 41);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // timeScoreSortButton
            // 
            timeScoreSortButton.Location = new Point(240, 397);
            timeScoreSortButton.Name = "timeScoreSortButton";
            timeScoreSortButton.Size = new Size(209, 41);
            timeScoreSortButton.TabIndex = 5;
            timeScoreSortButton.Text = "Sort by Time Score";
            timeScoreSortButton.UseVisualStyleBackColor = true;
            timeScoreSortButton.Click += timeScoreSortButton_Click;
            // 
            // HighScoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(timeScoreSortButton);
            Controls.Add(closeButton);
            Controls.Add(boardResetButton);
            Controls.Add(scoreSortButton);
            Controls.Add(highScoresGridView);
            Name = "HighScoresForm";
            Text = "HighScoresForm";
            ((System.ComponentModel.ISupportInitialize)highScoresGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView highScoresGridView;
        private Button scoreSortButton;
        private Button boardResetButton;
        private Button closeButton;
        private Button timeScoreSortButton;
    }
}
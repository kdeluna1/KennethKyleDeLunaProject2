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
            dataGridView1 = new DataGridView();
            scoreSortButton = new Button();
            boardResetButton = new Button();
            closeButton = new Button();
            timeScoreSortButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 366);
            dataGridView1.TabIndex = 0;
            // 
            // scoreSortButton
            // 
            scoreSortButton.Location = new Point(12, 397);
            scoreSortButton.Name = "scoreSortButton";
            scoreSortButton.Size = new Size(209, 41);
            scoreSortButton.TabIndex = 1;
            scoreSortButton.Text = "Sort by Score";
            scoreSortButton.UseVisualStyleBackColor = true;
            // 
            // boardResetButton
            // 
            boardResetButton.Location = new Point(473, 397);
            boardResetButton.Name = "boardResetButton";
            boardResetButton.Size = new Size(145, 41);
            boardResetButton.TabIndex = 3;
            boardResetButton.Text = "Reset Board";
            boardResetButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(641, 397);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(147, 41);
            closeButton.TabIndex = 4;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            // 
            // timeScoreSortButton
            // 
            timeScoreSortButton.Location = new Point(240, 397);
            timeScoreSortButton.Name = "timeScoreSortButton";
            timeScoreSortButton.Size = new Size(209, 41);
            timeScoreSortButton.TabIndex = 5;
            timeScoreSortButton.Text = "Sort by Time Score";
            timeScoreSortButton.UseVisualStyleBackColor = true;
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
            Controls.Add(dataGridView1);
            Name = "HighScoresForm";
            Text = "HighScoresForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button scoreSortButton;
        private Button boardResetButton;
        private Button closeButton;
        private Button timeScoreSortButton;
    }
}
namespace KennethKyleDeLunaProject2
{
    partial class RoundSummaryForm
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
            roundSummaryGroupBox = new GroupBox();
            roundSummaryListView = new ListView();
            validWordColumn = new ColumnHeader();
            pointsColumn = new ColumnHeader();
            timeColumn = new ColumnHeader();
            continueButton = new Button();
            roundCompleteLabel = new Label();
            roundDetailsLabel = new Label();
            roundSummaryGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // roundSummaryGroupBox
            // 
            roundSummaryGroupBox.Controls.Add(roundSummaryListView);
            roundSummaryGroupBox.Location = new Point(12, 130);
            roundSummaryGroupBox.Name = "roundSummaryGroupBox";
            roundSummaryGroupBox.Size = new Size(445, 248);
            roundSummaryGroupBox.TabIndex = 0;
            roundSummaryGroupBox.TabStop = false;
            roundSummaryGroupBox.Text = "Round Summary";
            // 
            // roundSummaryListView
            // 
            roundSummaryListView.Columns.AddRange(new ColumnHeader[] { validWordColumn, pointsColumn, timeColumn });
            roundSummaryListView.Location = new Point(6, 22);
            roundSummaryListView.Name = "roundSummaryListView";
            roundSummaryListView.Size = new Size(433, 220);
            roundSummaryListView.TabIndex = 0;
            roundSummaryListView.UseCompatibleStateImageBehavior = false;
            roundSummaryListView.View = View.Details;
            roundSummaryListView.FullRowSelect = true;
            roundSummaryListView.GridLines = true;
            // 
            // validWordColumn
            // 
            validWordColumn.Text = "Valid Words";
            validWordColumn.Width = 200;
            // 
            // pointsColumn
            // 
            pointsColumn.Text = "Points";
            pointsColumn.TextAlign = HorizontalAlignment.Center;
            pointsColumn.Width = 100;
            // 
            // timeColumn
            // 
            timeColumn.Text = "Time Entered";
            timeColumn.Width = 130;
            // 
            // continueButton
            // 
            continueButton.Location = new Point(342, 394);
            continueButton.Name = "continueButton";
            continueButton.Size = new Size(115, 31);
            continueButton.TabIndex = 1;
            continueButton.Text = "Continue";
            continueButton.UseVisualStyleBackColor = true;
            // 
            // roundCompleteLabel
            // 
            roundCompleteLabel.AutoSize = true;
            roundCompleteLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundCompleteLabel.Location = new Point(18, 38);
            roundCompleteLabel.Name = "roundCompleteLabel";
            roundCompleteLabel.Size = new Size(104, 25);
            roundCompleteLabel.TabIndex = 2;
            roundCompleteLabel.Text = "Time's Up!";
            // 
            // roundDetailsLabel
            // 
            roundDetailsLabel.AutoSize = true;
            roundDetailsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundDetailsLabel.Location = new Point(18, 76);
            roundDetailsLabel.Name = "roundDetailsLabel";
            roundDetailsLabel.Size = new Size(156, 21);
            roundDetailsLabel.TabIndex = 3;
            roundDetailsLabel.Text = "Overall Round Score:";
            // 
            // RoundSummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 437);
            Controls.Add(roundDetailsLabel);
            Controls.Add(roundCompleteLabel);
            Controls.Add(continueButton);
            Controls.Add(roundSummaryGroupBox);
            Name = "RoundSummaryForm";
            Text = "TIME'S UP!";
            roundSummaryGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox roundSummaryGroupBox;
        private ListView roundSummaryListView;
        private ColumnHeader validWordColumn;
        private ColumnHeader pointsColumn;
        private ColumnHeader timeColumn;
        private Button continueButton;
        private Label roundCompleteLabel;
        private Label roundDetailsLabel;
    }
}
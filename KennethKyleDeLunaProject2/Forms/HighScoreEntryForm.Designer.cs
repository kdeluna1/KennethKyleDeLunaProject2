namespace KennethKyleDeLunaProject2.Forms
{
    partial class HighScoreEntryForm
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
            conratulationsLabel = new Label();
            label1 = new Label();
            nameTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // conratulationsLabel
            // 
            conratulationsLabel.AutoSize = true;
            conratulationsLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            conratulationsLabel.Location = new Point(12, 28);
            conratulationsLabel.Name = "conratulationsLabel";
            conratulationsLabel.Size = new Size(178, 30);
            conratulationsLabel.TabIndex = 0;
            conratulationsLabel.Text = "Congratulations!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(530, 17);
            label1.TabIndex = 1;
            label1.Text = "Your score made it to the board! Please enter your name if you want to save your record:";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(12, 108);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(528, 25);
            nameTextBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(421, 155);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(119, 30);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // HighScoreEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 215);
            Controls.Add(saveButton);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(conratulationsLabel);
            Name = "HighScoreEntryForm";
            Text = "HighScoreEntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label conratulationsLabel;
        private Label label1;
        private TextBox nameTextBox;
        private Button saveButton;
    }
}
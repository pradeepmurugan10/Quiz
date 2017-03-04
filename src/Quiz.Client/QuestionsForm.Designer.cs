namespace Quiz.Client
{
    partial class QuestionsForm
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
            this.StartQuizButton = new MetroFramework.Controls.MetroButton();
            this.TimerLabel = new MetroFramework.Controls.MetroLabel();
            this.QuestionLabel = new MetroFramework.Controls.MetroLabel();
            this.Choice3RadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.Choice4RadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.Choice2RadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.Choice1RadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // StartQuizButton
            // 
            this.StartQuizButton.Location = new System.Drawing.Point(81, 131);
            this.StartQuizButton.Name = "StartQuizButton";
            this.StartQuizButton.Size = new System.Drawing.Size(134, 52);
            this.StartQuizButton.TabIndex = 0;
            this.StartQuizButton.Text = "Start Quiz and Timer";
            this.StartQuizButton.UseSelectable = true;
            this.StartQuizButton.Click += new System.EventHandler(this.StartQuizButton_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(112, 16);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(87, 19);
            this.TimerLabel.TabIndex = 1;
            this.TimerLabel.Text = "0 minutes left";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(112, 61);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(83, 19);
            this.QuestionLabel.TabIndex = 2;
            this.QuestionLabel.Text = "QuestionText";
            // 
            // Choice3RadioButton
            // 
            this.Choice3RadioButton.AutoSize = true;
            this.Choice3RadioButton.Location = new System.Drawing.Point(112, 173);
            this.Choice3RadioButton.Name = "Choice3RadioButton";
            this.Choice3RadioButton.Size = new System.Drawing.Size(69, 15);
            this.Choice3RadioButton.TabIndex = 3;
            this.Choice3RadioButton.Text = "Choice 3";
            this.Choice3RadioButton.UseSelectable = true;
            // 
            // Choice4RadioButton
            // 
            this.Choice4RadioButton.AutoSize = true;
            this.Choice4RadioButton.Location = new System.Drawing.Point(112, 194);
            this.Choice4RadioButton.Name = "Choice4RadioButton";
            this.Choice4RadioButton.Size = new System.Drawing.Size(69, 15);
            this.Choice4RadioButton.TabIndex = 4;
            this.Choice4RadioButton.Text = "Choice 4";
            this.Choice4RadioButton.UseSelectable = true;
            // 
            // Choice2RadioButton
            // 
            this.Choice2RadioButton.AutoSize = true;
            this.Choice2RadioButton.Location = new System.Drawing.Point(112, 152);
            this.Choice2RadioButton.Name = "Choice2RadioButton";
            this.Choice2RadioButton.Size = new System.Drawing.Size(69, 15);
            this.Choice2RadioButton.TabIndex = 5;
            this.Choice2RadioButton.Text = "Choice 2";
            this.Choice2RadioButton.UseSelectable = true;
            // 
            // Choice1RadioButton
            // 
            this.Choice1RadioButton.AutoSize = true;
            this.Choice1RadioButton.Location = new System.Drawing.Point(112, 131);
            this.Choice1RadioButton.Name = "Choice1RadioButton";
            this.Choice1RadioButton.Size = new System.Drawing.Size(69, 15);
            this.Choice1RadioButton.TabIndex = 6;
            this.Choice1RadioButton.Text = "Choice 1";
            this.Choice1RadioButton.UseSelectable = true;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.Choice1RadioButton);
            this.Controls.Add(this.Choice2RadioButton);
            this.Controls.Add(this.Choice4RadioButton);
            this.Controls.Add(this.Choice3RadioButton);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.StartQuizButton);
            this.DisplayHeader = false;
            this.Name = "QuestionsForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton StartQuizButton;
        private MetroFramework.Controls.MetroLabel TimerLabel;
        private MetroFramework.Controls.MetroLabel QuestionLabel;
        private MetroFramework.Controls.MetroRadioButton Choice3RadioButton;
        private MetroFramework.Controls.MetroRadioButton Choice4RadioButton;
        private MetroFramework.Controls.MetroRadioButton Choice2RadioButton;
        private MetroFramework.Controls.MetroRadioButton Choice1RadioButton;
    }
}
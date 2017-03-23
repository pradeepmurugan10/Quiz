namespace Quiz.Client
{
    partial class AdminUIForm
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
            this.EditQuizButton = new MetroFramework.Controls.MetroButton();
            this.ViewResultsButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // EditQuizButton
            // 
            this.EditQuizButton.Location = new System.Drawing.Point(23, 79);
            this.EditQuizButton.Name = "EditQuizButton";
            this.EditQuizButton.Size = new System.Drawing.Size(254, 70);
            this.EditQuizButton.TabIndex = 0;
            this.EditQuizButton.Text = "Manage Quiz";
            this.EditQuizButton.UseSelectable = true;
            this.EditQuizButton.Click += new System.EventHandler(this.EditQuizButton_Click);
            // 
            // ViewResultsButton
            // 
            this.ViewResultsButton.Location = new System.Drawing.Point(23, 184);
            this.ViewResultsButton.Name = "ViewResultsButton";
            this.ViewResultsButton.Size = new System.Drawing.Size(254, 67);
            this.ViewResultsButton.TabIndex = 1;
            this.ViewResultsButton.Text = "View Results";
            this.ViewResultsButton.UseSelectable = true;
            this.ViewResultsButton.Click += new System.EventHandler(this.ViewResultsButton_Click);
            // 
            // AdminUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.ViewResultsButton);
            this.Controls.Add(this.EditQuizButton);
            this.Name = "AdminUIForm";
            this.Text = "Quiz Admin";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton EditQuizButton;
        private MetroFramework.Controls.MetroButton ViewResultsButton;
    }
}
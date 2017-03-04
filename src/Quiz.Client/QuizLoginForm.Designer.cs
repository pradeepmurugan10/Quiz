namespace Quiz.Client
{
    partial class QuizLoginForm
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
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.RollNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            this.ServerIPTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            //
            // LoginButton
            //
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.Location = new System.Drawing.Point(100, 185);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(100, 45);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            //
            // RollNumberTextBox
            //
            this.RollNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            //
            //
            this.RollNumberTextBox.CustomButton.Image = null;
            this.RollNumberTextBox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.RollNumberTextBox.CustomButton.Name = "";
            this.RollNumberTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RollNumberTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RollNumberTextBox.CustomButton.TabIndex = 1;
            this.RollNumberTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RollNumberTextBox.CustomButton.UseSelectable = true;
            this.RollNumberTextBox.CustomButton.Visible = false;
            this.RollNumberTextBox.Lines = new string[0];
            this.RollNumberTextBox.Location = new System.Drawing.Point(76, 142);
            this.RollNumberTextBox.MaxLength = 32767;
            this.RollNumberTextBox.Name = "RollNumberTextBox";
            this.RollNumberTextBox.PasswordChar = '\0';
            this.RollNumberTextBox.PromptText = "Roll Number";
            this.RollNumberTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RollNumberTextBox.SelectedText = "";
            this.RollNumberTextBox.SelectionLength = 0;
            this.RollNumberTextBox.SelectionStart = 0;
            this.RollNumberTextBox.ShortcutsEnabled = true;
            this.RollNumberTextBox.Size = new System.Drawing.Size(143, 23);
            this.RollNumberTextBox.TabIndex = 1;
            this.RollNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RollNumberTextBox.UseSelectable = true;
            this.RollNumberTextBox.WaterMark = "Roll Number";
            this.RollNumberTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RollNumberTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            //
            // ServerIPTextBox
            //
            this.ServerIPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            //
            //
            //
            this.ServerIPTextBox.CustomButton.Image = null;
            this.ServerIPTextBox.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.ServerIPTextBox.CustomButton.Name = "";
            this.ServerIPTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ServerIPTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ServerIPTextBox.CustomButton.TabIndex = 1;
            this.ServerIPTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ServerIPTextBox.CustomButton.UseSelectable = true;
            this.ServerIPTextBox.CustomButton.Visible = false;
            this.ServerIPTextBox.Lines = new string[0];
            this.ServerIPTextBox.Location = new System.Drawing.Point(76, 113);
            this.ServerIPTextBox.MaxLength = 32767;
            this.ServerIPTextBox.Name = "ServerIPTextBox";
            this.ServerIPTextBox.PasswordChar = '\0';
            this.ServerIPTextBox.PromptText = "Exam Server IP Address";
            this.ServerIPTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ServerIPTextBox.SelectedText = "";
            this.ServerIPTextBox.SelectionLength = 0;
            this.ServerIPTextBox.SelectionStart = 0;
            this.ServerIPTextBox.ShortcutsEnabled = true;
            this.ServerIPTextBox.Size = new System.Drawing.Size(143, 23);
            this.ServerIPTextBox.TabIndex = 2;
            this.ServerIPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ServerIPTextBox.UseSelectable = true;
            this.ServerIPTextBox.WaterMark = "Exam Server IP Address";
            this.ServerIPTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ServerIPTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            //
            // QuizLoginForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.ServerIPTextBox);
            this.Controls.Add(this.RollNumberTextBox);
            this.Controls.Add(this.LoginButton);
            this.Name = "QuizLoginForm";
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroTextBox RollNumberTextBox;
        private MetroFramework.Controls.MetroTextBox ServerIPTextBox;
    }
}
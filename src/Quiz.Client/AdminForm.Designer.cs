namespace Quiz.Client
{
    partial class AdminForm
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
            this.DurationSubmitButton = new MetroFramework.Controls.MetroButton();
            this.DurationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // DurationSubmitButton
            // 
            this.DurationSubmitButton.Location = new System.Drawing.Point(178, 72);
            this.DurationSubmitButton.Name = "DurationSubmitButton";
            this.DurationSubmitButton.Size = new System.Drawing.Size(99, 23);
            this.DurationSubmitButton.TabIndex = 0;
            this.DurationSubmitButton.Text = "Update On Server";
            this.DurationSubmitButton.UseSelectable = true;
            // 
            // DurationTextBox
            // 
            // 
            // 
            // 
            this.DurationTextBox.CustomButton.Image = null;
            this.DurationTextBox.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.DurationTextBox.CustomButton.Name = "";
            this.DurationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DurationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DurationTextBox.CustomButton.TabIndex = 1;
            this.DurationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DurationTextBox.CustomButton.UseSelectable = true;
            this.DurationTextBox.CustomButton.Visible = false;
            this.DurationTextBox.Lines = new string[0];
            this.DurationTextBox.Location = new System.Drawing.Point(23, 72);
            this.DurationTextBox.MaxLength = 32767;
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.PasswordChar = '\0';
            this.DurationTextBox.PromptText = "Test Duration In Minutes";
            this.DurationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DurationTextBox.SelectedText = "";
            this.DurationTextBox.SelectionLength = 0;
            this.DurationTextBox.SelectionStart = 0;
            this.DurationTextBox.ShortcutsEnabled = true;
            this.DurationTextBox.Size = new System.Drawing.Size(149, 23);
            this.DurationTextBox.TabIndex = 1;
            this.DurationTextBox.UseSelectable = true;
            this.DurationTextBox.WaterMark = "Test Duration In Minutes";
            this.DurationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DurationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.DurationTextBox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.DurationSubmitButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton DurationSubmitButton;
        private MetroFramework.Controls.MetroTextBox DurationTextBox;
    }
}
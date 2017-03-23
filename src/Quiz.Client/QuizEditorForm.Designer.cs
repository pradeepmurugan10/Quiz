namespace Quiz.Client
{
    partial class QuizEditorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.QuizDurationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuestionsGrid = new MetroFramework.Controls.MetroGrid();
            this.ServerUpdateButton = new MetroFramework.Controls.MetroButton();
            this.QuizNameTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // QuizDurationTextBox
            // 
            // 
            // 
            // 
            this.QuizDurationTextBox.CustomButton.Image = null;
            this.QuizDurationTextBox.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.QuizDurationTextBox.CustomButton.Name = "";
            this.QuizDurationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuizDurationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuizDurationTextBox.CustomButton.TabIndex = 1;
            this.QuizDurationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuizDurationTextBox.CustomButton.UseSelectable = true;
            this.QuizDurationTextBox.CustomButton.Visible = false;
            this.QuizDurationTextBox.Lines = new string[0];
            this.QuizDurationTextBox.Location = new System.Drawing.Point(23, 63);
            this.QuizDurationTextBox.MaxLength = 32767;
            this.QuizDurationTextBox.Name = "QuizDurationTextBox";
            this.QuizDurationTextBox.PasswordChar = '\0';
            this.QuizDurationTextBox.PromptText = "Quiz Duration (minutes)";
            this.QuizDurationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuizDurationTextBox.SelectedText = "";
            this.QuizDurationTextBox.SelectionLength = 0;
            this.QuizDurationTextBox.SelectionStart = 0;
            this.QuizDurationTextBox.ShortcutsEnabled = true;
            this.QuizDurationTextBox.Size = new System.Drawing.Size(136, 23);
            this.QuizDurationTextBox.TabIndex = 1;
            this.QuizDurationTextBox.UseSelectable = true;
            this.QuizDurationTextBox.WaterMark = "Quiz Duration (minutes)";
            this.QuizDurationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuizDurationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuestionsGrid
            // 
            this.QuestionsGrid.AllowUserToOrderColumns = true;
            this.QuestionsGrid.AllowUserToResizeRows = false;
            this.QuestionsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuestionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.QuestionsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.QuestionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.QuestionsGrid.EnableHeadersVisualStyles = false;
            this.QuestionsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuestionsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuestionsGrid.Location = new System.Drawing.Point(20, 130);
            this.QuestionsGrid.Name = "QuestionsGrid";
            this.QuestionsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.QuestionsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.QuestionsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionsGrid.Size = new System.Drawing.Size(460, 404);
            this.QuestionsGrid.TabIndex = 4;
            // 
            // ServerUpdateButton
            // 
            this.ServerUpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerUpdateButton.Location = new System.Drawing.Point(20, 540);
            this.ServerUpdateButton.Name = "ServerUpdateButton";
            this.ServerUpdateButton.Size = new System.Drawing.Size(457, 40);
            this.ServerUpdateButton.TabIndex = 5;
            this.ServerUpdateButton.Text = "Update On Server";
            this.ServerUpdateButton.UseSelectable = true;
            this.ServerUpdateButton.Click += new System.EventHandler(this.ServerUpdateButton_Click);
            // 
            // QuizNameTextBox
            // 
            // 
            // 
            // 
            this.QuizNameTextBox.CustomButton.Image = null;
            this.QuizNameTextBox.CustomButton.Location = new System.Drawing.Point(272, 1);
            this.QuizNameTextBox.CustomButton.Name = "";
            this.QuizNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QuizNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QuizNameTextBox.CustomButton.TabIndex = 1;
            this.QuizNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QuizNameTextBox.CustomButton.UseSelectable = true;
            this.QuizNameTextBox.CustomButton.Visible = false;
            this.QuizNameTextBox.Lines = new string[0];
            this.QuizNameTextBox.Location = new System.Drawing.Point(165, 63);
            this.QuizNameTextBox.MaxLength = 32767;
            this.QuizNameTextBox.Name = "QuizNameTextBox";
            this.QuizNameTextBox.PasswordChar = '\0';
            this.QuizNameTextBox.PromptText = "Quiz Name";
            this.QuizNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QuizNameTextBox.SelectedText = "";
            this.QuizNameTextBox.SelectionLength = 0;
            this.QuizNameTextBox.SelectionStart = 0;
            this.QuizNameTextBox.ShortcutsEnabled = true;
            this.QuizNameTextBox.Size = new System.Drawing.Size(294, 23);
            this.QuizNameTextBox.TabIndex = 6;
            this.QuizNameTextBox.UseSelectable = true;
            this.QuizNameTextBox.WaterMark = "Quiz Name";
            this.QuizNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QuizNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QuizEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.QuizNameTextBox);
            this.Controls.Add(this.ServerUpdateButton);
            this.Controls.Add(this.QuestionsGrid);
            this.Controls.Add(this.QuizDurationTextBox);
            this.Name = "QuizEditorForm";
            this.Text = "Admin UI";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox QuizDurationTextBox;
        private MetroFramework.Controls.MetroGrid QuestionsGrid;
        private MetroFramework.Controls.MetroButton ServerUpdateButton;
        private MetroFramework.Controls.MetroTextBox QuizNameTextBox;
    }
}
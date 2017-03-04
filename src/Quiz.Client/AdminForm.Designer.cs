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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DurationSubmitButton = new MetroFramework.Controls.MetroButton();
            this.DurationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuestionsDataGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataGrid)).BeginInit();
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
            //
            // QuestionsDataGrid
            //
            this.QuestionsDataGrid.AllowUserToResizeRows = false;
            this.QuestionsDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuestionsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.QuestionsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.QuestionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.QuestionsDataGrid.EnableHeadersVisualStyles = false;
            this.QuestionsDataGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.QuestionsDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QuestionsDataGrid.Location = new System.Drawing.Point(23, 101);
            this.QuestionsDataGrid.Name = "QuestionsDataGrid";
            this.QuestionsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionsDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.QuestionsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.QuestionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionsDataGrid.Size = new System.Drawing.Size(254, 176);
            this.QuestionsDataGrid.TabIndex = 2;
            //
            // AdminForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.QuestionsDataGrid);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.DurationSubmitButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton DurationSubmitButton;
        private MetroFramework.Controls.MetroTextBox DurationTextBox;
        private MetroFramework.Controls.MetroGrid QuestionsDataGrid;
    }
}
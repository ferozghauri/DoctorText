namespace DoctorText
{
    partial class TextToOneLine
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
            this.MultiLineTextBox = new System.Windows.Forms.TextBox();
            this.SingleLineTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MultiLineTextBox
            // 
            this.MultiLineTextBox.Location = new System.Drawing.Point(12, 34);
            this.MultiLineTextBox.Multiline = true;
            this.MultiLineTextBox.Name = "MultiLineTextBox";
            this.MultiLineTextBox.Size = new System.Drawing.Size(776, 162);
            this.MultiLineTextBox.TabIndex = 0;
            // 
            // SingleLineTextBox
            // 
            this.SingleLineTextBox.Location = new System.Drawing.Point(13, 237);
            this.SingleLineTextBox.Multiline = true;
            this.SingleLineTextBox.Name = "SingleLineTextBox";
            this.SingleLineTextBox.Size = new System.Drawing.Size(775, 159);
            this.SingleLineTextBox.TabIndex = 1;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(354, 423);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // TextToOneLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.SingleLineTextBox);
            this.Controls.Add(this.MultiLineTextBox);
            this.Name = "TextToOneLine";
            this.Text = "TextToOneLine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MultiLineTextBox;
        private System.Windows.Forms.TextBox SingleLineTextBox;
        private System.Windows.Forms.Button ConvertButton;
    }
}
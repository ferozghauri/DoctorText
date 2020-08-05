namespace DoctorText
{
    partial class StringDecorator
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
            this.RawTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SepCharCheckBox = new System.Windows.Forms.CheckBox();
            this.EncChartextBox = new System.Windows.Forms.CheckBox();
            this.SepChartextBox = new System.Windows.Forms.TextBox();
            this.EncCharTxtBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RawTextBox
            // 
            this.RawTextBox.Location = new System.Drawing.Point(13, 38);
            this.RawTextBox.Multiline = true;
            this.RawTextBox.Name = "RawTextBox";
            this.RawTextBox.Size = new System.Drawing.Size(775, 172);
            this.RawTextBox.TabIndex = 0;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 325);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(775, 166);
            this.ResultTextBox.TabIndex = 1;
            // 
            // SepCharCheckBox
            // 
            this.SepCharCheckBox.AutoSize = true;
            this.SepCharCheckBox.Location = new System.Drawing.Point(13, 230);
            this.SepCharCheckBox.Name = "SepCharCheckBox";
            this.SepCharCheckBox.Size = new System.Drawing.Size(140, 17);
            this.SepCharCheckBox.TabIndex = 2;
            this.SepCharCheckBox.Text = "Separate with Character";
            this.SepCharCheckBox.UseVisualStyleBackColor = true;
            // 
            // EncChartextBox
            // 
            this.EncChartextBox.AutoSize = true;
            this.EncChartextBox.Location = new System.Drawing.Point(12, 278);
            this.EncChartextBox.Name = "EncChartextBox";
            this.EncChartextBox.Size = new System.Drawing.Size(135, 17);
            this.EncChartextBox.TabIndex = 3;
            this.EncChartextBox.Text = "Enclose with Character";
            this.EncChartextBox.UseVisualStyleBackColor = true;
            // 
            // SepChartextBox
            // 
            this.SepChartextBox.Location = new System.Drawing.Point(169, 230);
            this.SepChartextBox.Name = "SepChartextBox";
            this.SepChartextBox.Size = new System.Drawing.Size(34, 20);
            this.SepChartextBox.TabIndex = 4;
            // 
            // EncCharTxtBox
            // 
            this.EncCharTxtBox.Location = new System.Drawing.Point(169, 278);
            this.EncCharTxtBox.Name = "EncCharTxtBox";
            this.EncCharTxtBox.Size = new System.Drawing.Size(34, 20);
            this.EncCharTxtBox.TabIndex = 5;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(13, 521);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 6;
            this.ConvertButton.Text = "Covert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // StringDecorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.EncCharTxtBox);
            this.Controls.Add(this.SepChartextBox);
            this.Controls.Add(this.EncChartextBox);
            this.Controls.Add(this.SepCharCheckBox);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.RawTextBox);
            this.Name = "StringDecorator";
            this.Text = "StringDecorator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RawTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.CheckBox SepCharCheckBox;
        private System.Windows.Forms.CheckBox EncChartextBox;
        private System.Windows.Forms.TextBox SepChartextBox;
        private System.Windows.Forms.TextBox EncCharTxtBox;
        private System.Windows.Forms.Button ConvertButton;
    }
}
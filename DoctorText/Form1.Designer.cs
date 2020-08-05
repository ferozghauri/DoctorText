namespace DoctorText
{
    partial class Form1
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
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.SelectedFileLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLFormatterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToOneLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexToAsciiConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringDecoratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.BrowseFileButton.FlatAppearance.BorderSize = 0;
            this.BrowseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseFileButton.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseFileButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BrowseFileButton.Location = new System.Drawing.Point(12, 591);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(102, 38);
            this.BrowseFileButton.TabIndex = 0;
            this.BrowseFileButton.Text = "Browse File";
            this.BrowseFileButton.UseVisualStyleBackColor = false;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ResultBox.Location = new System.Drawing.Point(12, 36);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultBox.Size = new System.Drawing.Size(447, 548);
            this.ResultBox.TabIndex = 1;
            // 
            // ParseButton
            // 
            this.ParseButton.BackColor = System.Drawing.SystemColors.InfoText;
            this.ParseButton.FlatAppearance.BorderSize = 0;
            this.ParseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParseButton.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ParseButton.Location = new System.Drawing.Point(364, 591);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(95, 39);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = false;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // SelectedFileLabel
            // 
            this.SelectedFileLabel.AutoSize = true;
            this.SelectedFileLabel.Font = new System.Drawing.Font("HP Simplified", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFileLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SelectedFileLabel.Location = new System.Drawing.Point(132, 606);
            this.SelectedFileLabel.Name = "SelectedFileLabel";
            this.SelectedFileLabel.Size = new System.Drawing.Size(0, 14);
            this.SelectedFileLabel.TabIndex = 3;
            this.SelectedFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(471, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLFormatterToolStripMenuItem,
            this.textToOneLineToolStripMenuItem,
            this.hexToAsciiConverterToolStripMenuItem,
            this.stringDecoratorToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // xMLFormatterToolStripMenuItem
            // 
            this.xMLFormatterToolStripMenuItem.Name = "xMLFormatterToolStripMenuItem";
            this.xMLFormatterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.xMLFormatterToolStripMenuItem.Text = "XML formatter";
            this.xMLFormatterToolStripMenuItem.Click += new System.EventHandler(this.xMLFormatterToolStripMenuItem_Click);
            // 
            // textToOneLineToolStripMenuItem
            // 
            this.textToOneLineToolStripMenuItem.Name = "textToOneLineToolStripMenuItem";
            this.textToOneLineToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.textToOneLineToolStripMenuItem.Text = "Text to one line";
            this.textToOneLineToolStripMenuItem.Click += new System.EventHandler(this.textToOneLineToolStripMenuItem_Click);
            // 
            // hexToAsciiConverterToolStripMenuItem
            // 
            this.hexToAsciiConverterToolStripMenuItem.Name = "hexToAsciiConverterToolStripMenuItem";
            this.hexToAsciiConverterToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.hexToAsciiConverterToolStripMenuItem.Text = "Hex to Ascii Converter";
            this.hexToAsciiConverterToolStripMenuItem.Click += new System.EventHandler(this.hexToAsciiConverterToolStripMenuItem_Click);
            // 
            // stringDecoratorToolStripMenuItem
            // 
            this.stringDecoratorToolStripMenuItem.Name = "stringDecoratorToolStripMenuItem";
            this.stringDecoratorToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.stringDecoratorToolStripMenuItem.Text = "String Decorator";
            this.stringDecoratorToolStripMenuItem.Click += new System.EventHandler(this.stringDecoratorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(471, 641);
            this.Controls.Add(this.SelectedFileLabel);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.BrowseFileButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "DoctorText";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseFileButton;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.Label SelectedFileLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLFormatterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textToOneLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexToAsciiConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringDecoratorToolStripMenuItem;
    }
}


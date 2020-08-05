namespace DoctorText
{
    partial class HextoASCIIConverter
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
            this.HexTextBox = new System.Windows.Forms.TextBox();
            this.ASCIITextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HexTextBox
            // 
            this.HexTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.HexTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HexTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.HexTextBox.Location = new System.Drawing.Point(13, 13);
            this.HexTextBox.Multiline = true;
            this.HexTextBox.Name = "HexTextBox";
            this.HexTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.HexTextBox.Size = new System.Drawing.Size(775, 191);
            this.HexTextBox.TabIndex = 0;
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ASCIITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ASCIITextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASCIITextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ASCIITextBox.Location = new System.Drawing.Point(13, 210);
            this.ASCIITextBox.Multiline = true;
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ASCIITextBox.Size = new System.Drawing.Size(775, 208);
            this.ASCIITextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Covert HEX to ASCII";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HextoASCIIConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ASCIITextBox);
            this.Controls.Add(this.HexTextBox);
            this.Name = "HextoASCIIConverter";
            this.Text = "HextoASCIIConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HexTextBox;
        private System.Windows.Forms.TextBox ASCIITextBox;
        private System.Windows.Forms.Button button1;
    }
}
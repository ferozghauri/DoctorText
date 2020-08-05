namespace DoctorText
{
    partial class xmlformatter
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
            this.FormattedXMLTextBox = new System.Windows.Forms.TextBox();
            this.FormatXML = new System.Windows.Forms.Button();
            this.RawXMLTextBox = new System.Windows.Forms.TextBox();
            this.RawXMLLabel = new System.Windows.Forms.Label();
            this.FormattedXMLLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormattedXMLTextBox
            // 
            this.FormattedXMLTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FormattedXMLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormattedXMLTextBox.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattedXMLTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.FormattedXMLTextBox.Location = new System.Drawing.Point(675, 52);
            this.FormattedXMLTextBox.Multiline = true;
            this.FormattedXMLTextBox.Name = "FormattedXMLTextBox";
            this.FormattedXMLTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FormattedXMLTextBox.Size = new System.Drawing.Size(672, 497);
            this.FormattedXMLTextBox.TabIndex = 0;
            // 
            // FormatXML
            // 
            this.FormatXML.BackColor = System.Drawing.Color.Black;
            this.FormatXML.FlatAppearance.BorderSize = 0;
            this.FormatXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormatXML.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatXML.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormatXML.Location = new System.Drawing.Point(12, 566);
            this.FormatXML.Name = "FormatXML";
            this.FormatXML.Size = new System.Drawing.Size(100, 40);
            this.FormatXML.TabIndex = 1;
            this.FormatXML.Text = "Format";
            this.FormatXML.UseVisualStyleBackColor = false;
            this.FormatXML.Click += new System.EventHandler(this.FormatXML_Click);
            // 
            // RawXMLTextBox
            // 
            this.RawXMLTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.RawXMLTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RawXMLTextBox.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawXMLTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.RawXMLTextBox.Location = new System.Drawing.Point(12, 52);
            this.RawXMLTextBox.Multiline = true;
            this.RawXMLTextBox.Name = "RawXMLTextBox";
            this.RawXMLTextBox.Size = new System.Drawing.Size(657, 497);
            this.RawXMLTextBox.TabIndex = 2;
            // 
            // RawXMLLabel
            // 
            this.RawXMLLabel.AutoSize = true;
            this.RawXMLLabel.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawXMLLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RawXMLLabel.Location = new System.Drawing.Point(12, 27);
            this.RawXMLLabel.Name = "RawXMLLabel";
            this.RawXMLLabel.Size = new System.Drawing.Size(64, 18);
            this.RawXMLLabel.TabIndex = 3;
            this.RawXMLLabel.Text = "Raw XML";
            // 
            // FormattedXMLLabel
            // 
            this.FormattedXMLLabel.AutoSize = true;
            this.FormattedXMLLabel.Font = new System.Drawing.Font("HP Simplified", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormattedXMLLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormattedXMLLabel.Location = new System.Drawing.Point(672, 27);
            this.FormattedXMLLabel.Name = "FormattedXMLLabel";
            this.FormattedXMLLabel.Size = new System.Drawing.Size(100, 18);
            this.FormattedXMLLabel.TabIndex = 4;
            this.FormattedXMLLabel.Text = "Formatted XML";
            // 
            // xmlformatter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1359, 634);
            this.Controls.Add(this.FormattedXMLLabel);
            this.Controls.Add(this.RawXMLLabel);
            this.Controls.Add(this.RawXMLTextBox);
            this.Controls.Add(this.FormatXML);
            this.Controls.Add(this.FormattedXMLTextBox);
            this.Name = "xmlformatter";
            this.Text = "xmlformatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FormattedXMLTextBox;
        private System.Windows.Forms.Button FormatXML;
        private System.Windows.Forms.TextBox RawXMLTextBox;
        private System.Windows.Forms.Label RawXMLLabel;
        private System.Windows.Forms.Label FormattedXMLLabel;
    }
}
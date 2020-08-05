using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorText
{
    public partial class TextToOneLine : Form
    {
        public TextToOneLine()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            SingleLineTextBox.Text = string.Empty;
            List<String> allLines = new List<String>();
            allLines.AddRange(MultiLineTextBox.Lines);
            string OneLine="";
            foreach(string chunk in allLines)
            {
                OneLine += chunk;
            }
            SingleLineTextBox.Text = OneLine;
        }
    }
}

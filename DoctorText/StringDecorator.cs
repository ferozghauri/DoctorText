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
    public partial class StringDecorator : Form
    {
        public StringDecorator()
        {
            InitializeComponent();
        }
        public string JoinText(List<String> List_,String char_)
        {
            String oneLiner = "";
            foreach (string line in List_)
            {
                oneLiner += line+char_;
            }
            return oneLiner;
        }
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            List<String> allLines = new List<String>();
            List<String> enclosedList = new List<String>();
            String char_ = SepChartextBox.Text;
            String encloseChar_ = EncCharTxtBox.Text;
            allLines.AddRange(RawTextBox.Lines);
            //String finalLine = "";
            if (EncChartextBox.Checked)
            {
                foreach(String line in allLines)
                {
                    enclosedList.Add(encloseChar_ + line + encloseChar_);
                }
                ResultTextBox.Text = JoinText(enclosedList, char_);
            }
            else
            {
                ResultTextBox.Text = JoinText(allLines, char_);
            }

        }
    }
}

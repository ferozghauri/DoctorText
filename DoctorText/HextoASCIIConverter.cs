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
    public partial class HextoASCIIConverter : Form
    {
        public HextoASCIIConverter()
        {
            InitializeComponent();
        }
        public static string ConvertHex(String hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 3)
                {
                    String hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    uint decval = System.Convert.ToUInt32(hs, 16);
                    char character = System.Convert.ToChar(decval);
                    ascii += character;

                }

                return ascii;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }

            return string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String HEX_ = HexTextBox.Text;
            ASCIITextBox.Text = ConvertHex(HEX_);

        }
    }
}

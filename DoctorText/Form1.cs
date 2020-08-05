using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace DoctorText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlNode _header;
        XmlNode _customerProfile;
        XmlNode _cardData;
        XmlNode _accountData;
        XmlNode _footer;
        public static String filename_;

        public void LoadXML()
        {
            XmlDocument myxml = new XmlDocument();
            myxml.Load("C:\\IRIS\\ImportXMLs\\CIF\\Meta.xml");

            XmlNode root = myxml.SelectSingleNode("//CUSTOMERIMPORT");


            foreach (XmlNode _xmlnode in root)
            {

                if (_xmlnode.Name.ToString() == "HE")
                {
                    _header = _xmlnode;
                }
                else if (_xmlnode.Name.ToString() == "CARD")
                {
                    _cardData = _xmlnode;
                }
                else if (_xmlnode.Name.ToString() == "CUSTOMER")
                {
                    _customerProfile = _xmlnode;
                }
                else if (_xmlnode.Name.ToString() == "ACCOUNT")
                {
                    _accountData = _xmlnode;
                }
                else if (_xmlnode.Name.ToString() == "FO")
                {
                    _footer = _xmlnode;
                }
            }
        }

        public void ParseData(string DataString, XmlNode nodeType)
        {
            int cursor_ = 0;
            ResultBox.AppendText("-------["+nodeType.Name.ToString()+"]-------"+Environment.NewLine);
            ResultBox.AppendText("--------------------------------------------------------------------" + Environment.NewLine);
            foreach (XmlNode xn in nodeType)
            {
                int length_ = Int32.Parse(xn.Attributes["length"].Value);
                int string_length = DataString.Length;
                if (cursor_ < string_length)
                {
                    if (!string.IsNullOrEmpty(DataString.Substring(cursor_, length_)))
                    {
                        String _dataLine = xn.Name.ToString() + " = " + DataString.Substring(cursor_, length_);
                        ResultBox.AppendText(_dataLine + Environment.NewLine+Environment.NewLine);
                        //MessageBox.Show(_dataLine);
                    }
                }
                cursor_ = cursor_ + length_;
            }
            ResultBox.AppendText(Environment.NewLine);
        }

        public XmlNode getNodeType(string recordType)
        {
            if (recordType == "HE")
            {
                return _header;
            }else if (recordType == "DA")
            {
                return _cardData;
            }
            else if (recordType == "CP")
            {
                return _customerProfile;
            }
            else if (recordType == "AC")
            {
                return _accountData;
            }
            else 
            {
                return _footer;
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            LoadXML();
            if (!string.IsNullOrEmpty(filename_))
            {
                //MessageBox.Show(filename_);
                List<String> filedata = new List<String>(File.ReadAllLines(filename_));
                foreach(String dataLine in filedata)
                {
                    string recordType_ = dataLine.Substring(6, 2);
                    ParseData(dataLine, getNodeType(recordType_));
                    ResultBox.AppendText(Environment.NewLine);
                    //MessageBox.Show(recordType_);
                }
            }
            else
            {
                MessageBox.Show("please select a file first");
            }
            
        }

        private void BrowseFileButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Select CIF File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"E:\ABL Onsite";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   //MessageBox.Show(theDialog.FileName);
                    SelectedFileLabel.Text = theDialog.FileName;
                    filename_ = theDialog.FileName;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void xMLFormatterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xmlformatter xmlformatter_ = new xmlformatter();
            xmlformatter_.Show();
            
        }

        private void hexToAsciiConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HextoASCIIConverter hta = new HextoASCIIConverter();
            hta.Show();
        }

        private void textToOneLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextToOneLine ttol = new TextToOneLine();
            ttol.Show();
        }

        private void stringDecoratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringDecorator sd = new StringDecorator();
            sd.Show();
        }
    }
}

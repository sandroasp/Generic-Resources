using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string base64String = inputTextBox.Text;
            try
            {
                byte[] data = Convert.FromBase64String(base64String);
                string decodedString = Encoding.UTF8.GetString(data);
                outputTextBox.Text = decodedString;
            }
            catch (FormatException)
            {
                outputTextBox.Text = "Invalid Base64 string!";
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(outputTextBox.Text))
            {
                outputTextBox.Text = "Error: There is nothing to be copied!";
            }
            else if (outputTextBox.Text == ("Error: There is nothing to be copied!") || outputTextBox.Text == "Invalid Base64 string!")
            {
                // Do nothing - error message should not be copied
            }
            else
            {
                Clipboard.SetText(outputTextBox.Text);
            }
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            string originalString = inputTextBox.Text;
            byte[] data = Encoding.UTF8.GetBytes(originalString);
            string base64String = Convert.ToBase64String(data);
            outputTextBox.Text = base64String;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);

        }
    }
}

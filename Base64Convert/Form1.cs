using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "To Base64";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                selectedTextBox.Text = selectedFileName;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "To Base64")
            {
                Byte[] bytes = File.ReadAllBytes(selectedTextBox.Text);
                String file = Convert.ToBase64String(bytes);

                textBox1.Text = file.ToString();
                MessageBox.Show("Converted","Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void selectedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);

        }
    }
}

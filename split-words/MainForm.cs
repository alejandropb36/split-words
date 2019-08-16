using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace split_words
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSplitWords_Click(object sender, EventArgs e)
        {
            string[] words;
            string textContent1;

            if(textBoxContent1.Text != "")
            {
                textContent1 = textBoxContent1.Text;
                Console.WriteLine(textBoxContent1.Text);
                words = textContent1.Split(' ');

                textBoxContent2.Text = textContent1;

                dataGridViewWords.Rows.Clear();

                foreach(string word in words)
                {
                    int row = dataGridViewWords.Rows.Add();
                    dataGridViewWords.Rows[row].Cells[0].Value = word;
                }

            }
        }
    }
}

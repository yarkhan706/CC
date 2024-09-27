using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace task2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckScientific_Click(object sender, EventArgs e)
        {
            // Sample numbers in scientific notation
            string[] numbers = { "8e4", "5e-2", "6e9", "123", "abc" };

            // Regular expression for scientific notation
            string pattern = @"^\d+e[-+]?\d+$";
            Regex regex = new Regex(pattern);

            // Clear previous rows in DataGridView
            dataGridView1.Rows.Clear();

            // Iterate through the numbers and check if they match the regex
            foreach (string number in numbers)
            {
                bool isMatch = regex.IsMatch(number);

                // Add the number and result to the DataGridView
                dataGridView1.Rows.Add(number, isMatch);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindWords_Click(object sender, EventArgs e)
        {
            // Get the document text from the TextBox
            string text = txtDocument.Text;

            // Regular expression for words starting with 't' or 'm'
            string pattern = @"\b[t|m]\w*";
            Regex regex = new Regex(pattern);

            // Find all matches in the text
            MatchCollection matches = regex.Matches(text);

            // Clear previous results in DataGridView
            dataGridView1.Rows.Clear();

            // Iterate through the matches and add them to the DataGridView
            foreach (Match match in matches)
            {
                dataGridView1.Rows.Add(match.Value);
            }
        }
    }
}

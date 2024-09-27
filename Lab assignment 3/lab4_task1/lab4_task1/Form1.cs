namespace lab4_task1
{
    public partial class Form1 : Form
    {
        // Buffers
        private const int BUFFER_SIZE = 50;
        private char[] buffer1 = new char[BUFFER_SIZE];
        private char[] buffer2 = new char[BUFFER_SIZE];
        private int currentBuffer = 1; // 1 means buffer1 is active, 2 means buffer2 is active.
        private int bufferPosition = 0;
        private int globalIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            // Get the source code from the text box
            string sourceCode = txtSourceCode.Text;

            // Clear DataGridView rows before new analysis
            dataGridView1.Rows.Clear();

            // Reset global variables for fresh analysis
            globalIndex = 0;
            bufferPosition = 0;

            // Initialize the lexical analysis process
            PerformLexicalAnalysis(sourceCode);
        }

        // Lexical analysis with two-buffer scheme
        private void PerformLexicalAnalysis(string sourceCode)
        {
            int length = sourceCode.Length;

            while (globalIndex < length)
            {
                if (bufferPosition == BUFFER_SIZE || bufferPosition == 0)
                {
                    FillBuffer(sourceCode, globalIndex, length);
                    bufferPosition = 0;
                }

                // Get the next character from the active buffer
                char currentChar = GetNextCharacter();

                // Skip whitespace
                if (char.IsWhiteSpace(currentChar))
                {
                    globalIndex++;
                    bufferPosition++;
                    continue;
                }

                // Simple token detection logic
                if (char.IsLetter(currentChar))
                {
                    string identifier = ExtractIdentifier(sourceCode, ref globalIndex);
                    dataGridView1.Rows.Add(identifier, "Identifier");
                }
                else if (char.IsDigit(currentChar))
                {
                    string number = ExtractNumber(sourceCode, ref globalIndex);
                    dataGridView1.Rows.Add(number, "Number");
                }
                else if (IsOperator(currentChar))
                {
                    dataGridView1.Rows.Add(currentChar.ToString(), "Operator");
                    globalIndex++; // Move index forward after processing operator
                }
                else if (IsSymbol(currentChar))
                {
                    // Handle common symbols like parentheses, braces, commas, semicolons
                    dataGridView1.Rows.Add(currentChar.ToString(), "Symbol");
                    globalIndex++; // Move index forward after processing symbol
                }
                else
                {
                    // If no valid token is found, it's an unknown token
                    dataGridView1.Rows.Add(currentChar.ToString(), "Unknown");
                    globalIndex++;
                }

                bufferPosition++;
            }
        }

        // Fills the active buffer with the next portion of the source code
        private void FillBuffer(string sourceCode, int startIndex, int length)
        {
            int availableLength = Math.Min(BUFFER_SIZE, length - startIndex);

            if (currentBuffer == 1)
            {
                Array.Clear(buffer1, 0, BUFFER_SIZE);
                Array.Copy(sourceCode.ToCharArray(), startIndex, buffer1, 0, availableLength);
                currentBuffer = 2;
            }
            else
            {
                Array.Clear(buffer2, 0, BUFFER_SIZE);
                Array.Copy(sourceCode.ToCharArray(), startIndex, buffer2, 0, availableLength);
                currentBuffer = 1;
            }
        }

        // Returns the next character from the current active buffer
        private char GetNextCharacter()
        {
            return currentBuffer == 1 ? buffer1[bufferPosition] : buffer2[bufferPosition];
        }

        // Extract identifier (letters or alphanumeric sequences)
        private string ExtractIdentifier(string source, ref int index)
        {
            int start = index;
            while (index < source.Length && (char.IsLetterOrDigit(source[index]) || source[index] == '_'))
            {
                index++;
            }
            return source.Substring(start, index - start);
        }

        // Extract number (integer or floating-point)
        private string ExtractNumber(string source, ref int index)
        {
            int start = index;
            while (index < source.Length && char.IsDigit(source[index]))
            {
                index++;
            }

            // Check for a decimal point (floating-point numbers)
            if (index < source.Length && source[index] == '.')
            {
                index++;
                while (index < source.Length && char.IsDigit(source[index]))
                {
                    index++;
                }
            }

            return source.Substring(start, index - start);
        }

        // Checks if the character is a known operator
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '=' ||
                   c == '<' || c == '>';
        }

        // Checks if the character is a common symbol (parentheses, braces, etc.)
        private bool IsSymbol(char c)
        {
            return c == '(' || c == ')' || c == '{' || c == '}' ||
                   c == ';' || c == ',' || c == '[' || c == ']';
        }
    }
}

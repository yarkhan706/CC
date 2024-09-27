namespace task2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            isMatch = new DataGridViewTextBoxColumn();
            btnCheckScientific = new Button();
            txtDocument = new TextBox();
            btnFindWords = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Number, isMatch });
            dataGridView1.Location = new Point(63, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Number
            // 
            Number.HeaderText = "Column1";
            Number.Name = "Number";
            // 
            // isMatch
            // 
            isMatch.HeaderText = "match";
            isMatch.Name = "isMatch";
            // 
            // btnCheckScientific
            // 
            btnCheckScientific.Location = new Point(417, 51);
            btnCheckScientific.Name = "btnCheckScientific";
            btnCheckScientific.Size = new Size(271, 23);
            btnCheckScientific.TabIndex = 1;
            btnCheckScientific.Text = "Check Scientific Notation";
            btnCheckScientific.UseVisualStyleBackColor = true;
            btnCheckScientific.Click += btnCheckScientific_Click;
            // 
            // txtDocument
            // 
            txtDocument.Location = new Point(63, 296);
            txtDocument.Multiline = true;
            txtDocument.Name = "txtDocument";
            txtDocument.Size = new Size(386, 23);
            txtDocument.TabIndex = 2;
            txtDocument.TextChanged += textBox1_TextChanged;
            // 
            // btnFindWords
            // 
            btnFindWords.Location = new Point(519, 296);
            btnFindWords.Name = "btnFindWords";
            btnFindWords.Size = new Size(75, 23);
            btnFindWords.TabIndex = 3;
            btnFindWords.Text = "Find Words Starting with T and M";
            btnFindWords.UseVisualStyleBackColor = true;
            btnFindWords.Click += btnFindWords_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFindWords);
            Controls.Add(txtDocument);
            Controls.Add(btnCheckScientific);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnCheckScientific;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn isMatch;
        private TextBox txtDocument;
        private Button btnFindWords;
    }
}

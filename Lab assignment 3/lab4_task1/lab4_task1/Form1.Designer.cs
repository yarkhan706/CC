namespace lab4_task1
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
            Token = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            txtSourceCode = new TextBox();
            btnAnalyze = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Token, Type });
            dataGridView1.Location = new Point(41, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // Token
            // 
            Token.HeaderText = "Column1";
            Token.Name = "Token";
            // 
            // Type
            // 
            Type.HeaderText = "Column1";
            Type.Name = "Type";
            // 
            // txtSourceCode
            // 
            txtSourceCode.Location = new Point(41, 201);
            txtSourceCode.Multiline = true;
            txtSourceCode.Name = "txtSourceCode";
            txtSourceCode.Size = new Size(357, 216);
            txtSourceCode.TabIndex = 1;
            // 
            // btnAnalyze
            // 
            btnAnalyze.Location = new Point(499, 150);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(156, 23);
            btnAnalyze.TabIndex = 2;
            btnAnalyze.Text = "Analyze";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnalyze);
            Controls.Add(txtSourceCode);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Token;
        private DataGridViewTextBoxColumn Type;
        private TextBox txtSourceCode;
        private Button btnAnalyze;
    }
}

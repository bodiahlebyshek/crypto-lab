namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.firstTask = new System.Windows.Forms.RadioButton();
            this.secondTask = new System.Windows.Forms.RadioButton();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MatrixBox = new System.Windows.Forms.TextBox();
            this.EncryptedMatrixBox = new System.Windows.Forms.TextBox();
            this.FirstKeyBox = new System.Windows.Forms.TextBox();
            this.SecondKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(24, 10);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFileButton.TabIndex = 0;
            this.OpenFileButton.Text = "Открыть";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(105, 12);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(267, 20);
            this.PathTextBox.TabIndex = 1;
            // 
            // firstTask
            // 
            this.firstTask.AutoSize = true;
            this.firstTask.Checked = true;
            this.firstTask.Location = new System.Drawing.Point(23, 43);
            this.firstTask.Name = "firstTask";
            this.firstTask.Size = new System.Drawing.Size(162, 17);
            this.firstTask.TabIndex = 2;
            this.firstTask.TabStop = true;
            this.firstTask.Text = "Маршрутная перестановка";
            this.firstTask.UseVisualStyleBackColor = true;
            // 
            // secondTask
            // 
            this.secondTask.AutoSize = true;
            this.secondTask.Location = new System.Drawing.Point(23, 65);
            this.secondTask.Name = "secondTask";
            this.secondTask.Size = new System.Drawing.Size(181, 17);
            this.secondTask.TabIndex = 3;
            this.secondTask.Text = "Множественная перестановка";
            this.secondTask.UseVisualStyleBackColor = true;
            this.secondTask.CheckedChanged += new System.EventHandler(this.secondTask_CheckedChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(383, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(348, 102);
            this.textBox.TabIndex = 4;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // Encrypt
            // 
            this.Encrypt.Location = new System.Drawing.Point(220, 62);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(145, 23);
            this.Encrypt.TabIndex = 5;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Гистограммы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(349, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "s:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(220, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MatrixBox
            // 
            this.MatrixBox.Location = new System.Drawing.Point(23, 121);
            this.MatrixBox.Multiline = true;
            this.MatrixBox.Name = "MatrixBox";
            this.MatrixBox.ReadOnly = true;
            this.MatrixBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MatrixBox.Size = new System.Drawing.Size(349, 221);
            this.MatrixBox.TabIndex = 11;
            // 
            // EncryptedMatrixBox
            // 
            this.EncryptedMatrixBox.Location = new System.Drawing.Point(383, 121);
            this.EncryptedMatrixBox.Multiline = true;
            this.EncryptedMatrixBox.Name = "EncryptedMatrixBox";
            this.EncryptedMatrixBox.ReadOnly = true;
            this.EncryptedMatrixBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EncryptedMatrixBox.Size = new System.Drawing.Size(349, 221);
            this.EncryptedMatrixBox.TabIndex = 12;
            // 
            // FirstKeyBox
            // 
            this.FirstKeyBox.Location = new System.Drawing.Point(24, 93);
            this.FirstKeyBox.Name = "FirstKeyBox";
            this.FirstKeyBox.Size = new System.Drawing.Size(161, 20);
            this.FirstKeyBox.TabIndex = 13;
            this.FirstKeyBox.TextChanged += new System.EventHandler(this.FirstKeyBox_TextChanged);
            // 
            // SecondKeyBox
            // 
            this.SecondKeyBox.Location = new System.Drawing.Point(213, 92);
            this.SecondKeyBox.Name = "SecondKeyBox";
            this.SecondKeyBox.Size = new System.Drawing.Size(152, 20);
            this.SecondKeyBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 407);
            this.Controls.Add(this.SecondKeyBox);
            this.Controls.Add(this.FirstKeyBox);
            this.Controls.Add(this.EncryptedMatrixBox);
            this.Controls.Add(this.MatrixBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.secondTask);
            this.Controls.Add(this.firstTask);
            this.Controls.Add(this.PathTextBox);
            this.Controls.Add(this.OpenFileButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Lab2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.RadioButton firstTask;
        private System.Windows.Forms.RadioButton secondTask;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox MatrixBox;
        private System.Windows.Forms.TextBox EncryptedMatrixBox;
        private System.Windows.Forms.TextBox FirstKeyBox;
        private System.Windows.Forms.TextBox SecondKeyBox;
    }
}


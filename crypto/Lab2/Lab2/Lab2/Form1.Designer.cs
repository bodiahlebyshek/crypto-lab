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
            this.TextToEncryptBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TextToDecryptBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.aToDecrypt = new System.Windows.Forms.MaskedTextBox();
            this.bToDecrypt = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bToEncrypt = new System.Windows.Forms.MaskedTextBox();
            this.aToEncrypt = new System.Windows.Forms.MaskedTextBox();
            this.task2Radio = new System.Windows.Forms.RadioButton();
            this.task1Radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TextToEncryptBox
            // 
            this.TextToEncryptBox.Location = new System.Drawing.Point(34, 54);
            this.TextToEncryptBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextToEncryptBox.Name = "TextToEncryptBox";
            this.TextToEncryptBox.Size = new System.Drawing.Size(605, 160);
            this.TextToEncryptBox.TabIndex = 0;
            this.TextToEncryptBox.Text = "";
            this.TextToEncryptBox.TextChanged += new System.EventHandler(this.TextToEncryptBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Расшифрованный текст";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбрать файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadTextFromFile);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Зашифровать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.EncryptClick);
            // 
            // TextToDecryptBox
            // 
            this.TextToDecryptBox.Location = new System.Drawing.Point(34, 242);
            this.TextToDecryptBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextToDecryptBox.Name = "TextToDecryptBox";
            this.TextToDecryptBox.Size = new System.Drawing.Size(605, 160);
            this.TextToDecryptBox.TabIndex = 4;
            this.TextToDecryptBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованный текст";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(642, 242);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 6;
            this.button3.Text = "Расшифровать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DecryptClick);
            // 
            // aToDecrypt
            // 
            this.aToDecrypt.Location = new System.Drawing.Point(368, 216);
            this.aToDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aToDecrypt.Mask = "00000";
            this.aToDecrypt.Name = "aToDecrypt";
            this.aToDecrypt.Size = new System.Drawing.Size(76, 20);
            this.aToDecrypt.TabIndex = 9;
            // 
            // bToDecrypt
            // 
            this.bToDecrypt.Location = new System.Drawing.Point(472, 217);
            this.bToDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bToDecrypt.Mask = "00000";
            this.bToDecrypt.Name = "bToDecrypt";
            this.bToDecrypt.Size = new System.Drawing.Size(76, 20);
            this.bToDecrypt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "a = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "b = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "b = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "a = ";
            // 
            // bToEncrypt
            // 
            this.bToEncrypt.Location = new System.Drawing.Point(472, 32);
            this.bToEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bToEncrypt.Mask = "00000";
            this.bToEncrypt.Name = "bToEncrypt";
            this.bToEncrypt.Size = new System.Drawing.Size(76, 20);
            this.bToEncrypt.TabIndex = 14;
            this.bToEncrypt.ValidatingType = typeof(int);
            // 
            // aToEncrypt
            // 
            this.aToEncrypt.Location = new System.Drawing.Point(368, 31);
            this.aToEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aToEncrypt.Mask = "00000";
            this.aToEncrypt.Name = "aToEncrypt";
            this.aToEncrypt.Size = new System.Drawing.Size(76, 20);
            this.aToEncrypt.TabIndex = 13;
            this.aToEncrypt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.aToEncrypt_MaskInputRejected);
            // 
            // task2Radio
            // 
            this.task2Radio.AutoSize = true;
            this.task2Radio.Location = new System.Drawing.Point(86, 10);
            this.task2Radio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task2Radio.Name = "task2Radio";
            this.task2Radio.Size = new System.Drawing.Size(76, 17);
            this.task2Radio.TabIndex = 17;
            this.task2Radio.TabStop = true;
            this.task2Radio.Text = "2 задание";
            this.task2Radio.UseVisualStyleBackColor = true;
            // 
            // task1Radio
            // 
            this.task1Radio.AutoSize = true;
            this.task1Radio.Checked = true;
            this.task1Radio.Location = new System.Drawing.Point(9, 10);
            this.task1Radio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.task1Radio.Name = "task1Radio";
            this.task1Radio.Size = new System.Drawing.Size(76, 17);
            this.task1Radio.TabIndex = 18;
            this.task1Radio.TabStop = true;
            this.task1Radio.Text = "1 задание";
            this.task1Radio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 422);
            this.Controls.Add(this.task1Radio);
            this.Controls.Add(this.task2Radio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bToEncrypt);
            this.Controls.Add(this.aToEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bToDecrypt);
            this.Controls.Add(this.aToDecrypt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextToDecryptBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextToEncryptBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextToEncryptBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox TextToDecryptBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox aToDecrypt;
        private System.Windows.Forms.MaskedTextBox bToDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox bToEncrypt;
        private System.Windows.Forms.MaskedTextBox aToEncrypt;
        private System.Windows.Forms.RadioButton task2Radio;
        private System.Windows.Forms.RadioButton task1Radio;
    }
}


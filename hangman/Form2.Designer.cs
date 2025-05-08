namespace hangman
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(202, 160);
            label2.Name = "label2";
            label2.Size = new Size(162, 37);
            label2.TabIndex = 1;
            label2.Text = "displayword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(130, 378);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 2;
            label3.Text = "Yanlış tahminler:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(130, 336);
            label4.Name = "label4";
            label4.Size = new Size(158, 25);
            label4.TabIndex = 3;
            label4.Text = "Kelime uzunluğu:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 438);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 43);
            textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(677, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(513, 385);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(349, 438);
            button1.Name = "button1";
            button1.Size = new Size(154, 45);
            button1.TabIndex = 6;
            button1.Text = "Tahmin Et";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(509, 438);
            button2.Name = "button2";
            button2.Size = new Size(140, 43);
            button2.TabIndex = 7;
            button2.Text = "Oyunu Bitir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(426, 228);
            button3.Name = "button3";
            button3.Size = new Size(140, 41);
            button3.TabIndex = 8;
            button3.Text = "İpucu?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(426, 295);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "cluelabel";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(131, 507);
            label5.Name = "label5";
            label5.Size = new Size(52, 25);
            label5.TabIndex = 9;
            label5.Text = "Skor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(131, 276);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 10;
            label6.Text = "timer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(130, 80);
            label7.Name = "label7";
            label7.Size = new Size(169, 28);
            label7.TabIndex = 11;
            label7.Text = "kategori ve zorluk";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 651);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label5;
        private System.Windows.Forms.Timer timer1;
        private Label label6;
        private Label label7;
    }
}
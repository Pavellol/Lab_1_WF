﻿namespace Lab_2_WF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 155);
            label1.Name = "label1";
            label1.Size = new Size(138, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите значение для a:";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(183, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 111);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(436, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            /*textBox1.TextChanged += textBox1_TextChanged;*/
            // 
            // textBox2
            // 
            textBox2.Location = new Point(436, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;/*
            textBox2.TextChanged += textBox2_TextChanged;*/
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 189);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 3;
            label2.Text = "Введите значение для c:";
  
            // 
            // textBox3
            // 
            textBox3.Location = new Point(436, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
           /* textBox3.TextChanged += textBox3_TextChanged;*/
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 231);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 5;
            label3.Text = "Введите значение для d:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(437, 262);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 8;
        /*    textBox4.TextChanged += textBox4_TextChanged;*/
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 270);
            label4.Name = "label4";
            label4.Size = new Size(138, 15);
            label4.TabIndex = 7;
            label4.Text = "Введите значение для x:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 308);
            label5.Name = "label5";
            label5.Size = new Size(212, 15);
            label5.TabIndex = 9;
            label5.Text = "Результат выполненной программы:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(341, 343);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(354, 23);
            textBox5.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(689, 398);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
    }
}

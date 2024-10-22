namespace Lab_15_WF
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(34, 255);
            button1.Name = "button1";
            button1.Size = new Size(108, 31);
            button1.TabIndex = 0;
            button1.Text = "Отсортировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SortButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 350);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 1;
            label1.Text = "Количество итераций:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 25);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 2;
            label2.Text = "Алгоритмы сортировки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(350, 395);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 3;
            label3.Text = "Бинарный поиск";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 153);
            label4.Name = "label4";
            label4.Size = new Size(185, 15);
            label4.TabIndex = 5;
            label4.Text = "Выберите алгоритм сортировки";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(34, 180);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(156, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Сортировка пузырьком";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(34, 205);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(146, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Сортировка выбором";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += SelectionSortButton_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(34, 230);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(138, 19);
            radioButton3.TabIndex = 8;
            radioButton3.TabStop = true;
            radioButton3.Text = "Быстрая сортировка";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += QuickSort_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(34, 72);
            button2.Name = "button2";
            button2.Size = new Size(189, 23);
            button2.TabIndex = 9;
            button2.Text = "Сгенерировать массив";
            button2.UseVisualStyleBackColor = true;
            button2.Click += GanerateArrayButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 121);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 10;
            label5.Text = "Созданный массив:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 309);
            label6.Name = "label6";
            label6.Size = new Size(158, 15);
            label6.TabIndex = 11;
            label6.Text = "Отсортированный массив: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 424);
            label7.Name = "label7";
            label7.Size = new Size(130, 15);
            label7.TabIndex = 12;
            label7.Text = "Количество итераций:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 509);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}

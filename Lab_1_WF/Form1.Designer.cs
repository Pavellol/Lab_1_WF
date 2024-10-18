namespace Lab_1_WF
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
            this.RedButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.YellowButton = new System.Windows.Forms.Button();
            this.Hello = new System.Windows.Forms.Button();
            this.GoodBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RedButton
            // 
            this.RedButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.RedButton.Location = new System.Drawing.Point(12, 12);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(100, 23);
            this.RedButton.TabIndex = 0;
            this.RedButton.Text = "красный";
            this.RedButton.UseVisualStyleBackColor = true;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.Location = new System.Drawing.Point(128, 12);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(75, 23);
            this.GreenButton.TabIndex = 1;
            this.GreenButton.Text = "зеленый";
            this.GreenButton.UseVisualStyleBackColor = true;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // BlueButton
            // 
            this.BlueButton.Location = new System.Drawing.Point(228, 12);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(75, 23);
            this.BlueButton.TabIndex = 2;
            this.BlueButton.Text = "синий";
            this.BlueButton.UseVisualStyleBackColor = true;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // YellowButton
            // 
            this.YellowButton.Location = new System.Drawing.Point(324, 12);
            this.YellowButton.Name = "YellowButton";
            this.YellowButton.Size = new System.Drawing.Size(75, 23);
            this.YellowButton.TabIndex = 3;
            this.YellowButton.Text = "желтый";
            this.YellowButton.UseVisualStyleBackColor = true;
            this.YellowButton.Click += new System.EventHandler(this.YellowButton_Click);
            // 
            // Hello
            // 
            this.Hello.Location = new System.Drawing.Point(37, 98);
            this.Hello.Name = "Hello";
            this.Hello.Size = new System.Drawing.Size(75, 23);
            this.Hello.TabIndex = 4;
            this.Hello.Text = "Привет\r\n";
            this.Hello.UseVisualStyleBackColor = true;
            this.Hello.Click += new System.EventHandler(this.HellowButton_Click);
            // 
            // GoodBuy
            // 
            this.GoodBuy.Location = new System.Drawing.Point(134, 98);
            this.GoodBuy.Name = "GoodBuy";
            this.GoodBuy.Size = new System.Drawing.Size(101, 23);
            this.GoodBuy.TabIndex = 5;
            this.GoodBuy.Text = "До свидания";
            this.GoodBuy.UseVisualStyleBackColor = true;
            this.GoodBuy.Click += new System.EventHandler(this.GoodBuyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoodBuy);
            this.Controls.Add(this.Hello);
            this.Controls.Add(this.YellowButton);
            this.Controls.Add(this.BlueButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.RedButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button YellowButton;
        private System.Windows.Forms.Button Hello;
        private System.Windows.Forms.Button GoodBuy;
        private System.Windows.Forms.Label label1;
    }
}


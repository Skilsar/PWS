namespace PWSLab_04_WinForms
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
            this.s1 = new System.Windows.Forms.TextBox();
            this.k1 = new System.Windows.Forms.TextBox();
            this.f1 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.k2 = new System.Windows.Forms.TextBox();
            this.f2 = new System.Windows.Forms.TextBox();
            this.getSumButton = new System.Windows.Forms.Button();
            this.a1Label = new System.Windows.Forms.Label();
            this.a2Label = new System.Windows.Forms.Label();
            this.result_1 = new System.Windows.Forms.TextBox();
            this.result_2 = new System.Windows.Forms.TextBox();
            this.result_3 = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(12, 26);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(189, 22);
            this.s1.TabIndex = 0;
            // 
            // k1
            // 
            this.k1.Location = new System.Drawing.Point(12, 54);
            this.k1.Name = "k1";
            this.k1.Size = new System.Drawing.Size(189, 22);
            this.k1.TabIndex = 1;
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(12, 84);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(189, 22);
            this.f1.TabIndex = 2;
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(227, 26);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(189, 22);
            this.s2.TabIndex = 3;
            // 
            // k2
            // 
            this.k2.Location = new System.Drawing.Point(227, 54);
            this.k2.Name = "k2";
            this.k2.Size = new System.Drawing.Size(189, 22);
            this.k2.TabIndex = 4;
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(227, 82);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(189, 22);
            this.f2.TabIndex = 5;
            // 
            // getSumButton
            // 
            this.getSumButton.Location = new System.Drawing.Point(446, 26);
            this.getSumButton.Name = "getSumButton";
            this.getSumButton.Size = new System.Drawing.Size(147, 80);
            this.getSumButton.TabIndex = 6;
            this.getSumButton.Text = "Sum";
            this.getSumButton.UseVisualStyleBackColor = true;
            this.getSumButton.Click += new System.EventHandler(this.getSumButton_Click);
            // 
            // a1Label
            // 
            this.a1Label.AutoSize = true;
            this.a1Label.Location = new System.Drawing.Point(13, 3);
            this.a1Label.Name = "a1Label";
            this.a1Label.Size = new System.Drawing.Size(24, 17);
            this.a1Label.TabIndex = 7;
            this.a1Label.Text = "a1";
            // 
            // a2Label
            // 
            this.a2Label.AutoSize = true;
            this.a2Label.Location = new System.Drawing.Point(227, 2);
            this.a2Label.Name = "a2Label";
            this.a2Label.Size = new System.Drawing.Size(24, 17);
            this.a2Label.TabIndex = 8;
            this.a2Label.Text = "a2";
            // 
            // result_1
            // 
            this.result_1.Location = new System.Drawing.Point(619, 26);
            this.result_1.Name = "result_1";
            this.result_1.Size = new System.Drawing.Size(189, 22);
            this.result_1.TabIndex = 9;
            // 
            // result_2
            // 
            this.result_2.Location = new System.Drawing.Point(619, 55);
            this.result_2.Name = "result_2";
            this.result_2.Size = new System.Drawing.Size(189, 22);
            this.result_2.TabIndex = 10;
            // 
            // result_3
            // 
            this.result_3.Location = new System.Drawing.Point(619, 84);
            this.result_3.Name = "result_3";
            this.result_3.Size = new System.Drawing.Size(189, 22);
            this.result_3.TabIndex = 11;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(619, 1);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(43, 17);
            this.resultLabel.TabIndex = 12;
            this.resultLabel.Text = "result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 117);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.result_3);
            this.Controls.Add(this.result_2);
            this.Controls.Add(this.result_1);
            this.Controls.Add(this.a2Label);
            this.Controls.Add(this.a1Label);
            this.Controls.Add(this.getSumButton);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.k1);
            this.Controls.Add(this.s1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox k1;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox k2;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.Button getSumButton;
        private System.Windows.Forms.Label a1Label;
        private System.Windows.Forms.Label a2Label;
        private System.Windows.Forms.TextBox result_1;
        private System.Windows.Forms.TextBox result_2;
        private System.Windows.Forms.TextBox result_3;
        private System.Windows.Forms.Label resultLabel;
    }
}


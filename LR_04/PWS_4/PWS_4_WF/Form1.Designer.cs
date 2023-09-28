
namespace PWS_4_WF
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
            this.buttonSum = new System.Windows.Forms.Button();
            this.labelS1 = new System.Windows.Forms.Label();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.textBoxF1 = new System.Windows.Forms.TextBox();
            this.textBoxK1 = new System.Windows.Forms.TextBox();
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.textBoxK2 = new System.Windows.Forms.TextBox();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.labelF2 = new System.Windows.Forms.Label();
            this.labelK2 = new System.Windows.Forms.Label();
            this.labelS2 = new System.Windows.Forms.Label();
            this.labelF1 = new System.Windows.Forms.Label();
            this.labelK1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResultS = new System.Windows.Forms.TextBox();
            this.textBoxResultK = new System.Windows.Forms.TextBox();
            this.textBoxResultF = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(528, 64);
            this.buttonSum.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(101, 29);
            this.buttonSum.TabIndex = 0;
            this.buttonSum.Text = "sum";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // labelS1
            // 
            this.labelS1.AutoSize = true;
            this.labelS1.Location = new System.Drawing.Point(54, 25);
            this.labelS1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(21, 16);
            this.labelS1.TabIndex = 1;
            this.labelS1.Text = "s1";
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(16, 64);
            this.textBoxS1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(132, 22);
            this.textBoxS1.TabIndex = 2;
            this.textBoxS1.Text = "AS";
            // 
            // textBoxF1
            // 
            this.textBoxF1.Location = new System.Drawing.Point(361, 64);
            this.textBoxF1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxF1.Name = "textBoxF1";
            this.textBoxF1.Size = new System.Drawing.Size(132, 22);
            this.textBoxF1.TabIndex = 3;
            this.textBoxF1.Text = "1,2";
            this.textBoxF1.TextChanged += new System.EventHandler(this.textBoxF1_TextChanged);
            // 
            // textBoxK1
            // 
            this.textBoxK1.Location = new System.Drawing.Point(187, 64);
            this.textBoxK1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxK1.Name = "textBoxK1";
            this.textBoxK1.Size = new System.Drawing.Size(132, 22);
            this.textBoxK1.TabIndex = 4;
            this.textBoxK1.Text = "2";
            // 
            // textBoxF2
            // 
            this.textBoxF2.Location = new System.Drawing.Point(361, 135);
            this.textBoxF2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.Size = new System.Drawing.Size(132, 22);
            this.textBoxF2.TabIndex = 5;
            this.textBoxF2.Text = "3,0";
            // 
            // textBoxK2
            // 
            this.textBoxK2.Location = new System.Drawing.Point(187, 135);
            this.textBoxK2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxK2.Name = "textBoxK2";
            this.textBoxK2.Size = new System.Drawing.Size(132, 22);
            this.textBoxK2.TabIndex = 6;
            this.textBoxK2.Text = "8";
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(16, 135);
            this.textBoxS2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(132, 22);
            this.textBoxS2.TabIndex = 7;
            this.textBoxS2.Text = "MX";
            // 
            // labelF2
            // 
            this.labelF2.AutoSize = true;
            this.labelF2.Location = new System.Drawing.Point(399, 112);
            this.labelF2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelF2.Name = "labelF2";
            this.labelF2.Size = new System.Drawing.Size(17, 16);
            this.labelF2.TabIndex = 10;
            this.labelF2.Text = "f2";
            // 
            // labelK2
            // 
            this.labelK2.AutoSize = true;
            this.labelK2.Location = new System.Drawing.Point(229, 106);
            this.labelK2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelK2.Name = "labelK2";
            this.labelK2.Size = new System.Drawing.Size(21, 16);
            this.labelK2.TabIndex = 11;
            this.labelK2.Text = "k2";
            // 
            // labelS2
            // 
            this.labelS2.AutoSize = true;
            this.labelS2.Location = new System.Drawing.Point(54, 106);
            this.labelS2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(21, 16);
            this.labelS2.TabIndex = 12;
            this.labelS2.Text = "s2";
            // 
            // labelF1
            // 
            this.labelF1.AutoSize = true;
            this.labelF1.Location = new System.Drawing.Point(399, 25);
            this.labelF1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelF1.Name = "labelF1";
            this.labelF1.Size = new System.Drawing.Size(17, 16);
            this.labelF1.TabIndex = 13;
            this.labelF1.Text = "f1";
            // 
            // labelK1
            // 
            this.labelK1.AutoSize = true;
            this.labelK1.Location = new System.Drawing.Point(229, 25);
            this.labelK1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelK1.Name = "labelK1";
            this.labelK1.Size = new System.Drawing.Size(21, 16);
            this.labelK1.TabIndex = 14;
            this.labelK1.Text = "k1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "k";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "f";
            // 
            // textBoxResultS
            // 
            this.textBoxResultS.Location = new System.Drawing.Point(16, 225);
            this.textBoxResultS.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxResultS.Name = "textBoxResultS";
            this.textBoxResultS.Size = new System.Drawing.Size(132, 22);
            this.textBoxResultS.TabIndex = 17;
            // 
            // textBoxResultK
            // 
            this.textBoxResultK.Location = new System.Drawing.Point(187, 225);
            this.textBoxResultK.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxResultK.Name = "textBoxResultK";
            this.textBoxResultK.Size = new System.Drawing.Size(132, 22);
            this.textBoxResultK.TabIndex = 16;
            // 
            // textBoxResultF
            // 
            this.textBoxResultF.Location = new System.Drawing.Point(361, 225);
            this.textBoxResultF.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxResultF.Name = "textBoxResultF";
            this.textBoxResultF.Size = new System.Drawing.Size(132, 22);
            this.textBoxResultF.TabIndex = 15;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.labelError.Location = new System.Drawing.Point(229, 268);
            this.labelError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 39);
            this.labelError.TabIndex = 21;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(528, 106);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(101, 29);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(657, 280);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxResultS);
            this.Controls.Add(this.textBoxResultK);
            this.Controls.Add(this.textBoxResultF);
            this.Controls.Add(this.labelK1);
            this.Controls.Add(this.labelF1);
            this.Controls.Add(this.labelS2);
            this.Controls.Add(this.labelK2);
            this.Controls.Add(this.labelF2);
            this.Controls.Add(this.textBoxS2);
            this.Controls.Add(this.textBoxK2);
            this.Controls.Add(this.textBoxF2);
            this.Controls.Add(this.textBoxK1);
            this.Controls.Add(this.textBoxF1);
            this.Controls.Add(this.textBoxS1);
            this.Controls.Add(this.labelS1);
            this.Controls.Add(this.buttonSum);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.Text = "Lab4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.TextBox textBoxF1;
        private System.Windows.Forms.TextBox textBoxK1;
        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.TextBox textBoxK2;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.Label labelF2;
        private System.Windows.Forms.Label labelK2;
        private System.Windows.Forms.Label labelS2;
        private System.Windows.Forms.Label labelF1;
        private System.Windows.Forms.Label labelK1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResultS;
        private System.Windows.Forms.TextBox textBoxResultK;
        private System.Windows.Forms.TextBox textBoxResultF;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonClear;
    }
}


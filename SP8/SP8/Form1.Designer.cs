namespace SP8
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
            this.button1 = new System.Windows.Forms.Button();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TB2 = new System.Windows.Forms.Label();
            this.tB1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Инфо о главном поотоке";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(341, 101);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(345, 294);
            this.PB1.TabIndex = 2;
            this.PB1.TabStop = false;
            this.PB1.Click += new System.EventHandler(this.PB1_Click);
            // 
            // PB2
            // 
            this.PB2.Location = new System.Drawing.Point(695, 101);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(321, 262);
            this.PB2.TabIndex = 3;
            this.PB2.TabStop = false;
            this.PB2.Click += new System.EventHandler(this.PB2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Пазл";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB2
            // 
            this.TB2.AutoSize = true;
            this.TB2.Location = new System.Drawing.Point(692, 31);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(0, 16);
            this.TB2.TabIndex = 6;
            // 
            // tB1
            // 
            this.tB1.AutoSize = true;
            this.tB1.Location = new System.Drawing.Point(31, 101);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(0, 16);
            this.tB1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 657);
            this.Controls.Add(this.tB1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TB2;
        private System.Windows.Forms.Label tB1;
    }
}


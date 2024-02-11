namespace SP6
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
            this.task1 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            this.task3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(41, 51);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(123, 51);
            this.task1.TabIndex = 0;
            this.task1.Text = "Task1";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            this.task1.Paint += new System.Windows.Forms.PaintEventHandler(this.task1_Paint);
            this.task1.Leave += new System.EventHandler(this.task1_Leave);
            this.task1.MouseEnter += new System.EventHandler(this.task1_MouseEnter);
            this.task1.MouseLeave += new System.EventHandler(this.task1_MouseLeave);
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(41, 118);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(123, 51);
            this.task2.TabIndex = 1;
            this.task2.Text = "Task2";
            this.task2.UseVisualStyleBackColor = true;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            this.task2.Paint += new System.Windows.Forms.PaintEventHandler(this.task2_Paint);
            this.task2.Leave += new System.EventHandler(this.task2_Leave);
            this.task2.MouseEnter += new System.EventHandler(this.task2_MouseEnter);
            this.task2.MouseLeave += new System.EventHandler(this.task2_MouseLeave);
            // 
            // task3
            // 
            this.task3.Location = new System.Drawing.Point(41, 190);
            this.task3.Name = "task3";
            this.task3.Size = new System.Drawing.Size(123, 51);
            this.task3.TabIndex = 2;
            this.task3.Text = "Task3";
            this.task3.UseVisualStyleBackColor = true;
            this.task3.Click += new System.EventHandler(this.task3_Click);
            this.task3.Paint += new System.Windows.Forms.PaintEventHandler(this.task3_Paint);
            this.task3.MouseEnter += new System.EventHandler(this.task3_MouseEnter);
            this.task3.MouseLeave += new System.EventHandler(this.task3_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(361, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 324);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.task3);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Button task2;
        private System.Windows.Forms.Button task3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


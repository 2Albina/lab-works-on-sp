namespace LR6_list
{
    partial class List
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
            this.textFirm = new System.Windows.Forms.TextBox();
            this.textType = new System.Windows.Forms.TextBox();
            this.textPower = new System.Windows.Forms.TextBox();
            this.AddBut = new System.Windows.Forms.Button();
            this.TaskBut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.ButChange = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textFirm
            // 
            this.textFirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFirm.Location = new System.Drawing.Point(294, 79);
            this.textFirm.Name = "textFirm";
            this.textFirm.Size = new System.Drawing.Size(239, 30);
            this.textFirm.TabIndex = 0;
            this.textFirm.Text = "Фирма-изготовитель";
            this.textFirm.TextChanged += new System.EventHandler(this.textFirm_TextChanged);
            // 
            // textType
            // 
            this.textType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textType.Location = new System.Drawing.Point(294, 126);
            this.textType.Name = "textType";
            this.textType.Size = new System.Drawing.Size(239, 30);
            this.textType.TabIndex = 1;
            this.textType.Text = "Тип";
            // 
            // textPower
            // 
            this.textPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPower.Location = new System.Drawing.Point(294, 174);
            this.textPower.Name = "textPower";
            this.textPower.Size = new System.Drawing.Size(239, 30);
            this.textPower.TabIndex = 2;
            this.textPower.Text = "Мощность";
            // 
            // AddBut
            // 
            this.AddBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBut.Location = new System.Drawing.Point(589, 115);
            this.AddBut.Name = "AddBut";
            this.AddBut.Size = new System.Drawing.Size(166, 47);
            this.AddBut.TabIndex = 3;
            this.AddBut.Text = "Добавить";
            this.AddBut.UseVisualStyleBackColor = true;
            this.AddBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaskBut
            // 
            this.TaskBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskBut.Location = new System.Drawing.Point(331, 317);
            this.TaskBut.Name = "TaskBut";
            this.TaskBut.Size = new System.Drawing.Size(156, 68);
            this.TaskBut.TabIndex = 5;
            this.TaskBut.Text = "Задания";
            this.TaskBut.UseVisualStyleBackColor = true;
            this.TaskBut.Click += new System.EventHandler(this.TaskBut_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBut.Location = new System.Drawing.Point(599, 317);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(156, 68);
            this.CloseBut.TabIndex = 8;
            this.CloseBut.Text = "Закрыть";
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // ButChange
            // 
            this.ButChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButChange.Location = new System.Drawing.Point(54, 317);
            this.ButChange.Name = "ButChange";
            this.ButChange.Size = new System.Drawing.Size(156, 68);
            this.ButChange.TabIndex = 9;
            this.ButChange.Text = "Изменения";
            this.ButChange.UseVisualStyleBackColor = true;
            this.ButChange.Click += new System.EventHandler(this.ButChange_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фирма-изготовитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Мощность";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButChange);
            this.Controls.Add(this.CloseBut);
            this.Controls.Add(this.TaskBut);
            this.Controls.Add(this.AddBut);
            this.Controls.Add(this.textPower);
            this.Controls.Add(this.textType);
            this.Controls.Add(this.textFirm);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFirm;
        private System.Windows.Forms.TextBox textType;
        private System.Windows.Forms.TextBox textPower;
        private System.Windows.Forms.Button AddBut;
        private System.Windows.Forms.Button TaskBut;
        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.Button ButChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
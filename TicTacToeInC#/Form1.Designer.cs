namespace TicTacToeInC_
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelDraw = new System.Windows.Forms.Label();
            this.ResetScoreButt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 49);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(286, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.A1.FlatAppearance.BorderSize = 0;
            this.A1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(18, 79);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(103, 87);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.A1_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.A2.FlatAppearance.BorderSize = 0;
            this.A2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(127, 79);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(103, 87);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.A2_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.A3.FlatAppearance.BorderSize = 0;
            this.A3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(236, 79);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(103, 87);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.A3_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.B2.FlatAppearance.BorderSize = 0;
            this.B2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(127, 172);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(103, 87);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.B3.FlatAppearance.BorderSize = 0;
            this.B3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(236, 172);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(103, 87);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.B1.FlatAppearance.BorderSize = 0;
            this.B1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(18, 172);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(103, 87);
            this.B1.TabIndex = 6;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.C1.FlatAppearance.BorderSize = 0;
            this.C1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(18, 265);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(103, 87);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.C1_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.C2.FlatAppearance.BorderSize = 0;
            this.C2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(127, 265);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(103, 87);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.C2_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.C3.FlatAppearance.BorderSize = 0;
            this.C3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(236, 265);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(103, 87);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.C3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "X:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(60, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "O:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(107, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Draw:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(38, 398);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(25, 22);
            this.labelX.TabIndex = 13;
            this.labelX.Text = " 0";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelO.Location = new System.Drawing.Point(86, 398);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(25, 22);
            this.labelO.TabIndex = 14;
            this.labelO.Text = " 0";
            // 
            // labelDraw
            // 
            this.labelDraw.AutoSize = true;
            this.labelDraw.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDraw.Location = new System.Drawing.Point(163, 398);
            this.labelDraw.Name = "labelDraw";
            this.labelDraw.Size = new System.Drawing.Size(25, 22);
            this.labelDraw.TabIndex = 15;
            this.labelDraw.Text = " 0";
            // 
            // ResetScoreButt
            // 
            this.ResetScoreButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(137)))), ((int)(((byte)(222)))));
            this.ResetScoreButt.FlatAppearance.BorderSize = 0;
            this.ResetScoreButt.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetScoreButt.Location = new System.Drawing.Point(236, 393);
            this.ResetScoreButt.Name = "ResetScoreButt";
            this.ResetScoreButt.Size = new System.Drawing.Size(103, 35);
            this.ResetScoreButt.TabIndex = 16;
            this.ResetScoreButt.Text = "Reset Score";
            this.ResetScoreButt.UseVisualStyleBackColor = false;
            this.ResetScoreButt.Click += new System.EventHandler(this.ResetScoreButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(360, 446);
            this.Controls.Add(this.ResetScoreButt);
            this.Controls.Add(this.labelDraw);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelDraw;
        private System.Windows.Forms.Button ResetScoreButt;
    }
}


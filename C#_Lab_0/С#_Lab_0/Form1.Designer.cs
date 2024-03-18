namespace С__Lab_0
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
            this.label0 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.find_square = new System.Windows.Forms.Button();
            this.find_perimeter = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Perimeter = new System.Windows.Forms.TextBox();
            this.Squar = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Figure = new System.Windows.Forms.Panel();
            this.y3 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.Point3 = new System.Windows.Forms.Label();
            this.Point2 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.Point1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Draw = new System.Windows.Forms.Button();
            this.Result.SuspendLayout();
            this.Figure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(12, 9);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(81, 16);
            this.label0.TabIndex = 5;
            this.label0.Text = "Select figure";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Triangle",
            "Circle",
            "Square",
            "Rectangle"});
            this.listBox1.Location = new System.Drawing.Point(15, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // find_square
            // 
            this.find_square.Location = new System.Drawing.Point(21, 105);
            this.find_square.Name = "find_square";
            this.find_square.Size = new System.Drawing.Size(95, 23);
            this.find_square.TabIndex = 7;
            this.find_square.Text = "Find square";
            this.find_square.UseVisualStyleBackColor = true;
            this.find_square.Click += new System.EventHandler(this.button1_Click);
            // 
            // find_perimeter
            // 
            this.find_perimeter.Location = new System.Drawing.Point(21, 17);
            this.find_perimeter.Name = "find_perimeter";
            this.find_perimeter.Size = new System.Drawing.Size(109, 23);
            this.find_perimeter.TabIndex = 8;
            this.find_perimeter.Text = "Find perimeter";
            this.find_perimeter.UseVisualStyleBackColor = true;
            this.find_perimeter.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Perimeter:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Square:";
            // 
            // Perimeter
            // 
            this.Perimeter.Location = new System.Drawing.Point(104, 52);
            this.Perimeter.Name = "Perimeter";
            this.Perimeter.ReadOnly = true;
            this.Perimeter.Size = new System.Drawing.Size(100, 22);
            this.Perimeter.TabIndex = 11;
            // 
            // Squar
            // 
            this.Squar.Location = new System.Drawing.Point(104, 143);
            this.Squar.Name = "Squar";
            this.Squar.ReadOnly = true;
            this.Squar.Size = new System.Drawing.Size(100, 22);
            this.Squar.TabIndex = 12;
            // 
            // Result
            // 
            this.Result.Controls.Add(this.find_perimeter);
            this.Result.Controls.Add(this.find_square);
            this.Result.Controls.Add(this.label9);
            this.Result.Controls.Add(this.Squar);
            this.Result.Controls.Add(this.label10);
            this.Result.Controls.Add(this.Perimeter);
            this.Result.Location = new System.Drawing.Point(524, 12);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(239, 199);
            this.Result.TabIndex = 17;
            this.Result.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Triangle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the data";
            // 
            // Figure
            // 
            this.Figure.Controls.Add(this.y3);
            this.Figure.Controls.Add(this.x3);
            this.Figure.Controls.Add(this.y2);
            this.Figure.Controls.Add(this.x2);
            this.Figure.Controls.Add(this.y1);
            this.Figure.Controls.Add(this.x1);
            this.Figure.Controls.Add(this.Point3);
            this.Figure.Controls.Add(this.Point2);
            this.Figure.Controls.Add(this.Y);
            this.Figure.Controls.Add(this.X);
            this.Figure.Controls.Add(this.Point1);
            this.Figure.Controls.Add(this.label1);
            this.Figure.Controls.Add(this.label2);
            this.Figure.Location = new System.Drawing.Point(206, 12);
            this.Figure.Name = "Figure";
            this.Figure.Size = new System.Drawing.Size(303, 187);
            this.Figure.TabIndex = 4;
            this.Figure.Visible = false;
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(183, 133);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(59, 22);
            this.y3.TabIndex = 22;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(105, 133);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(59, 22);
            this.x3.TabIndex = 21;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(183, 102);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(59, 22);
            this.y2.TabIndex = 20;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(105, 102);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(59, 22);
            this.x2.TabIndex = 19;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(183, 71);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(59, 22);
            this.y1.TabIndex = 18;
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(105, 71);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(59, 22);
            this.x1.TabIndex = 17;
            // 
            // Point3
            // 
            this.Point3.AutoSize = true;
            this.Point3.Location = new System.Drawing.Point(17, 136);
            this.Point3.Name = "Point3";
            this.Point3.Size = new System.Drawing.Size(47, 16);
            this.Point3.TabIndex = 16;
            this.Point3.Text = "Point 3";
            // 
            // Point2
            // 
            this.Point2.AutoSize = true;
            this.Point2.Location = new System.Drawing.Point(17, 105);
            this.Point2.Name = "Point2";
            this.Point2.Size = new System.Drawing.Size(47, 16);
            this.Point2.TabIndex = 15;
            this.Point2.Text = "Point 2";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(207, 42);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(16, 16);
            this.Y.TabIndex = 14;
            this.Y.Text = "Y";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(126, 42);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(15, 16);
            this.X.TabIndex = 13;
            this.X.Text = "X";
            // 
            // Point1
            // 
            this.Point1.AutoSize = true;
            this.Point1.Location = new System.Drawing.Point(17, 74);
            this.Point1.Name = "Point1";
            this.Point1.Size = new System.Drawing.Size(47, 16);
            this.Point1.TabIndex = 12;
            this.Point1.Text = "Point 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(37, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 299);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(677, 355);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(150, 89);
            this.Draw.TabIndex = 19;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 615);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.Figure);
            this.Name = "Form1";
            this.Text = "Lab_0_option_0";
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.Figure.ResumeLayout(false);
            this.Figure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button find_square;
        private System.Windows.Forms.Button find_perimeter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Perimeter;
        private System.Windows.Forms.TextBox Squar;
        private System.Windows.Forms.Panel Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Figure;
        private System.Windows.Forms.Label Point1;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.Label Point3;
        private System.Windows.Forms.Label Point2;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Draw;
    }
}


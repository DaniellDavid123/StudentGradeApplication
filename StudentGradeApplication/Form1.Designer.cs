namespace StudentGradeApplication
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
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEnglish = new TextBox();
            txtMath = new TextBox();
            txtFilipino = new TextBox();
            txtScience = new TextBox();
            txtHistory = new TextBox();
            label7 = new Label();
            aveg_result = new Button();
            General_Average = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 22);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(92, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(307, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 91);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "English";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 285);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 3;
            label3.Text = "History";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 242);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 4;
            label4.Text = "Filipino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 135);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 5;
            label5.Text = "Math";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 181);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 6;
            label6.Text = "Science";
            // 
            // txtEnglish
            // 
            txtEnglish.Location = new Point(108, 84);
            txtEnglish.Name = "txtEnglish";
            txtEnglish.Size = new Size(130, 27);
            txtEnglish.TabIndex = 7;
            txtEnglish.TextChanged += txtEnglish_TextChanged;
            // 
            // txtMath
            // 
            txtMath.Location = new Point(108, 132);
            txtMath.Name = "txtMath";
            txtMath.Size = new Size(130, 27);
            txtMath.TabIndex = 8;
            txtMath.TextChanged += txtMath_TextChanged;
            // 
            // txtFilipino
            // 
            txtFilipino.Location = new Point(108, 235);
            txtFilipino.Name = "txtFilipino";
            txtFilipino.Size = new Size(130, 27);
            txtFilipino.TabIndex = 9;
            txtFilipino.TextChanged += txtFilipino_TextChanged;
            // 
            // txtScience
            // 
            txtScience.Location = new Point(108, 178);
            txtScience.Name = "txtScience";
            txtScience.Size = new Size(130, 27);
            txtScience.TabIndex = 10;
            txtScience.TextChanged += txtScience_TextChanged;
            // 
            // txtHistory
            // 
            txtHistory.Location = new Point(108, 285);
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(130, 27);
            txtHistory.TabIndex = 11;
            txtHistory.TextChanged += txtHistory_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(113, 58);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 12;
            label7.Text = "Grades";
            label7.Click += label7_Click;
            // 
            // aveg_result
            // 
            aveg_result.Location = new Point(36, 339);
            aveg_result.Name = "aveg_result";
            aveg_result.Size = new Size(173, 76);
            aveg_result.TabIndex = 13;
            aveg_result.Text = "General \r\nAverage\r\n";
            aveg_result.UseVisualStyleBackColor = true;
            aveg_result.Click += button1_Click;
            // 
            // General_Average
            // 
            General_Average.AutoSize = true;
            General_Average.Location = new Point(542, 89);
            General_Average.Name = "General_Average";
            General_Average.Size = new Size(0, 20);
            General_Average.TabIndex = 14;
            General_Average.Click += General_Average_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(General_Average);
            Controls.Add(aveg_result);
            Controls.Add(label7);
            Controls.Add(txtHistory);
            Controls.Add(txtScience);
            Controls.Add(txtFilipino);
            Controls.Add(txtMath);
            Controls.Add(txtEnglish);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEnglish;
        private TextBox txtMath;
        private TextBox txtFilipino;
        private TextBox txtScience;
        private TextBox txtHistory;
        private Label label7;
        private Button aveg_result;
        private Label General_Average;
    }
}

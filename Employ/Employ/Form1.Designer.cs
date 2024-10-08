namespace Employ
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
            FnameTB = new TextBox();
            LnameTB = new TextBox();
            label2 = new Label();
            JobtitetB = new TextBox();
            label3 = new Label();
            DepartTB = new TextBox();
            label4 = new Label();
            WhrTB = new TextBox();
            label5 = new Label();
            ratehrTB = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            BasicSTB = new Label();
            LnameLB = new Label();
            FnameLB = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(100, 230);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(123, 30);
            button1.TabIndex = 0;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "First name";
            
            // 
            // FnameTB
            // 
            FnameTB.Location = new Point(10, 46);
            FnameTB.Margin = new Padding(4);
            FnameTB.Name = "FnameTB";
            FnameTB.Size = new Size(149, 27);
            FnameTB.TabIndex = 2;
            // 
            // LnameTB
            // 
            LnameTB.Location = new Point(166, 46);
            LnameTB.Margin = new Padding(4);
            LnameTB.Name = "LnameTB";
            LnameTB.Size = new Size(149, 27);
            LnameTB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 3;
            label2.Text = "Last name";
            // 
            // JobtitetB
            // 
            JobtitetB.Location = new Point(166, 103);
            JobtitetB.Margin = new Padding(4);
            JobtitetB.Name = "JobtitetB";
            JobtitetB.Size = new Size(149, 27);
            JobtitetB.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 79);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 7;
            label3.Text = "Job title";
            // 
            // DepartTB
            // 
            DepartTB.Location = new Point(10, 103);
            DepartTB.Margin = new Padding(4);
            DepartTB.Name = "DepartTB";
            DepartTB.Size = new Size(149, 27);
            DepartTB.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(10, 79);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 5;
            label4.Text = "Department";
            // 
            // WhrTB
            // 
            WhrTB.Location = new Point(166, 196);
            WhrTB.Margin = new Padding(4);
            WhrTB.Name = "WhrTB";
            WhrTB.Size = new Size(149, 27);
            WhrTB.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(166, 172);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(172, 25);
            label5.TabIndex = 11;
            label5.Text = "Total worked hours";
            // 
            // ratehrTB
            // 
            ratehrTB.Location = new Point(10, 196);
            ratehrTB.Margin = new Padding(4);
            ratehrTB.Name = "ratehrTB";
            ratehrTB.Size = new Size(149, 27);
            ratehrTB.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 172);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(127, 25);
            label6.TabIndex = 9;
            label6.Text = "Rate per hour";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 296);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 13;
            label7.Text = "First name :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 326);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 25);
            label8.TabIndex = 14;
            label8.Text = "Last name :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 356);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 15;
            label9.Text = "Basic Salary :";
            // 
            // BasicSTB
            // 
            BasicSTB.AutoSize = true;
            BasicSTB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BasicSTB.Location = new Point(105, 356);
            BasicSTB.Margin = new Padding(4, 0, 4, 0);
            BasicSTB.Name = "BasicSTB";
            BasicSTB.Size = new Size(56, 25);
            BasicSTB.TabIndex = 18;
            BasicSTB.Text = "00.00";
            
            // 
            // LnameLB
            // 
            LnameLB.AutoSize = true;
            LnameLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LnameLB.Location = new Point(105, 326);
            LnameLB.Margin = new Padding(4, 0, 4, 0);
            LnameLB.Name = "LnameLB";
            LnameLB.Size = new Size(123, 25);
            LnameLB.TabIndex = 17;
            LnameLB.Text = "<Last name>";
            LnameLB.Click += LnameLB_Click;
            // 
            // FnameLB
            // 
            FnameLB.AutoSize = true;
            FnameLB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FnameLB.Location = new Point(105, 296);
            FnameLB.Margin = new Padding(4, 0, 4, 0);
            FnameLB.Name = "FnameLB";
            FnameLB.Size = new Size(125, 25);
            FnameLB.TabIndex = 16;
            FnameLB.Text = "<First name>";
            FnameLB.Click += FnameLB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 438);
            Controls.Add(BasicSTB);
            Controls.Add(LnameLB);
            Controls.Add(FnameLB);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(WhrTB);
            Controls.Add(label5);
            Controls.Add(ratehrTB);
            Controls.Add(label6);
            Controls.Add(JobtitetB);
            Controls.Add(label3);
            Controls.Add(DepartTB);
            Controls.Add(label4);
            Controls.Add(LnameTB);
            Controls.Add(label2);
            Controls.Add(FnameTB);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox FnameTB;
        private TextBox LnameTB;
        private Label label2;
        private TextBox JobtitetB;
        private Label label3;
        private TextBox DepartTB;
        private Label label4;
        private TextBox WhrTB;
        private Label label5;
        private TextBox ratehrTB;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label BasicSTB;
        private Label LnameLB;
        private Label FnameLB;
    }
}

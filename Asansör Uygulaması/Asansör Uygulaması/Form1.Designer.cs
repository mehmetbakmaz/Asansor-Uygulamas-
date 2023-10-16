namespace Asansör_Uygulaması
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Location = new Point(89, 65);
            label1.Name = "label1";
            label1.Size = new Size(88, 444);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Location = new Point(415, 65);
            label2.Name = "label2";
            label2.Size = new Size(88, 444);
            label2.TabIndex = 0;
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Location = new Point(89, 65);
            label3.Name = "label3";
            label3.Size = new Size(414, 28);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.BackColor = Color.Turquoise;
            label4.Location = new Point(89, 390);
            label4.Name = "label4";
            label4.Size = new Size(88, 64);
            label4.TabIndex = 1;
            // 
            // label5
            // 
            label5.BackColor = Color.Turquoise;
            label5.Location = new Point(89, 141);
            label5.Name = "label5";
            label5.Size = new Size(88, 64);
            label5.TabIndex = 2;
            // 
            // label6
            // 
            label6.BackColor = Color.Turquoise;
            label6.Location = new Point(415, 141);
            label6.Name = "label6";
            label6.Size = new Size(88, 64);
            label6.TabIndex = 3;
            // 
            // label7
            // 
            label7.BackColor = Color.Turquoise;
            label7.Location = new Point(415, 390);
            label7.Name = "label7";
            label7.Size = new Size(88, 64);
            label7.TabIndex = 4;
            // 
            // label8
            // 
            label8.BackColor = Color.Sienna;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(252, 390);
            label8.Name = "label8";
            label8.Size = new Size(73, 64);
            label8.TabIndex = 5;
            label8.Text = "DOOR";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(531, 251);
            button1.Name = "button1";
            button1.Size = new Size(97, 71);
            button1.TabIndex = 6;
            button1.Text = "UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Font = new Font("Unispace", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(655, 251);
            button2.Name = "button2";
            button2.Size = new Size(97, 71);
            button2.TabIndex = 6;
            button2.Text = "DOWN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(605, 171);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(23, 28);
            label9.TabIndex = 7;
            label9.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 518);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Label label9;
    }
}
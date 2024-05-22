namespace PW2
{
    partial class ReguisterForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            textBox_email = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(399, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 29);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "NAME";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 193);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 5;
            label3.Text = "USERNAME\r\n";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(67, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(399, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 344);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 7;
            label4.Text = "REPEAT THE PASSWORD";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(67, 381);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(399, 27);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 270);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 9;
            label5.Text = "PASSWORD";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(67, 304);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(399, 27);
            textBox5.TabIndex = 8;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(551, 88);
            button1.Name = "button1";
            button1.Size = new Size(171, 102);
            button1.TabIndex = 10;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(551, 228);
            button2.Name = "button2";
            button2.Size = new Size(171, 102);
            button2.TabIndex = 11;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 112);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 13;
            label2.Text = "EMAIL";
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(67, 146);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(399, 27);
            textBox_email.TabIndex = 12;
            textBox_email.TextChanged += textBox_email_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(572, 381);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 24);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Policy Agreement";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReguisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(textBox_email);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "ReguisterForm";
            Text = "ReguisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Label label2;
        private TextBox textBox_email;
        private CheckBox checkBox1;
    }
}
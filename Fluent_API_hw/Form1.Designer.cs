namespace Fluent_API_hw
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            listBox1 = new ListBox();
            textBox6 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(236, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 356);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(21, 441);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(236, 39);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 53);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 136);
            label2.Name = "label2";
            label2.Size = new Size(109, 32);
            label2.TabIndex = 7;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 229);
            label3.Name = "label3";
            label3.Size = new Size(56, 32);
            label3.TabIndex = 8;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 321);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 9;
            label4.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 406);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 10;
            label5.Text = "Salary";
            // 
            // button1
            // 
            button1.Location = new Point(65, 519);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(39, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 662);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee info";
            // 
            // button3
            // 
            button3.Location = new Point(65, 615);
            button3.Name = "button3";
            button3.Size = new Size(132, 42);
            button3.TabIndex = 13;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(65, 567);
            button2.Name = "button2";
            button2.Size = new Size(132, 42);
            button2.TabIndex = 13;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(805, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 467);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Find by...";
            // 
            // button4
            // 
            button4.Location = new Point(127, 404);
            button4.Name = "button4";
            button4.Size = new Size(132, 42);
            button4.TabIndex = 14;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(48, 285);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(108, 36);
            radioButton5.TabIndex = 14;
            radioButton5.TabStop = true;
            radioButton5.Text = "Salary";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(48, 230);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(129, 36);
            radioButton4.TabIndex = 14;
            radioButton4.TabStop = true;
            radioButton4.Text = "Position";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(48, 177);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(87, 36);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Age";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(48, 123);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(140, 36);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Surname";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(48, 70);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(109, 36);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Name";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(805, 530);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(400, 228);
            listBox1.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(78, 354);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(236, 39);
            textBox6.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 910);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private GroupBox groupBox2;
        private Button button4;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListBox listBox1;
        private TextBox textBox6;
    }
}

namespace Fluent_API_hw
{
    partial class Authorization
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 181);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 44);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 11;
            label1.Text = "Login";
            // 
            // button1
            // 
            button1.Location = new Point(313, 311);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(402, 39);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 39);
            textBox1.TabIndex = 7;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Authorization";
            Text = "Authorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
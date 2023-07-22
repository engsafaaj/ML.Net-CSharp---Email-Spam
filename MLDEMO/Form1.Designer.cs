namespace MLDEMO
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
            richTextBoxInputEmail = new RichTextBox();
            buttonDetect = new Button();
            label2 = new Label();
            textBoxReuslt = new TextBox();
            label3 = new Label();
            labelSpamValue = new Label();
            label5 = new Label();
            labelNotSpamValue = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 50);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "Input Email";
            // 
            // richTextBoxInputEmail
            // 
            richTextBoxInputEmail.Location = new Point(80, 107);
            richTextBoxInputEmail.Name = "richTextBoxInputEmail";
            richTextBoxInputEmail.Size = new Size(843, 162);
            richTextBoxInputEmail.TabIndex = 1;
            richTextBoxInputEmail.Text = "";
            // 
            // buttonDetect
            // 
            buttonDetect.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDetect.Location = new Point(80, 292);
            buttonDetect.Name = "buttonDetect";
            buttonDetect.Size = new Size(843, 75);
            buttonDetect.TabIndex = 2;
            buttonDetect.Text = "Detect Email";
            buttonDetect.UseVisualStyleBackColor = true;
            buttonDetect.Click += buttonDetect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(69, 400);
            label2.Name = "label2";
            label2.Size = new Size(289, 32);
            label2.TabIndex = 0;
            label2.Text = "Result (Spam / Not Spam)";
            // 
            // textBoxReuslt
            // 
            textBoxReuslt.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxReuslt.Location = new Point(77, 446);
            textBoxReuslt.Name = "textBoxReuslt";
            textBoxReuslt.Size = new Size(846, 39);
            textBoxReuslt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(69, 498);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 0;
            label3.Text = "Spam:";
            label3.Click += label3_Click;
            // 
            // labelSpamValue
            // 
            labelSpamValue.AutoSize = true;
            labelSpamValue.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSpamValue.Location = new Point(154, 498);
            labelSpamValue.Name = "labelSpamValue";
            labelSpamValue.Size = new Size(71, 32);
            labelSpamValue.TabIndex = 0;
            labelSpamValue.Text = "00.00";
            labelSpamValue.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(303, 498);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 0;
            label5.Text = "Not Spam:";
            label5.Click += label3_Click;
            // 
            // labelNotSpamValue
            // 
            labelNotSpamValue.AutoSize = true;
            labelNotSpamValue.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelNotSpamValue.Location = new Point(435, 498);
            labelNotSpamValue.Name = "labelNotSpamValue";
            labelNotSpamValue.Size = new Size(71, 32);
            labelNotSpamValue.TabIndex = 0;
            labelNotSpamValue.Text = "00.00";
            labelNotSpamValue.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 595);
            Controls.Add(textBoxReuslt);
            Controls.Add(buttonDetect);
            Controls.Add(richTextBoxInputEmail);
            Controls.Add(labelNotSpamValue);
            Controls.Add(label5);
            Controls.Add(labelSpamValue);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxInputEmail;
        private Button buttonDetect;
        private Label label2;
        private TextBox textBoxReuslt;
        private Label label3;
        private Label labelSpamValue;
        private Label label5;
        private Label labelNotSpamValue;
    }
}
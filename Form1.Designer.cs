namespace CS311_FinalProject_Zts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rdoCon1 = new System.Windows.Forms.RadioButton();
            this.rdoCon3 = new System.Windows.Forms.RadioButton();
            this.rdoCon5 = new System.Windows.Forms.RadioButton();
            this.rdoCon7 = new System.Windows.Forms.RadioButton();
            this.rdoCon9 = new System.Windows.Forms.RadioButton();
            this.rdoCon10 = new System.Windows.Forms.RadioButton();
            this.rdoCon8 = new System.Windows.Forms.RadioButton();
            this.rdoCon6 = new System.Windows.Forms.RadioButton();
            this.rdoCon4 = new System.Windows.Forms.RadioButton();
            this.rdoCon2 = new System.Windows.Forms.RadioButton();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.txtUnit1 = new System.Windows.Forms.TextBox();
            this.txtUnit2 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitle.Location = new System.Drawing.Point(282, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(330, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Unit Converter ";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConvert.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(567, 299);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(132, 35);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rdoCon1
            // 
            this.rdoCon1.AutoSize = true;
            this.rdoCon1.Location = new System.Drawing.Point(35, 132);
            this.rdoCon1.Name = "rdoCon1";
            this.rdoCon1.Size = new System.Drawing.Size(100, 19);
            this.rdoCon1.TabIndex = 2;
            this.rdoCon1.TabStop = true;
            this.rdoCon1.Text = "Meters to Feet";
            this.rdoCon1.UseVisualStyleBackColor = true;
            this.rdoCon1.CheckedChanged += new System.EventHandler(this.rdoCon1_CheckedChanged);
            // 
            // rdoCon3
            // 
            this.rdoCon3.AutoSize = true;
            this.rdoCon3.Location = new System.Drawing.Point(198, 132);
            this.rdoCon3.Name = "rdoCon3";
            this.rdoCon3.Size = new System.Drawing.Size(126, 19);
            this.rdoCon3.TabIndex = 3;
            this.rdoCon3.TabStop = true;
            this.rdoCon3.Text = "Kilometers to Miles";
            this.rdoCon3.UseVisualStyleBackColor = true;
            this.rdoCon3.CheckedChanged += new System.EventHandler(this.rdoCon3_CheckedChanged);
            // 
            // rdoCon5
            // 
            this.rdoCon5.AutoSize = true;
            this.rdoCon5.Location = new System.Drawing.Point(378, 132);
            this.rdoCon5.Name = "rdoCon5";
            this.rdoCon5.Size = new System.Drawing.Size(135, 19);
            this.rdoCon5.TabIndex = 4;
            this.rdoCon5.TabStop = true;
            this.rdoCon5.Text = "Celsius to Fahrenheit";
            this.rdoCon5.UseVisualStyleBackColor = true;
            this.rdoCon5.CheckedChanged += new System.EventHandler(this.rdoCon5_CheckedChanged);
            // 
            // rdoCon7
            // 
            this.rdoCon7.AutoSize = true;
            this.rdoCon7.Location = new System.Drawing.Point(567, 132);
            this.rdoCon7.Name = "rdoCon7";
            this.rdoCon7.Size = new System.Drawing.Size(135, 19);
            this.rdoCon7.TabIndex = 5;
            this.rdoCon7.TabStop = true;
            this.rdoCon7.Text = "Kilograms to Pounds";
            this.rdoCon7.UseVisualStyleBackColor = true;
            this.rdoCon7.CheckedChanged += new System.EventHandler(this.rdoCon7_CheckedChanged);
            // 
            // rdoCon9
            // 
            this.rdoCon9.AutoSize = true;
            this.rdoCon9.Location = new System.Drawing.Point(740, 132);
            this.rdoCon9.Name = "rdoCon9";
            this.rdoCon9.Size = new System.Drawing.Size(116, 19);
            this.rdoCon9.TabIndex = 6;
            this.rdoCon9.TabStop = true;
            this.rdoCon9.Text = "Grams to Ounces";
            this.rdoCon9.UseVisualStyleBackColor = true;
            this.rdoCon9.CheckedChanged += new System.EventHandler(this.rdoCon9_CheckedChanged);
            // 
            // rdoCon10
            // 
            this.rdoCon10.AutoSize = true;
            this.rdoCon10.Location = new System.Drawing.Point(740, 168);
            this.rdoCon10.Name = "rdoCon10";
            this.rdoCon10.Size = new System.Drawing.Size(116, 19);
            this.rdoCon10.TabIndex = 11;
            this.rdoCon10.TabStop = true;
            this.rdoCon10.Text = "Ounces to Grams";
            this.rdoCon10.UseVisualStyleBackColor = true;
            this.rdoCon10.CheckedChanged += new System.EventHandler(this.rdoCon10_CheckedChanged);
            // 
            // rdoCon8
            // 
            this.rdoCon8.AutoSize = true;
            this.rdoCon8.Location = new System.Drawing.Point(567, 168);
            this.rdoCon8.Name = "rdoCon8";
            this.rdoCon8.Size = new System.Drawing.Size(138, 19);
            this.rdoCon8.TabIndex = 10;
            this.rdoCon8.TabStop = true;
            this.rdoCon8.Text = "Pounds to Kilograms ";
            this.rdoCon8.UseVisualStyleBackColor = true;
            this.rdoCon8.CheckedChanged += new System.EventHandler(this.rdoCon8_CheckedChanged);
            // 
            // rdoCon6
            // 
            this.rdoCon6.AutoSize = true;
            this.rdoCon6.Location = new System.Drawing.Point(378, 168);
            this.rdoCon6.Name = "rdoCon6";
            this.rdoCon6.Size = new System.Drawing.Size(138, 19);
            this.rdoCon6.TabIndex = 9;
            this.rdoCon6.TabStop = true;
            this.rdoCon6.Text = "Fahrenheit to Celsius ";
            this.rdoCon6.UseVisualStyleBackColor = true;
            this.rdoCon6.CheckedChanged += new System.EventHandler(this.rdoCon6_CheckedChanged);
            // 
            // rdoCon4
            // 
            this.rdoCon4.AutoSize = true;
            this.rdoCon4.Location = new System.Drawing.Point(199, 168);
            this.rdoCon4.Name = "rdoCon4";
            this.rdoCon4.Size = new System.Drawing.Size(125, 19);
            this.rdoCon4.TabIndex = 8;
            this.rdoCon4.TabStop = true;
            this.rdoCon4.Text = "Miles to kilometers";
            this.rdoCon4.UseVisualStyleBackColor = true;
            this.rdoCon4.CheckedChanged += new System.EventHandler(this.rdoCon4_CheckedChanged);
            // 
            // rdoCon2
            // 
            this.rdoCon2.AutoSize = true;
            this.rdoCon2.Location = new System.Drawing.Point(35, 168);
            this.rdoCon2.Name = "rdoCon2";
            this.rdoCon2.Size = new System.Drawing.Size(100, 19);
            this.rdoCon2.TabIndex = 7;
            this.rdoCon2.TabStop = true;
            this.rdoCon2.Text = "Feet to Meters";
            this.rdoCon2.UseVisualStyleBackColor = true;
            this.rdoCon2.CheckedChanged += new System.EventHandler(this.rdoCon2_CheckedChanged);
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(35, 251);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Input";
            this.txtInput.Size = new System.Drawing.Size(289, 29);
            this.txtInput.TabIndex = 12;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(567, 251);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.PlaceholderText = "Output";
            this.txtOutput.Size = new System.Drawing.Size(289, 29);
            this.txtOutput.TabIndex = 13;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(392, 253);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(101, 21);
            this.lblText.TabIndex = 14;
            this.lblText.Text = "Converts to:";
            // 
            // txtUnit1
            // 
            this.txtUnit1.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnit1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUnit1.Location = new System.Drawing.Point(99, 223);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.ReadOnly = true;
            this.txtUnit1.Size = new System.Drawing.Size(160, 22);
            this.txtUnit1.TabIndex = 15;
            this.txtUnit1.Text = "Unit 1";
            this.txtUnit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnit2
            // 
            this.txtUnit2.BackColor = System.Drawing.SystemColors.Control;
            this.txtUnit2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUnit2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUnit2.Location = new System.Drawing.Point(632, 223);
            this.txtUnit2.Name = "txtUnit2";
            this.txtUnit2.ReadOnly = true;
            this.txtUnit2.Size = new System.Drawing.Size(160, 22);
            this.txtUnit2.TabIndex = 16;
            this.txtUnit2.Text = "Unit 2";
            this.txtUnit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(724, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 35);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear\r\n\r\n\r\n\r\n\r\n\r\n\r\nend";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 299);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(481, 125);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 436);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtUnit2);
            this.Controls.Add(this.txtUnit1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.rdoCon10);
            this.Controls.Add(this.rdoCon8);
            this.Controls.Add(this.rdoCon6);
            this.Controls.Add(this.rdoCon4);
            this.Controls.Add(this.rdoCon2);
            this.Controls.Add(this.rdoCon9);
            this.Controls.Add(this.rdoCon7);
            this.Controls.Add(this.rdoCon5);
            this.Controls.Add(this.rdoCon3);
            this.Controls.Add(this.rdoCon1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnConvert;
        private RadioButton rdoCon1;
        private RadioButton rdoCon3;
        private RadioButton rdoCon5;
        private RadioButton rdoCon7;
        private RadioButton rdoCon9;
        private RadioButton rdoCon10;
        private RadioButton rdoCon8;
        private RadioButton rdoCon6;
        private RadioButton rdoCon4;
        private RadioButton rdoCon2;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Label lblText;
        private TextBox txtUnit1;
        private TextBox txtUnit2;
        private Button btnClear;
        private RichTextBox richTextBox1;
    }
}
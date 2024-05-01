namespace WinForms_Wordpad
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
            fontLabel = new Label();
            sizeLabel = new Label();
            fontStyleLabel = new Label();
            alignmentLabel = new Label();
            ColorLabel = new Label();
            FontBox = new ComboBox();
            SizeBox = new ComboBox();
            ColorBox = new ComboBox();
            Bold_btn = new Button();
            underline_btn = new Button();
            italic_btn = new Button();
            left_btn = new Button();
            center_btn = new Button();
            right_btn = new Button();
            load_btn = new Button();
            save_btn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // fontLabel
            // 
            fontLabel.AutoSize = true;
            fontLabel.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            fontLabel.Location = new Point(68, 9);
            fontLabel.Margin = new Padding(4, 0, 4, 0);
            fontLabel.Name = "fontLabel";
            fontLabel.Size = new Size(47, 24);
            fontLabel.TabIndex = 1;
            fontLabel.Text = "Font";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            sizeLabel.Location = new Point(202, 9);
            sizeLabel.Margin = new Padding(4, 0, 4, 0);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(46, 24);
            sizeLabel.TabIndex = 2;
            sizeLabel.Text = "Size";
            // 
            // fontStyleLabel
            // 
            fontStyleLabel.AutoSize = true;
            fontStyleLabel.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            fontStyleLabel.Location = new Point(303, 9);
            fontStyleLabel.Margin = new Padding(4, 0, 4, 0);
            fontStyleLabel.Name = "fontStyleLabel";
            fontStyleLabel.Size = new Size(91, 24);
            fontStyleLabel.TabIndex = 3;
            fontStyleLabel.Text = "FontStyle";
            // 
            // alignmentLabel
            // 
            alignmentLabel.AutoSize = true;
            alignmentLabel.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            alignmentLabel.Location = new Point(449, 9);
            alignmentLabel.Margin = new Padding(4, 0, 4, 0);
            alignmentLabel.Name = "alignmentLabel";
            alignmentLabel.Size = new Size(92, 24);
            alignmentLabel.TabIndex = 4;
            alignmentLabel.Text = "Alignment";
            // 
            // ColorLabel
            // 
            ColorLabel.AutoSize = true;
            ColorLabel.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ColorLabel.Location = new Point(631, 9);
            ColorLabel.Margin = new Padding(4, 0, 4, 0);
            ColorLabel.Name = "ColorLabel";
            ColorLabel.Size = new Size(53, 24);
            ColorLabel.TabIndex = 5;
            ColorLabel.Text = "Color";
            // 
            // FontBox
            // 
            FontBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FontBox.FormattingEnabled = true;
            FontBox.Location = new Point(13, 52);
            FontBox.Margin = new Padding(4, 3, 4, 3);
            FontBox.Name = "FontBox";
            FontBox.Size = new Size(150, 33);
            FontBox.TabIndex = 6;
            FontBox.SelectedIndexChanged += FontBox_SelectedIndexChanged;
            // 
            // SizeBox
            // 
            SizeBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            SizeBox.FormattingEnabled = true;
            SizeBox.Location = new Point(185, 52);
            SizeBox.Margin = new Padding(4, 3, 4, 3);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(80, 33);
            SizeBox.TabIndex = 7;
            SizeBox.SelectedIndexChanged += SizeBox_SelectedIndexChanged;
            // 
            // ColorBox
            // 
            ColorBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ColorBox.FormattingEnabled = true;
            ColorBox.Location = new Point(590, 50);
            ColorBox.Margin = new Padding(4, 3, 4, 3);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(136, 33);
            ColorBox.TabIndex = 8;
            ColorBox.SelectedIndexChanged += ColorBox_SelectedIndexChanged;
            // 
            // Bold_btn
            // 
            Bold_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Bold_btn.Location = new Point(291, 51);
            Bold_btn.Name = "Bold_btn";
            Bold_btn.Size = new Size(34, 31);
            Bold_btn.TabIndex = 9;
            Bold_btn.Text = "B";
            Bold_btn.UseVisualStyleBackColor = true;
            Bold_btn.Click += Bold_btn_Click;
            // 
            // underline_btn
            // 
            underline_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            underline_btn.Location = new Point(331, 52);
            underline_btn.Name = "underline_btn";
            underline_btn.Size = new Size(34, 31);
            underline_btn.TabIndex = 10;
            underline_btn.Text = "U";
            underline_btn.UseVisualStyleBackColor = true;
            underline_btn.Click += underline_btn_Click;
            // 
            // italic_btn
            // 
            italic_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            italic_btn.Location = new Point(371, 52);
            italic_btn.Name = "italic_btn";
            italic_btn.Size = new Size(34, 31);
            italic_btn.TabIndex = 11;
            italic_btn.Text = "I";
            italic_btn.UseVisualStyleBackColor = true;
            italic_btn.Click += italic_btn_Click;
            // 
            // left_btn
            // 
            left_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            left_btn.Location = new Point(438, 50);
            left_btn.Name = "left_btn";
            left_btn.Size = new Size(34, 32);
            left_btn.TabIndex = 12;
            left_btn.Text = "L";
            left_btn.UseVisualStyleBackColor = true;
            left_btn.Click += left_btn_Click;
            // 
            // center_btn
            // 
            center_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            center_btn.Location = new Point(478, 50);
            center_btn.Name = "center_btn";
            center_btn.Size = new Size(34, 32);
            center_btn.TabIndex = 13;
            center_btn.Text = "C";
            center_btn.UseVisualStyleBackColor = true;
            center_btn.Click += center_btn_Click;
            // 
            // right_btn
            // 
            right_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            right_btn.Location = new Point(518, 50);
            right_btn.Name = "right_btn";
            right_btn.Size = new Size(34, 32);
            right_btn.TabIndex = 14;
            right_btn.Text = "R";
            right_btn.UseVisualStyleBackColor = true;
            right_btn.Click += right_btn_Click;
            // 
            // load_btn
            // 
            load_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            load_btn.Location = new Point(805, 12);
            load_btn.Name = "load_btn";
            load_btn.Size = new Size(94, 29);
            load_btn.TabIndex = 15;
            load_btn.Text = "Load";
            load_btn.UseVisualStyleBackColor = true;
            load_btn.Click += load_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            save_btn.Location = new Point(805, 54);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(94, 29);
            save_btn.TabIndex = 16;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(2, 111);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(914, 454);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 568);
            Controls.Add(richTextBox1);
            Controls.Add(save_btn);
            Controls.Add(load_btn);
            Controls.Add(right_btn);
            Controls.Add(center_btn);
            Controls.Add(left_btn);
            Controls.Add(italic_btn);
            Controls.Add(underline_btn);
            Controls.Add(Bold_btn);
            Controls.Add(ColorBox);
            Controls.Add(SizeBox);
            Controls.Add(FontBox);
            Controls.Add(ColorLabel);
            Controls.Add(alignmentLabel);
            Controls.Add(fontStyleLabel);
            Controls.Add(sizeLabel);
            Controls.Add(fontLabel);
            Font = new Font("MV Boli", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label fontLabel;
        private Label sizeLabel;
        private Label fontStyleLabel;
        private Label alignmentLabel;
        private Label ColorLabel;
        private ComboBox FontBox;
        private ComboBox SizeBox;
        private ComboBox ColorBox;
        private Button Bold_btn;
        private Button underline_btn;
        private Button italic_btn;
        private Button left_btn;
        private Button center_btn;
        private Button right_btn;
        private Button load_btn;
        private Button save_btn;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private RichTextBox richTextBox1;
    }
}

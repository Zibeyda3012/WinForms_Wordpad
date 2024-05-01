using System.Drawing;
using System.Security.Cryptography;

namespace WinForms_Wordpad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text Files|*.txt";

            foreach (var item in FontFamily.Families)
                FontBox.Items.Add(item.Name);

            SizeBox.Items.Add(8);
            SizeBox.Items.Add(9);
            SizeBox.Items.Add(10);
            SizeBox.Items.Add(11);
            SizeBox.Items.Add(12);

            int num = 12;

            while (num <= 70)
            {
                num += 2;
                SizeBox.Items.Add(num);
            }

            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            foreach (var item in colors)
            {
                Color color = Color.FromKnownColor(item);
                ColorBox.Items.Add(color);
            }

        }

        private void FontBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(FontBox.SelectedItem.ToString()!, richTextBox1.Font.Size);
        }

        private void SizeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = (int)SizeBox.SelectedItem;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size);
        }

        private void ColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.ForeColor =(Color)ColorBox.SelectedItem;
        }

        private void Bold_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold == true)
            {
                FontStyle newStyle = FontStyle.Regular;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, newStyle);
            }
            else
            {
                FontStyle newStyle = FontStyle.Bold;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, newStyle);
            }
        }

        private void underline_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline == true)
            {
                FontStyle newStyle = FontStyle.Regular;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, newStyle);
            }
            else
            {
                FontStyle newStyle = FontStyle.Underline;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, newStyle);
            }
        }

        private void italic_btn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic == true)
            {
                FontStyle newStyle = FontStyle.Regular;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, newStyle);
            }
            else
            {
                FontStyle newStyle = FontStyle.Italic;
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, newStyle);
            }
        }

        private void left_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void center_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void right_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                string text = File.ReadAllText(fileName);
                richTextBox1.Text = text;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveFileDialog1.FileName;
                File.WriteAllText(fileName, richTextBox1.Text);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boldbtn_CheckedChanged(object sender, EventArgs e)
        {
            Font font = richTextBox1.SelectionFont;
            font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold);
            richTextBox1.SelectionFont = font;
        }

        private void Fontbtn_CheckedChanged(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog()== DialogResult.OK)

            {
                richTextBox1.SelectionFont = font.Font;
            }
        }

        private void Color_CheckedChanged(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void Cutbtn_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Pastebtn_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void Copybtn_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Newbtn_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            
        }

        private void Openbtn_CheckedChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich text Box|*.rtf";
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Rtf = File.ReadAllText(openFile.FileName);
            }
        }

        private void Savebtn_CheckedChanged(object sender, EventArgs e)
        {
            SaveFileDialog save= new SaveFileDialog();
            save.Filter = "*.rtf|Rich text Box";
            save.DefaultExt = "rtf";
            if(save.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Exitbtn_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Are you want to Exit file");
            Application.Exit();
        }
    }
}
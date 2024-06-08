using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Application_Project
{
    public partial class Memo : Form
    {
        public Memo()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void font_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = this.fontDialog1.Font;
        }

        private void colortext_Click(object sender, EventArgs e)
        {
            this.colorDialog.ShowDialog();
            this.richTextBox1.SelectionColor = this.colorDialog.Color;
        }

        private void BackColor_Click(object sender, EventArgs e)
        {
            this.colorDialog.ShowDialog();
            this.richTextBox1.SelectionBackColor = this.colorDialog.Color;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void CenterAligment_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void JustificatedAligment_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Decrase_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = richTextBox1.SelectionIndent;
            i = i - 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void Increase_Click(object sender, EventArgs e)
        {
            Int32 i;
            i = richTextBox1.SelectionIndent;
            i = i + 10;
            this.richTextBox1.SelectionIndent = i;
        }

        private void GoToPaint_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o Paint: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void NewMemo_Click(object sender, EventArgs e)
        {
            var dialogResult =  MessageBox.Show("Do you want to save this memo information ", "Information",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                this.Refresh();
                this.richTextBox1.Clear();
            }
        }
    }
}

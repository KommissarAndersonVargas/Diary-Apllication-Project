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
        string pathFile = string.Empty;
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

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SalvarConteudo();
        }
        private void SalvarConteudo()
        {
            try
            {
                // Escolha o local e o nome do arquivo usando o SaveFileDialog
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Arquivos RTF (*.rtf)|*.rtf|Todos os arquivos (*.*)|*.*";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Salve o conteúdo do RichTextBox no arquivo RTF
                        pathFile = saveFileDialog.FileName;
                        richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                        MessageBox.Show(" Information saved", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error ocurred", "Information",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void justSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (pathFile != string.Empty)
                {
                    richTextBox1.SaveFile(pathFile, RichTextBoxStreamType.RichText);
                    MessageBox.Show(" Information saved", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SalvarConteudo();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("An error ocurred", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Open_Folder_Click(object sender, EventArgs e)
        {
            LoadRTFFile();
        }
        private void LoadRTFFile()
        {
            try
            {
                // Cria uma nova instância de OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Define o filtro para arquivos RTF
                openFileDialog.Filter = "Arquivos RTF|*.rtf";

                // Exibe a caixa de diálogo OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Carrega o conteúdo do arquivo selecionado no RichTextBox
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show("An error ocurred", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show(this, "Desea terminar la aplicación?", "Mi aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
            {
                
            
                e.Cancel = true;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
        

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nArchivo == "")
            {
               // MessageBox.Show("Guardar como");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    nArchivo = saveFileDialog1.FileName;
                }
            }
           else
            {

                //MessageBox.Show("Guardar");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    nArchivo = saveFileDialog1.FileName;
                }
            }
        }
        bool TextoCambiado = false;
        bool cambio = true;
        string nArchivo = " ";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (cambio)
            {
                TextoCambiado = true;
            }
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (nArchivo == "")
            {
                MessageBox.Show("Guardar como:");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    nArchivo = saveFileDialog1.FileName;
                }
            }
            else
            {
                MessageBox.Show("Guardar");
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    nArchivo = saveFileDialog1.FileName;
                }
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!TextoCambiado)
            {
                richTextBox1.Clear();
                nArchivo = "";
            }
            else
            {
                DialogResult dialog = MessageBox.Show(this, "Tiene texto Modificado/n ¿Desea Guardarlo en el archivo actual?", "Mi aplicacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (nArchivo == "")
                    {
                        MessageBox.Show("guardar como");
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            nArchivo = saveFileDialog1.FileName;
                        }
                    }
                    /*else
                    {
                        MessageBox.Show("guardar");
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                            nArchivo = saveFileDialog1.FileName;
                        }
                    }*/
                }
                if (dialog == DialogResult.No)
                {
                    MessageBox.Show("guardar como");
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                        nArchivo = saveFileDialog1.FileName;
                    }
                }
                if (dialog == DialogResult.Cancel)
                {
                    new CancelEventArgs().Cancel = true;
                }
            }

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                nArchivo = saveFileDialog1.FileName;
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = nArchivo;
        }
    }
}

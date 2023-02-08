using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bloco_de_notas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SalvarClique(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void SalvarAqui(object sender, CancelEventArgs e)
        {
            string caminho = saveFileDialog1.FileName;
            File.WriteAllText(caminho, escrita.Text);
            MessageBox.Show("Arquivo salvo.");
            
        }

        private void Sair(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Abrir(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Text = openFileDialog1.FileName;
                using (StreamReader reader = new StreamReader(openFileDialog1.OpenFile()));
                
            }
        }
    }
}

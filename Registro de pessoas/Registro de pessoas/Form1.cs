using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_de_pessoas
{
    public partial class Form1 : Form
    {
        List<String> Nomes;

        public Form1()
        {
            InitializeComponent();
            Nomes = new List<String>();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            Nomes.Add(nome);
            exibeCadastros();
        }
        private void exibeCadastros()
        {
            String cadastros = "";
            foreach (String temp in Nomes)
            {
                cadastros += temp + Environment.NewLine;
            }
            txtCadastro.Text = cadastros;
        }
    }
}

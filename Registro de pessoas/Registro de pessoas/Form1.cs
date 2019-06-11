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
        List<Pessoa> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Pessoa>();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "") return;
            {
                Pessoa p = new Pessoa();
                p.Nome = txtNome.Text;
                p.Idade = Convert.ToInt32(nudIdade.Value);
                p.Telefone = Convert.ToInt64(mskTelefone.Text);
                if (rdoFeminino.Checked)
                    p.Sexo = "Feminino";
                else
                    p.Sexo = "Masculino";

                lista.Add(p);
                ExibeRegistros();

                /*
                String nome = txtNome.Text;
                Nomes.Add(nome);
                exibeCadastros();
                */
            }
        }

        private void ExibeRegistros()
        {
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista;
        }
        /*
        private void exibeCadastros()
        {
            String cadastros = "";
            foreach (Pessoa temp in lista)
            {
                cadastros += temp.Nome + " - " + temp.Idade + Environment.NewLine;
            }
            txtCadastro.Text = cadastros;
        }
        */
    }
}

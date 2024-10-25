using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Controllers;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.Views
{
    public partial class SenhorioForm : Form
    {
        private SenhorioController senhorioController = new SenhorioController();

        public SenhorioForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Senhorio senhorio = new Senhorio
            {
                Nome = txtNome.Text,
                NIF = txtNIF.Text,
                Telefone = txtTelefone.Text
            };

            senhorioController.AdicionarSenhorio(senhorio);
            MessageBox.Show("Senhorio adicionado com sucesso!");
            this.Close();
        }
    }
}

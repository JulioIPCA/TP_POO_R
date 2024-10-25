using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Controllers;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.Views
{
    public partial class InquilinoForm : Form
    {
        private InquilinoController inquilinoController = new InquilinoController();

        public InquilinoForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Inquilino inquilino = new Inquilino
            {
                Nome = txtNome.Text,
                NIF = txtNIF.Text,
                Telefone = txtTelefone.Text
            };

            inquilinoController.AdicionarInquilino(inquilino);
            MessageBox.Show("Inquilino adicionado com sucesso!");
            this.Close();
        }
    }
}

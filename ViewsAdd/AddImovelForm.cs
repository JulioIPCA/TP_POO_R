using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using TP_POO_R.Models;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddImovelForm : MaterialForm
    {
        // Propriedade para armazenar o novo imóvel, pode ser nula
        public Imovel? NovoImovel { get; private set; }

        public AddImovelForm()
        {
            InitializeComponent();
        }

        // Evento disparado ao clicar no botão de salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Cria uma nova instância de Imovel com os dados do formulário
                NovoImovel = new Imovel(txtTipo.Text, txtEndereco.Text, decimal.Parse(txtNQuartos.Text));

                DialogResult = DialogResult.OK;
                Close(); // Fecha o formulário
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento disparado ao clicar no botão de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close(); // Fecha o formulário
        }

        // Valida os campos do formulário
        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtTipo.Text) &&
                   !string.IsNullOrWhiteSpace(txtEndereco.Text) &&
                   decimal.TryParse(txtNQuartos.Text, out _);
        }
    }
}


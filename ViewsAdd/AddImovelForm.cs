using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using TP_POO_R.Models; // Atualize o namespace para o correto

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddImovelForm : MaterialForm
    {
        public Imovel? NovoImovel { get; private set; }
        private static int _nextIdImovel = 1; // Variável estática para gerar IDs sequenciais

        public AddImovelForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                NovoImovel = new Imovel
                {
                    IdImovel = GerarNovoIdImovel(), // Método para gerar um novo IdImovel
                    Tipo = txtTipo.Text,
                    Endereco = txtEndereco.Text,
                    NQuartos = decimal.Parse(txtNQuartos.Text)
                };

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtTipo.Text) &&
                   !string.IsNullOrWhiteSpace(txtEndereco.Text) &&
                   decimal.TryParse(txtNQuartos.Text, out _);
        }

        private int GerarNovoIdImovel()
        {
            return _nextIdImovel++; // Incrementa o ID para o próximo imóvel
        }
    }
}

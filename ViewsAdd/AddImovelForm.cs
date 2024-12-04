using System;
using System.Windows.Forms;
using GestaoRendasImoveis.Models;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddImovelForm : Form
    {
        public Imovel? NovoImovel { get; private set; }

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
                    ProprietarioId = int.Parse(txtProprietarioId.Text),
                    Tipo = txtTipo.Text,
                    Endereco = txtEndereco.Text,
                    Valor = decimal.Parse(txtValor.Text),
                    RendaMensal = decimal.Parse(txtRendaMensal.Text)
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
            return !string.IsNullOrWhiteSpace(txtProprietarioId.Text) &&
                   !string.IsNullOrWhiteSpace(txtTipo.Text) &&
                   !string.IsNullOrWhiteSpace(txtEndereco.Text) &&
                   decimal.TryParse(txtValor.Text, out _) &&
                   decimal.TryParse(txtRendaMensal.Text, out _);
        }

        private int GerarNovoIdImovel()
        {
            // Implementar lógica para gerar um novo IdImovel único
            // Por exemplo, você pode buscar o maior IdImovel existente e incrementar
            // Aqui, apenas retornamos um valor fixo para simplificação
            return new Random().Next(1, 10000); // Exemplo de geração de ID
        }
    }
}


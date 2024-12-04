using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TP_POO_R.Models;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddDespesa : MaterialForm
    {
        public Despesa? NovaDespesa { get; private set; } // Tornar anulável

        public AddDespesa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar uma nova instância de Despesa com os dados do formulário
                NovaDespesa = new Despesa
                {
                    IdInquilino = int.Parse(txtIdInquilino.Text),
                    IdImovel = int.Parse(txtIdImovel.Text),
                    Data = dtpData.Value,
                    Descricao = txtDescricao.Text,
                    ValorLuz = decimal.Parse(txtValorLuz.Text),
                    ValorGas = decimal.Parse(txtValorGas.Text),
                    ValorAgua = decimal.Parse(txtValorAgua.Text)
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos nos campos numéricos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


using MaterialSkin.Controls;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddContratoForm : MaterialForm
    {
        private readonly ContratoController _controller;

        public AddContratoForm()
        {
            InitializeComponent();
            _controller = new ContratoController(); // Use the default constructor
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar um objeto contrato com os dados do formulário
                var contrato = new Contrato
                {
                    IdImovel = txtIdImovel.Text,
                    Data = dtpData.Value,
                    Nome = txtNome.Text,
                    Valor = txtValor.Text,
                    DataCessacao = dtpDataCessacao.Value
                };

                // Adicionar o novo contrato
                _controller.AddContrato(contrato);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

using MaterialSkin.Controls;
using TP_POO_R.Controllers;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddContratoForm : MaterialForm
    {
        // Propriedade para armazenar o novo contrato, pode ser nula
        public Contrato? NovoContrato { get; private set; }
        private readonly InquilinoController _inquilinoController;
        private readonly ContratoController _contratoController;

        // Construtor que aceita um InquilinoController e um ContratoController como argumentos
        public AddContratoForm(InquilinoController inquilinoController, ContratoController contratoController)
        {
            InitializeComponent();
            _inquilinoController = inquilinoController;
            _contratoController = contratoController;
            LoadInquilinos(); // Carrega a lista de inquilinos
        }

        // Carrega a lista de inquilinos no ComboBox
        private void LoadInquilinos()
        {
            var inquilinos = _inquilinoController.GetInquilinos()
                .Select(i => new { i.Id, i.Nome })
                .ToList();

            if (inquilinos.Count == 0)
            {
                MessageBox.Show("Nenhum inquilino encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbInquilinos.DataSource = inquilinos;
            cmbInquilinos.DisplayMember = "Nome";
            cmbInquilinos.ValueMember = "Id";
        }

        // Evento disparado ao clicar no botão de salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbInquilinos.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um inquilino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var idInquilino = cmbInquilinos.SelectedValue?.ToString() ?? string.Empty;

                // Verifica se o inquilino já possui um contrato
                if (_contratoController.InquilinoJaPossuiContrato(idInquilino, _contratoController.GetContratos()))
                {
                    MessageBox.Show("O inquilino selecionado já possui um contrato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cria uma nova instância de Contrato com os dados do formulário
                NovoContrato = new Contrato
                {
                    IdInquilino = idInquilino,
                    Data = dtpDataInicio.Value,
                    DataCessacao = dtpDataFim.Value,
                    Valor = txtValor.Text
                };

                // Valida o contrato
                if (!NovoContrato.Validar())
                {
                    MessageBox.Show("Dados do contrato inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close(); // Fecha o formulário
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos nos campos numéricos.", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento disparado ao clicar no botão de cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Fecha o formulário
        }
    }
}


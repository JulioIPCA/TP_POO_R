using MaterialSkin.Controls;
using TP_POO_R.Models;
using TP_POO_R.Controllers;
using System.Linq;
using System.Windows.Forms;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddContratoForm : MaterialForm
    {
        public Contrato? NovoContrato { get; private set; } // Tornar anulável
        private readonly InquilinoController _inquilinoController;

        // Construtor que aceita um InquilinoController como argumento
        public AddContratoForm(InquilinoController inquilinoController)
        {
            InitializeComponent();
            _inquilinoController = inquilinoController;
            LoadInquilinos();
        }

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbInquilinos.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um inquilino.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Criar uma nova instância de Contrato com os dados do formulário
                NovoContrato = new Contrato
                {
                    IdInquilino = cmbInquilinos.SelectedValue.ToString(),
                    Data = dtpDataInicio.Value,
                    DataCessacao = dtpDataFim.Value,
                    Nome = txtNome.Text,
                    Valor = txtValor.Text
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

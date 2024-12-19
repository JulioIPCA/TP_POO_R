using MaterialSkin.Controls;
using TP_POO_R.Models;
using TP_POO_R.Controllers;
using System.Linq;
using System.Windows.Forms;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddDespesa : MaterialForm
    {
        public Despesa? NovaDespesa { get; private set; } // Tornar anulável
        private InquilinoController _inquilinoController;

        public AddDespesa()
        {
            InitializeComponent();
            _inquilinoController = new InquilinoController();
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
            cmbInquilinos.DisplayMember = "Id";
            cmbInquilinos.ValueMember = "Id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar uma nova instância de Despesa com os dados do formulário
                NovaDespesa = new Despesa
                {
                    IdInquilino = (int)cmbInquilinos.SelectedValue,
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

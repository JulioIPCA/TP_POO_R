using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddDespesaForm : MaterialForm
    {
        // Propriedade para armazenar a nova despesa, pode ser nula
        public Despesa? NovaDespesa { get; private set; }
        private readonly InquilinoController _inquilinoController;

        // Construtor que aceita um InquilinoController como argumento
        public AddDespesaForm(InquilinoController inquilinoController)
        {
            InitializeComponent();
            _inquilinoController = inquilinoController;
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

                var idInquilino = (int)cmbInquilinos.SelectedValue;

                // Cria uma nova instância de Despesa com os dados do formulário
                NovaDespesa = Despesa.CriarDespesa(
                    idInquilino,
                    dtpData.Value,
                    txtDescricao.Text,
                    decimal.Parse(txtValorLuz.Text),
                    decimal.Parse(txtValorGas.Text),
                    decimal.Parse(txtValorAgua.Text)
                );

                // Valida a despesa
                if (!NovaDespesa.Validar())
                {
                    MessageBox.Show("Dados da despesa inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


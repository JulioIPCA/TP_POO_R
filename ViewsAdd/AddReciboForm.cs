using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.Models;
using System;
using System.Windows.Forms;

namespace TP_POO_R.ViewsAdicionar
{
    public partial class AddReciboForm : MaterialForm
    {
        private readonly ReciboController _reciboController;
        private readonly ContratoController _contratoController;

        // Construtor que aceita um DataGridView como argumento
        public AddReciboForm(DataGridView dataGridView)
        {
            InitializeComponent();
            _reciboController = new ReciboController(dataGridView);
            _contratoController = new ContratoController(dataGridView);
        }

        // Evento disparado ao carregar o formulário
        private void AddReciboForm_Load(object sender, EventArgs e)
        {
            CarregarContratos(); // Carrega a lista de contratos
        }

        // Carrega a lista de contratos no ComboBox
        private void CarregarContratos()
        {
            var contratos = _contratoController.GetContratos();
            comboBoxContratos.DataSource = contratos;
            comboBoxContratos.DisplayMember = "Descricao"; // Supondo que Contrato tem uma propriedade Descricao
            comboBoxContratos.ValueMember = "IdContrato";
        }

        // Evento disparado ao clicar no botão de salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um objeto recibo com os dados do formulário
                var recibo = new Recibo
                {
                    Data = dateTimePickerData.Value,
                    IdContrato = comboBoxContratos.SelectedValue != null ? (int)comboBoxContratos.SelectedValue : 0,
                    Valor = 0 // Supondo que Valor será definido no método AdicionarRecibo
                };

                // Adiciona o novo recibo
                _reciboController.AdicionarRecibo(recibo);

                this.DialogResult = DialogResult.OK;
                this.Close(); // Fecha o formulário
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.ViewsAdicionar;
using TP_POO_R.Models;
using System;
using System.Windows.Forms;

namespace TP_POO_R.Views
{
    public partial class ReciboForm : MaterialForm
    {
        // Controlador de recibos
        private readonly ReciboController _reciboController;

        public ReciboForm()
        {
            InitializeComponent();
            // Inicializa o controlador de recibos com o DataGridView
            _reciboController = new ReciboController(dataGridView);
        }

        // Evento disparado ao carregar o formulário
        private void ReciboForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Carrega os dados dos recibos no DataGridView
        private void LoadData()
        {
            var recibos = _reciboController.GetRecibos();
            dataGridView.DataSource = null; // Limpa os dados existentes
            dataGridView.DataSource = recibos;

            // Configura as colunas do DataGridView
            dataGridView.Columns["IdRecibo"].DisplayIndex = 0;
            dataGridView.Columns["IdRecibo"].HeaderText = "Id Recibo";

            dataGridView.Columns["IdContrato"].DisplayIndex = 1;
            dataGridView.Columns["IdContrato"].HeaderText = "Id Contrato";

            dataGridView.Columns["Data"].DisplayIndex = 2;
            dataGridView.Columns["Valor"].DisplayIndex = 3; // Adiciona a coluna Valor
        }

        // Evento disparado ao clicar no botão de adicionar recibo
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var addReciboForm = new AddReciboForm(dataGridView))
            {
                if (addReciboForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        // Evento disparado ao clicar no botão de remover recibo
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var recibo = (Recibo)selectedRow.DataBoundItem;

                // Remove o recibo selecionado
                _reciboController.RemoverRecibo(recibo.IdRecibo);
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um recibo para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

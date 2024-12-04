
using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.Models;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class ReciboForm : MaterialForm
    {
        private readonly ReciboController _reciboController;

        public ReciboForm()
        {
            InitializeComponent();
            _reciboController = new ReciboController();
        }

        private void ReciboForm_Load(object sender, EventArgs e)
        {
            // Configurar colunas da DataGridView
            ConfigureDataGridView();

            // Carregar dados na DataGridView
            LoadData();
        }

        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;

            // Adicionar colunas ao DataGridView
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdRecibo", HeaderText = "ID Recibo" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ImovelId", HeaderText = "Imóvel ID" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "InquilinoId", HeaderText = "Inquilino ID" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" });
        }

        private void LoadData()
        {
            try
            {
                var recibos = _reciboController.GetRecibos();
                dataGridView.DataSource = recibos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView.DataSource = new List<Recibo>();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddReciboForm addReciboForm = new AddReciboForm();
            if (addReciboForm.ShowDialog() == DialogResult.OK)
            {
                // Adicionar o novo recibo
                var novoRecibo = addReciboForm.NovoRecibo;

                if (novoRecibo != null)
                {
                    _reciboController.AdicionarRecibo(novoRecibo);

                    // Recarregar dados após adicionar um novo recibo
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Erro ao obter o novo recibo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obter o índice da linha selecionada
                var selectedIndex = dataGridView.SelectedRows[0].Index;

                // Obter o recibo selecionado
                var reciboToRemove = dataGridView.SelectedRows[0].DataBoundItem as Recibo;

                if (reciboToRemove != null)
                {
                    // Remover o recibo selecionado
                    _reciboController.RemoverRecibo(reciboToRemove.IdRecibo);

                    // Recarregar dados após remover o recibo
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Erro ao obter o recibo selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione um recibo para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

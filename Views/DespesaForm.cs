using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.ViewsAdicionar;
using TP_POO_R.Models;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TP_POO_R.Views
{
    public partial class DespesaForm : MaterialForm
    {
        private DespesaController _controller;
        private InquilinoController _inquilinoController;

        public DespesaForm()
        {
            InitializeComponent();
            _controller = new DespesaController();
            _inquilinoController = new InquilinoController();
        }

        // Evento disparado quando o formulário é carregado
        private void DespesaForm_Load(object sender, EventArgs e)
        {
            // Configurar colunas da DataGridView
            ConfigureDataGridView();

            // Carregar dados na DataGridView
            LoadData();
        }

        // Configura as colunas da DataGridView
        private void ConfigureDataGridView()
        {
            dataGridView.AutoGenerateColumns = false;

            // Adicionar colunas ao DataGridView
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdInquilino", HeaderText = "ID Inquilino" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NomeInquilino", HeaderText = "Nome Inquilino" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorLuz", HeaderText = "Valor Luz" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorGas", HeaderText = "Valor Gás" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorAgua", HeaderText = "Valor Água" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total" });
        }

        // Carrega os dados na DataGridView
        private void LoadData()
        {
            var despesas = _controller.LoadDespesas();
            var inquilinos = _inquilinoController.GetInquilinos();

            var despesasComInquilinos = from despesa in despesas
                                        join inquilino in inquilinos on despesa.IdInquilino equals inquilino.Id
                                        select new
                                        {
                                            despesa.IdInquilino,
                                            NomeInquilino = inquilino.Nome,
                                            despesa.Data,
                                            despesa.Descricao,
                                            despesa.ValorLuz,
                                            despesa.ValorGas,
                                            despesa.ValorAgua,
                                            despesa.ValorTotal
                                        };

            dataGridView.DataSource = despesasComInquilinos.ToList();
        }

        // Evento disparado ao clicar no botão de adicionar despesa
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var addDespesaForm = new AddDespesaForm(_inquilinoController))
            {
                if (addDespesaForm.ShowDialog() == DialogResult.OK)
                {
                    // Adicionar a nova despesa
                    if (addDespesaForm.NovaDespesa != null)
                    {
                        _controller.AddDespesa(addDespesaForm.NovaDespesa);

                        // Recarregar dados após adicionar uma nova despesa
                        LoadData();
                    }
                }
            }
        }

        // Evento disparado ao clicar no botão de remover despesa
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obter o índice da linha selecionada
                var selectedIndex = dataGridView.SelectedRows[0].Index;

                // Remover a despesa selecionada
                _controller.RemoveDespesa(selectedIndex);

                // Recarregar dados após remover a despesa
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione uma despesa para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TP_POO_R.Controllers;
using TP_POO_R.Models;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class DespesaForm : MaterialForm
    {
        private DespesaController _controller;

        public DespesaForm()
        {
            InitializeComponent();
            _controller = new DespesaController();
        }

        private void DespesaForm_Load(object sender, EventArgs e)
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
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdInquilino", HeaderText = "ID Inquilino" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdImovel", HeaderText = "ID Imóvel" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorLuz", HeaderText = "Valor Luz" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorGas", HeaderText = "Valor Gás" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorAgua", HeaderText = "Valor Água" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor Total" });
        }

        private void LoadData()
        {
            var despesas = _controller.LoadDespesas();
            dataGridView.DataSource = despesas;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var addDespesaForm = new AddDespesa())
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

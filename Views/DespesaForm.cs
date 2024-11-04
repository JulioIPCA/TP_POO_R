using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class DespesaForm : MaterialForm
    {
        private List<Despesa> _despesas; // Variável de instância para armazenar despesas

        public DespesaForm()
        {
            InitializeComponent();
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
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "despesas.json");
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        _despesas = JsonSerializer.Deserialize<List<Despesa>>(json); // Carregar dados na variável de instância
                        if (_despesas != null)
                        {
                            // Adicionar coluna calculada para Valor Total
                            var despesasComValorTotal = _despesas.Select(d => new
                            {
                                d.IdInquilino,
                                d.IdImovel,
                                d.Data,
                                d.Descricao,
                                d.ValorLuz,
                                d.ValorGas,
                                d.ValorAgua,
                                ValorTotal = d.ValorLuz + d.ValorGas + d.ValorAgua
                            }).ToList();

                            dataGridView.DataSource = despesasComValorTotal;
                        }
                        else
                        {
                            dataGridView.DataSource = new List<Despesa>();
                        }
                    }
                    else
                    {
                        dataGridView.DataSource = new List<Despesa>();
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView.DataSource = new List<Despesa>();
                }
            }
            else
            {
                dataGridView.DataSource = new List<Despesa>();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddDespesa addDespesaForm = new AddDespesa();
            if (addDespesaForm.ShowDialog() == DialogResult.OK)
            {
                // Adicionar a nova despesa à lista
                var novaDespesa = addDespesaForm.NovaDespesa;
                _despesas.Add(novaDespesa);

                // Salvar a lista atualizada de despesas
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "despesas.json");
                var json = JsonSerializer.Serialize(_despesas, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                // Recarregar dados após adicionar uma nova despesa
                LoadData();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obter o índice da linha selecionada
                var selectedIndex = dataGridView.SelectedRows[0].Index;

                // Remover a despesa selecionada da lista original
                var despesaToRemove = _despesas[selectedIndex];
                _despesas.Remove(despesaToRemove);

                // Salvar a lista atualizada de despesas
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "despesas.json");
                var json = JsonSerializer.Serialize(_despesas, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                // Recarregar dados após remover a despesa
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione uma despesa para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class Despesa
    {
        public string IdInquilino { get; set; } = string.Empty;
        public string IdImovel { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal ValorLuz { get; set; }
        public decimal ValorGas { get; set; }
        public decimal ValorAgua { get; set; }
    }
}

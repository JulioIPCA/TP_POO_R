using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using GestaoRendasImoveis.Models;
using MaterialSkin.Controls;
//using TP_POO_R.Models; // Certifique-se de que este namespace está correto
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class ReciboForm : MaterialForm
    {
        private List<Recibo> _recibos; // Variável de instância para armazenar recibos

        public ReciboForm()
        {
            InitializeComponent();
            _recibos = new List<Recibo>(); // Inicializar a lista de recibos
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
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recibos.json");
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        _recibos = JsonSerializer.Deserialize<List<Recibo>>(json) ?? new List<Recibo>(); // Carregar dados na variável de instância
                        dataGridView.DataSource = _recibos;
                    }
                    else
                    {
                        dataGridView.DataSource = new List<Recibo>();
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView.DataSource = new List<Recibo>();
                }
            }
            else
            {
                dataGridView.DataSource = new List<Recibo>();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddReciboForm addReciboForm = new AddReciboForm();
            if (addReciboForm.ShowDialog() == DialogResult.OK)
            {
                // Adicionar o novo recibo à lista
                var novoRecibo = addReciboForm.NovoRecibo;
                _recibos.Add(novoRecibo);

                // Salvar a lista atualizada de recibos
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recibos.json");
                var json = JsonSerializer.Serialize(_recibos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                // Recarregar dados após adicionar um novo recibo
                LoadData();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obter o índice da linha selecionada
                var selectedIndex = dataGridView.SelectedRows[0].Index;

                // Remover o recibo selecionado da lista original
                var reciboToRemove = _recibos[selectedIndex];
                _recibos.Remove(reciboToRemove);

                // Salvar a lista atualizada de recibos
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recibos.json");
                var json = JsonSerializer.Serialize(_recibos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                // Recarregar dados após remover o recibo
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um recibo para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


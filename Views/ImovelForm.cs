using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using GestaoRendasImoveis.Models;
using MaterialSkin.Controls;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class ImovelForm : MaterialForm
    {
        private List<Imovel> _imoveis; // Variável de instância para armazenar imóveis

        public ImovelForm()
        {
            InitializeComponent();
            _imoveis = new List<Imovel>(); // Inicializar a lista de imóveis
        }

        private void ImovelForm_Load(object sender, EventArgs e)
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
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdImovel", HeaderText = "ID Imóvel" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProprietarioId", HeaderText = "Proprietário ID" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tipo", HeaderText = "Tipo" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereço" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Valor", HeaderText = "Valor" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "RendaMensal", HeaderText = "Renda Mensal" });
        }

        private void LoadData()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imoveis.json");
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        _imoveis = JsonSerializer.Deserialize<List<Imovel>>(json) ?? new List<Imovel>(); // Carregar dados na variável de instância
                        dataGridView.DataSource = _imoveis;
                    }
                    else
                    {
                        dataGridView.DataSource = new List<Imovel>();
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView.DataSource = new List<Imovel>();
                }
            }
            else
            {
                dataGridView.DataSource = new List<Imovel>();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddImovelForm addImovelForm = new AddImovelForm();
            if (addImovelForm.ShowDialog() == DialogResult.OK)
            {
                // Adicionar o novo imóvel à lista
                var novoImovel = addImovelForm.NovoImovel;
                _imoveis.Add(novoImovel);

                // Salvar a lista atualizada de imóveis
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imoveis.json");
                var json = JsonSerializer.Serialize(_imoveis, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                // Recarregar dados após adicionar um novo imóvel
                LoadData();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obter o índice da linha selecionada
                var selectedIndex = dataGridView.SelectedRows[0].Index;

                // Remover o imóvel selecionado da lista original
                var imovelToRemove = _imoveis[selectedIndex];
                _imoveis.Remove(imovelToRemove);

                // Salvar a lista atualizada de imóveis
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imoveis.json");
                var json = JsonSerializer.Serialize(_imoveis, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);

                // Recarregar dados após remover o imóvel
                LoadData();
            }
            else
            {
                MessageBox.Show("Selecione um imóvel para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

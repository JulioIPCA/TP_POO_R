using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using MaterialSkin.Controls;
using TP_POO_R.ViewsAdicionar;

namespace TP_POO_R.Views
{
    public partial class ContratoForm : MaterialForm
    {
        public ContratoForm()
        {
            InitializeComponent();
        }

        private void ContratoForm_Load(object sender, EventArgs e)
        {
            // Carregar dados na DataGridView
            LoadData();
        }

        private void LoadData()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contratos.json");
            if (File.Exists(filePath))
            {
                try
                {
                    var json = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        var contratos = JsonSerializer.Deserialize<List<Contrato>>(json);
                        dataGridView.DataSource = contratos ?? new List<Contrato>();
                    }
                    else
                    {
                        dataGridView.DataSource = new List<Contrato>();
                    }
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView.DataSource = new List<Contrato>();
                }
            }
            else
            {
                dataGridView.DataSource = new List<Contrato>();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AddContratoForm addContratoForm = new AddContratoForm();
            if (addContratoForm.ShowDialog() == DialogResult.OK)
            {
                // Recarregar dados após adicionar um novo contrato
                LoadData();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Obter o contrato selecionado
                var selectedRow = dataGridView.SelectedRows[0];
                var contrato = (Contrato)selectedRow.DataBoundItem;

                // Remover o contrato selecionado
                var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contratos.json");
                var json = File.ReadAllText(filePath);
                var contratos = JsonSerializer.Deserialize<List<Contrato>>(json);
                if (contratos != null)
                {
                    contratos.RemoveAll(c => c.IdImovel == contrato.IdImovel);

                    // Salvar a lista atualizada de contratos
                    json = JsonSerializer.Serialize(contratos, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(filePath, json);

                    // Recarregar dados após remover o contrato
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Selecione um contrato para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public class Contrato
    {
        public string IdImovel { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;
        public DateTime DataCessacao { get; set; }
    }
}

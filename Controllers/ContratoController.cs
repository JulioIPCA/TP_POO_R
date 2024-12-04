using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace TP_POO_R.ViewsAdicionar
{
    public class ContratoController
    {
        private readonly DataGridView? _dataGridView;
        private readonly string _filePath;

        public ContratoController(DataGridView? dataGridView = null)
        {
            _dataGridView = dataGridView;
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contratos.json");
        }

        public void LoadData()
        {
            if (_dataGridView == null) return;

            if (File.Exists(_filePath))
            {
                try
                {
                    var json = File.ReadAllText(_filePath);
                    var contratos = JsonSerializer.Deserialize<List<Contrato>>(json) ?? new List<Contrato>();
                    _dataGridView.DataSource = contratos;
                }
                catch (JsonException ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _dataGridView.DataSource = new List<Contrato>();
                }
            }
            else
            {
                _dataGridView.DataSource = new List<Contrato>();
            }
        }

        public void RemoveSelectedContrato()
        {
            if (_dataGridView == null || _dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um contrato para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = _dataGridView.SelectedRows[0];
            var contrato = (Contrato)selectedRow.DataBoundItem;

            var json = File.ReadAllText(_filePath);
            var contratos = JsonSerializer.Deserialize<List<Contrato>>(json);
            if (contratos != null)
            {
                contratos.RemoveAll(c => c.IdImovel == contrato.IdImovel);

                json = JsonSerializer.Serialize(contratos, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);

                LoadData();
            }
        }

        public void AddContrato(Contrato contrato)
        {
            List<Contrato> contratos;
            if (File.Exists(_filePath))
            {
                var existingJson = File.ReadAllText(_filePath);
                contratos = JsonSerializer.Deserialize<List<Contrato>>(existingJson) ?? new List<Contrato>();
            }
            else
            {
                contratos = new List<Contrato>();
            }

            contratos.Add(contrato);

            var json = JsonSerializer.Serialize(contratos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}

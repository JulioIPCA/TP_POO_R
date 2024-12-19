using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TP_POO_R.Models;
using TP_POO_R.ViewsAdicionar;

public class ContratoController
{
    private readonly DataGridView _dataGridView;
    private readonly string _filePath;

    public ContratoController(DataGridView dataGridView)
    {
        _dataGridView = dataGridView;
        _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contratos.json");
    }

    public void LoadData()
    {
        var contratos = GetContratosFromDataSource();
        _dataGridView.DataSource = contratos;
    }

    public void AddContrato(Contrato contrato)
    {
        var contratos = GetContratosFromDataSource();
        contratos.Add(contrato);
        SaveContratosToDataSource(contratos);
        LoadData(); // Refresh the data after adding
    }

    public void RemoveSelectedContrato()
    {
        if (_dataGridView.SelectedRows.Count > 0)
        {
            var contratos = GetContratosFromDataSource();
            var selectedContrato = (Contrato)_dataGridView.SelectedRows[0].DataBoundItem;
            var contratoToRemove = contratos.FirstOrDefault(c => c.IdInquilino == selectedContrato.IdInquilino && c.Data == selectedContrato.Data);
            if (contratoToRemove != null)
            {
                contratos.Remove(contratoToRemove);
                SaveContratosToDataSource(contratos);
                LoadData(); // Refresh the data after removal
            }
        }
        else
        {
            MessageBox.Show("Por favor, selecione um contrato para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private List<Contrato> GetContratosFromDataSource()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            if (!string.IsNullOrWhiteSpace(json))
            {
                return JsonSerializer.Deserialize<List<Contrato>>(json) ?? new List<Contrato>();
            }
        }
        return new List<Contrato>();
    }

    private void SaveContratosToDataSource(List<Contrato> contratos)
    {
        var json = JsonSerializer.Serialize(contratos);
        File.WriteAllText(_filePath, json);
    }
}

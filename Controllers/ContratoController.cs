using System.Text.Json;
using TP_POO_R.ViewsAdicionar;

public class ContratoController
{
    private readonly DataGridView _dataGridView;
    private readonly string _filePath;

    // Construtor-inicializa o DataGridView e o caminho do arquivo JSON
    public ContratoController(DataGridView dataGridView)
    {
        _dataGridView = dataGridView;
        _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contratos.json");
    }

    // Carrega os dados dos contratos no DataGridView
    public void LoadData()
    {
        var contratos = GetContratosFromDataSource();
        _dataGridView.DataSource = contratos;
    }

    // Adiciona um novo contrato
    public void AddContrato(Contrato contrato)
    {
        var contratos = GetContratosFromDataSource();

        // Verifica se o inquilino já tem algum contrato atribuido
        if (InquilinoJaPossuiContrato(contrato.IdInquilino, contratos))
        {
            MessageBox.Show("O inquilino selecionado já possui um contrato.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Define o próximo ID para o novo contrato criado
        contrato.IdContrato = GetNextId(contratos);
        contratos.Add(contrato);
        SaveContratosToDataSource(contratos);
        LoadData(); // Atualiza os dados após adicionar
    }

    // Remove o contrato selecionado
    public void RemoveSelectedContrato()
    {
        if (_dataGridView.SelectedRows.Count > 0)
        {
            var contratos = GetContratosFromDataSource();
            var selectedContrato = (Contrato)_dataGridView.SelectedRows[0].DataBoundItem;
            var contratoToRemove = contratos.FirstOrDefault(c => c.IdContrato == selectedContrato.IdContrato);
            if (contratoToRemove != null)
            {
                contratos.Remove(contratoToRemove);
                SaveContratosToDataSource(contratos);
                LoadData(); // Atualiza os dados após remover
            }
        }
        else
        {
            MessageBox.Show("Por favor, selecione um contrato para remover.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Retorna a lista de contratos
    public List<Contrato> GetContratos()
    {
        return GetContratosFromDataSource();
    }

    // Verifica se o inquilino já possui um contrato
    public bool InquilinoJaPossuiContrato(string idInquilino, List<Contrato> contratos)
    {
        return contratos.Any(c => c.IdInquilino == idInquilino);
    }

    // Obtém os contratos da fonte de dados (arquivo JSON)
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

    // Salva os contratos na fonte de dados (arquivo JSON)
    private void SaveContratosToDataSource(List<Contrato> contratos)
    {
        var json = JsonSerializer.Serialize(contratos);
        File.WriteAllText(_filePath, json);
    }

    // Obtém o próximo ID disponível para um novo contrato
    private int GetNextId(List<Contrato> contratos)
    {
        if (contratos.Count == 0)
        {
            return 1;
        }

        var existingIds = contratos.Select(c => c.IdContrato).OrderBy(id => id).ToList();
        for (int i = 1; i <= existingIds.Count; i++)
        {
            if (existingIds[i - 1] != i)
            {
                return i;
            }
        }
        return existingIds.Count + 1;
    }
}


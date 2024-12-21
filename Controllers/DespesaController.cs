using System.Text.Json;
using TP_POO_R.Models;

namespace TP_POO_R.Controllers
{
    public class DespesaController
    {
        private List<Despesa> _despesas; // Lista de despesas
        private readonly string _filePath; // Caminho do arquivo JSON

        public DespesaController()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "despesas.json");
            _despesas = LoadDespesasFromFile(); // Carrega as despesas do arquivo
        }

        // Carrega as despesas e utiliza a propriedade ValorTotal de cada despesa
        public List<dynamic> LoadDespesas()
        {
            return _despesas.Select(d => new
            {
                d.IdInquilino,
                d.Data,
                d.Descricao,
                d.ValorLuz,
                d.ValorGas,
                d.ValorAgua,
                d.ValorTotal // Utiliza a propriedade ValorTotal da classe Despesa
            }).Cast<dynamic>().ToList();
        }

        // Adiciona uma nova despesa
        public void AddDespesa(Despesa novaDespesa)
        {
            _despesas.Add(novaDespesa);
            SaveDespesasToFile(); // Salva as despesas no arquivo
        }

        // Remove uma despesa pelo índice
        public void RemoveDespesa(int index)
        {
            if (index >= 0 && index < _despesas.Count)
            {
                _despesas.RemoveAt(index);
                SaveDespesasToFile(); // Salva as despesas no arquivo após a remoção
            }
        }

        // Carrega as despesas do arquivo JSON
        private List<Despesa> LoadDespesasFromFile()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    var json = File.ReadAllText(_filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        return JsonSerializer.Deserialize<List<Despesa>>(json) ?? new List<Despesa>();
                    }
                }
                catch (JsonException)
                {
                    // Tratar exceção
                }
            }
            return new List<Despesa>();
        }

        // Salva as despesas no arquivo JSON
        private void SaveDespesasToFile()
        {
            var json = JsonSerializer.Serialize(_despesas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}

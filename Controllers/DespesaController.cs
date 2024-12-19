
using System.Text.Json;
using TP_POO_R.Models;

namespace TP_POO_R.Controllers
{
    public class DespesaController
    {
        private List<Despesa> _despesas;
        private readonly string _filePath;

        public DespesaController()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "despesas.json");
            _despesas = LoadDespesasFromFile();
        }

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
                ValorTotal = d.ValorLuz + d.ValorGas + d.ValorAgua
            }).Cast<dynamic>().ToList();
        }

        public void AddDespesa(Despesa novaDespesa)
        {
            _despesas.Add(novaDespesa);
            SaveDespesasToFile();
        }

        public void RemoveDespesa(int index)
        {
            if (index >= 0 && index < _despesas.Count)
            {
                _despesas.RemoveAt(index);
                SaveDespesasToFile();
            }
        }

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
                    // Handle exception
                }
            }
            return new List<Despesa>();
        }

        private void SaveDespesasToFile()
        {
            var json = JsonSerializer.Serialize(_despesas, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}
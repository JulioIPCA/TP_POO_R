using System.Text.Json;
using TP_POO_R.Models;

namespace TP_POO_R.Controllers
{
    public class ImovelController
    {
        private readonly string _filePath;

        public ImovelController()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imoveis.json");
        }

        public List<Imovel> CarregarImoveis()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    var json = File.ReadAllText(_filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        return JsonSerializer.Deserialize<List<Imovel>>(json) ?? new List<Imovel>();
                    }
                }
                catch (JsonException ex)
                {
                    throw new Exception($"Erro ao carregar dados: {ex.Message}");
                }
            }
            return new List<Imovel>();
        }

        public void SalvarImoveis(List<Imovel> imoveis)
        {
            var json = JsonSerializer.Serialize(imoveis, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}

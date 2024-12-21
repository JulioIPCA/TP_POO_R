using System.Text.Json;
using TP_POO_R.Models; // Certifique-se de que este namespace está correto
using System.IO;
using System;
using System.Collections.Generic;

namespace TP_POO_R.Controllers
{
    public class ImovelController
    {
        private readonly string _filePath; // Caminho do arquivo JSON

        public ImovelController()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "imoveis.json");
        }

        // Carrega os imóveis do arquivo JSON
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

        // Salva os imóveis no arquivo JSON
        public void SalvarImoveis(List<Imovel> imoveis)
        {
            var json = JsonSerializer.Serialize(imoveis, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        // Método para obter todos os imóveis, chamando CarregarImoveis
        public List<Imovel> ObterTodosImoveis()
        {
            return CarregarImoveis();
        }
    }
}

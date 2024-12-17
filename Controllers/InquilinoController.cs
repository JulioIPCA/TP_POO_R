using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using TP_POO_R.Models;

namespace TP_POO_R.Controllers
{
    public class InquilinoController
    {
        private readonly string _filePath;

        public InquilinoController()
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "inquilinos.json");
        }

        public List<Inquilino> GetInquilinos()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    var json = File.ReadAllText(_filePath);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        return JsonSerializer.Deserialize<List<Inquilino>>(json) ?? new List<Inquilino>();
                    }
                }
                catch (JsonException ex)
                {
                    // Registrar o erro
                    Console.WriteLine($"Erro ao desserializar o arquivo JSON: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Registrar outros erros
                    Console.WriteLine($"Erro ao ler o arquivo JSON: {ex.Message}");
                }
            }
            return new List<Inquilino>();
        }

        public void AdicionarInquilino(Inquilino inquilino)
        {
            var inquilinos = GetInquilinos();
            inquilinos.Add(inquilino);
            SalvarInquilinos(inquilinos);
        }

        public void RemoverInquilino(int id)
        {
            var inquilinos = GetInquilinos();
            inquilinos.RemoveAll(i => i.Id == id);
            SalvarInquilinos(inquilinos);
        }

        private void SalvarInquilinos(List<Inquilino> inquilinos)
        {
            var json = JsonSerializer.Serialize(inquilinos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }
    }
}


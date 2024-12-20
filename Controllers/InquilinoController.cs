using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
                    // Log the error
                    Console.WriteLine($"Error deserializing JSON file: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Log other errors
                    Console.WriteLine($"Error reading JSON file: {ex.Message}");
                }
            }
            return new List<Inquilino>();
        }

        public void AdicionarInquilino(Inquilino inquilino)
        {
            var inquilinos = GetInquilinos();
            inquilino.Id = GetProximoId(inquilinos);
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

        private int GetProximoId(List<Inquilino> inquilinos)
        {
            if (inquilinos.Count == 0)
            {
                return 1;
            }

            var idsExistentes = inquilinos.Select(i => i.Id).ToList();
            idsExistentes.Sort();

            for (int i = 1; i <= idsExistentes.Count; i++)
            {
                if (!idsExistentes.Contains(i))
                {
                    return i;
                }
            }

            return idsExistentes.Max() + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GestaoRendasImoveis.Models;

namespace GestaoRendasImoveis.Controllers
{
    public class DespesaController
    {
        private List<Despesa> despesas = new List<Despesa>();
        private readonly string filePath = "despesas.json";

        public void AdicionarDespesa(Despesa despesa)
        {
            despesas.Add(despesa);
            SalvarDespesas();
        }

        public List<Despesa> ObterDespesas()
        {
            return despesas;
        }

        public void SalvarDespesas()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(despesas, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void CarregarDespesas()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                despesas = JsonSerializer.Deserialize<List<Despesa>>(jsonString);
            }
        }
    }
}
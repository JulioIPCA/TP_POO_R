using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using GestaoRendasImoveis.Models;

namespace GestaoRendasImoveis.Controllers
{
    public class ReciboController
    {
        private List<Recibo> recibos = new List<Recibo>();
        private readonly string filePath = "recibos.json";

        public ReciboController()
        {
            CarregarRecibos();
        }

        public bool AdicionarRecibo(Recibo recibo)
        {
            recibos.Add(recibo);
            SalvarRecibos();
            return recibos.Contains(recibo);
        }

        public List<Recibo> ObterRecibos()
        {
            return recibos;
        }

        public void SalvarRecibos()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(recibos, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void CarregarRecibos()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                recibos = JsonSerializer.Deserialize<List<Recibo>>(jsonString);
            }
        }

        public List<Recibo> ObterTodosRecibos()
        {
            return recibos;
        }
    }
}

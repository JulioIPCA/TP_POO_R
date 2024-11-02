using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using GestaoRendasImoveis.Models;

namespace GestaoRendasImoveis.Controllers
{
    public class ContratoController
    {
        private List<Contrato> contratos = new List<Contrato>();
        private readonly string filePath = "contratos.json";

        public ContratoController()
        {
            CarregarContratos();
        }

        public bool AdicionarContrato(Contrato contrato)
        {
            contratos.Add(contrato);
            SalvarContratos();
            return contratos.Contains(contrato);
        }

        public List<Contrato> ObterContratos()
        {
            return contratos;
        }

        public void SalvarContratos()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            string jsonString = JsonSerializer.Serialize(contratos, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void CarregarContratos()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                contratos = JsonSerializer.Deserialize<List<Contrato>>(jsonString);
            }
        }

        public List<Contrato> ObterTodosContratos()
        {
            // Retornar a lista de contratos carregada do arquivo JSON
            return contratos;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using GestaoRendasImoveis.Models;

namespace GestaoRendasImoveis.Controllers
{
    public class ImovelController
    {
        private List<Imovel> imoveis = new List<Imovel>();
        private readonly string filePath = "imoveis.json";

        public ImovelController()
        {
            CarregarImoveis();
        }

        public bool AdicionarImovel(Imovel imovel)
        {
            imoveis.Add(imovel);
            SalvarImoveis();
            return imoveis.Contains(imovel);
        }

        public List<Imovel> ObterImoveis()
        {
            return imoveis;
        }

        public void SalvarImoveis()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            string jsonString = JsonSerializer.Serialize(imoveis, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void CarregarImoveis()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                imoveis = JsonSerializer.Deserialize<List<Imovel>>(jsonString);
            }
        }
    }
}

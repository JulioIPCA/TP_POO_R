using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using GestaoRendasImoveis.Models;

namespace GestaoRendasImoveis.Controllers
{
    public class InquilinoController
    {
        private List<Inquilino> inquilinos = new List<Inquilino>();
        private readonly string filePath = "inquilinos.json";

        public InquilinoController()
        {
            CarregarInquilinos();
        }

        public bool AdicionarInquilino(Inquilino inquilino)
        {
            inquilinos.Add(inquilino);
            SalvarInquilinos();
            return inquilinos.Contains(inquilino);
        }

        public List<Inquilino> ObterInquilinos()
        {
            return inquilinos;
        }

        public void SalvarInquilinos()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            string jsonString = JsonSerializer.Serialize(inquilinos, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void CarregarInquilinos()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                inquilinos = JsonSerializer.Deserialize<List<Inquilino>>(jsonString);
            }
        }
    }
}

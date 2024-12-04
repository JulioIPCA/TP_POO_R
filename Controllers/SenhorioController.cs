
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using GestaoRendasImoveis.Models;

namespace GestaoRendasImoveis.Controllers
{
    public class SenhorioController
    {
        private List<Senhorio> senhorios = new List<Senhorio>();
        private readonly string filePath = "senhorios.json";

        public SenhorioController()
        {
            CarregarSenhorios();
        }

        public bool AdicionarSenhorio(Senhorio senhorio)
        {
            senhorios.Add(senhorio);
            SalvarSenhorios();
            return senhorios.Contains(senhorio);
        }

        public List<Senhorio> ObterSenhorios()
        {
            return senhorios;
        }

        public void SalvarSenhorios()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            };
            string jsonString = JsonSerializer.Serialize(senhorios, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void CarregarSenhorios()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                senhorios = JsonSerializer.Deserialize<List<Senhorio>>(jsonString);
            }
        }
    }
}
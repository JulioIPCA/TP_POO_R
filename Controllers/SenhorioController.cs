using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace TP_POO_R.Models
{
    public class SenhorioController
    {
        private List<Senhorio> senhorios = new List<Senhorio>();
        private readonly string filePath = "senhorios.json";

        public SenhorioController()
        {
            CarregarSenhorios();
        }

        // Adiciona um novo senhorio
        public bool AdicionarSenhorio(Senhorio senhorio)
        {
            senhorio.Id = senhorios.Count > 0 ? senhorios[^1].Id + 1 : 1;
            senhorios.Add(senhorio);
            SalvarSenhorios();
            CarregarSenhorios(); // Recarregar os dados após adicionar um novo senhorio
            return senhorios.Contains(senhorio);
        }

        // Autentica um senhorio com base no NIF e senha
        public bool AutenticarSenhorio(string nif, string password)
        {
            foreach (var senhorio in senhorios)
            {
                if (senhorio.NIF == nif && senhorio.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        // Obtém a lista de senhorios
        public List<Senhorio> ObterSenhorios()
        {
            return senhorios;
        }

        // Salva a lista de senhorios no arquivo JSON
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

        // Carrega a lista de senhorios do arquivo JSON
        public void CarregarSenhorios()
        {
            senhorios.Clear(); // Limpar a lista antes de recarregar
            if (File.Exists(filePath))
            {
                try
                {
                    string jsonString = File.ReadAllText(filePath);
                    if (!string.IsNullOrWhiteSpace(jsonString))
                    {
                        var deserializedSenhorios = JsonSerializer.Deserialize<List<Senhorio>>(jsonString);
                        if (deserializedSenhorios != null)
                        {
                            foreach (var senhorio in deserializedSenhorios)
                            {
                                if (senhorio.NIF.Length == 9 && long.TryParse(senhorio.NIF, out _))
                                {
                                    senhorios.Add(senhorio);
                                }
                                else
                                {
                                    Console.WriteLine($"NIF inválido encontrado: {senhorio.NIF}");
                                }
                            }
                        }
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
        }
    }
}

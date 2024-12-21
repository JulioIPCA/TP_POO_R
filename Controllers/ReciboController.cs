using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TP_POO_R.Models;

public class ReciboController
{
    private readonly string _filePath; // Caminho do arquivo JSON
    private readonly ContratoController _contratoController;

    public ReciboController(DataGridView dataGridView)
    {
        _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recibos.json");
        _contratoController = new ContratoController(dataGridView);
    }

    // Obtém a lista de recibos do arquivo JSON
    public List<Recibo> GetRecibos()
    {
        if (File.Exists(_filePath))
        {
            var json = File.ReadAllText(_filePath);
            if (!string.IsNullOrWhiteSpace(json))
            {
                return JsonSerializer.Deserialize<List<Recibo>>(json) ?? new List<Recibo>();
            }
        }
        return new List<Recibo>();
    }

    // Adiciona um novo recibo
    public void AdicionarRecibo(Recibo recibo)
    {
        var recibos = GetRecibos();

        // Encontra o contrato associado ao recibo
        var contrato = _contratoController.GetContratos().FirstOrDefault(c => c.IdContrato == recibo.IdContrato);
        if (contrato != null)
        {
            // Converte o valor do contrato para decimal e atribui ao recibo
            if (decimal.TryParse(contrato.Valor, out decimal valorContrato))
            {
                recibo.Valor = valorContrato;
            }
            else
            {
                MessageBox.Show("O valor do contrato é inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        recibo.IdRecibo = GetProximoId(recibos);
        recibos.Add(recibo);
        SalvarRecibos(recibos);
    }

    // Remove um recibo pelo ID
    public void RemoverRecibo(int id)
    {
        var recibos = GetRecibos();
        recibos.RemoveAll(r => r.IdRecibo == id);
        SalvarRecibos(recibos);
    }

    // Salva a lista de recibos no arquivo JSON
    private void SalvarRecibos(List<Recibo> recibos)
    {
        var json = JsonSerializer.Serialize(recibos, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
    }

    // Obtém o próximo ID disponível para um novo recibo
    private int GetProximoId(List<Recibo> recibos)
    {
        if (recibos.Count == 0)
        {
            return 1;
        }

        var idsExistentes = recibos.Select(r => r.IdRecibo).ToList();
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

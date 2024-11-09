using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRendasImoveis.Models
{
   public class Imovel
{
    public string IdImovel { get; set; } = string.Empty;
    public string ProprietarioId { get; set; } = string.Empty;
    public string Tipo { get; set; } = string.Empty;
    public string Endereco { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public decimal RendaMensal { get; set; }
}
}
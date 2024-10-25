using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRendasImoveis.Models
{
    public class Imovel
    {
        public int ProprietarioId { get; set; }
        public string Tipo { get; set; } // Apartamento, Vivenda, Terreno
        public string Endereco { get; set; }
        public decimal Valor { get; set; } // Disponível, Alugado, etc.
        public decimal RendaMensal { get; set; }
    }
}
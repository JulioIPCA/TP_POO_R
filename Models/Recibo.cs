using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRendasImoveis.Models
{
    public class Recibo
    {
        public string Descricao { get; set; }
        public int ImovelId { get; set; }
        public int InquilinoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoRendasImoveis.Models
{
    public class Contrato
    {
        public int Id { get; set; }
        public int ImovelId { get; set; }
        public int InquilinoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
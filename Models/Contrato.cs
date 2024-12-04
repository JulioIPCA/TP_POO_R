using System;

namespace TP_POO_R.ViewsAdicionar
{
    public class Contrato
    {
        public string IdImovel { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Valor { get; set; } = string.Empty;
        public DateTime DataCessacao { get; set; }
    }
}

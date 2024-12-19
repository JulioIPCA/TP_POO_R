namespace TP_POO_R.Models
{
    public class Imovel
    {
        public int IdImovel { get; set; }
        public string Tipo { get; set; } = string.Empty; // Inicializar como string vazia
        public string Endereco { get; set; } = string.Empty; // Inicializar como string vazia
        public decimal NQuartos { get; set; }
    }
}

namespace TP_POO_R.Models
{
    public class Recibo
    {
        public int IdRecibo { get; set; }
        public string Descricao { get; set; } = string.Empty; // Inicialização com valor padrão
        public int ImovelId { get; set; }
        public int InquilinoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
namespace TP_POO_R.Models
{
    public class Despesa
    {
        public int IdInquilino { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; } = string.Empty; // Inicializar como string vazia
        public decimal ValorLuz { get; set; }
        public decimal ValorGas { get; set; }
        public decimal ValorAgua { get; set; }
        public decimal ValorTotal
        {
            get
            {
                return ValorLuz + ValorGas + ValorAgua;
            }
        }
    }
}
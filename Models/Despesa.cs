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

        // Método para validar a despesa
        public bool Validar()
        {
            if (IdInquilino <= 0)
                return false;
            if (ValorLuz < 0 || ValorGas < 0 || ValorAgua < 0)
                return false;
            if (string.IsNullOrWhiteSpace(Descricao))
                return false;
            return true;
        }

        // Método para criar uma despesa a partir dos dados do formulário
        public static Despesa CriarDespesa(int idInquilino, DateTime data, string descricao, decimal valorLuz, decimal valorGas, decimal valorAgua)
        {
            return new Despesa
            {
                IdInquilino = idInquilino,
                Data = data,
                Descricao = descricao,
                ValorLuz = valorLuz,
                ValorGas = valorGas,
                ValorAgua = valorAgua
            };
        }
    }
}

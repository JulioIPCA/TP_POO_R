namespace TP_POO_R.ViewsAdicionar
{
    public class Contrato
    {
        public int IdContrato { get; set; }
        public string IdInquilino { get; set; } = string.Empty;
        public DateTime Data { get; set; }
        public string Valor { get; set; } = string.Empty;
        public DateTime DataCessacao { get; set; }

        // Método para validar o contrato
        public bool Validar()
        {
            if (!ValidarDatas())
            {
                Console.WriteLine("Validação falhou: Data de início é maior que a data de cessação.");
                return false;
            }

            if (!ValidarValor())
            {
                Console.WriteLine("Validação falhou: Valor inválido.");
                return false;
            }

            return true;
        }

        // Método para validar as datas
        private bool ValidarDatas()
        {
            return Data <= DataCessacao;
        }

        // Método para validar o valor
        private bool ValidarValor()
        {
            return decimal.TryParse(Valor, out _);
        }

        // Método para calcular a duração do contrato
        public int CalcularDuracao()
        {
            return (DataCessacao - Data).Days;
        }

        // Método para exibir informações do contrato
        public string ExibirInformacoes()
        {
            return $"Contrato: Inquilino: {IdInquilino}, Valor: {Valor}, Duração: {CalcularDuracao()} dias";
        }
    }
}

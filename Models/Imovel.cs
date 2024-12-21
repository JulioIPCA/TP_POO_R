namespace TP_POO_R.Models
{
    public class Imovel
    {
        private static int _nextIdImovel = 1; // Variável estática para gerar IDs sequenciais

        public int IdImovel { get; private set; } // Propriedade para armazenar o ID do imóvel
        public string Tipo { get; set; } = string.Empty; 
        public string Endereco { get; set; } = string.Empty; // Endereço do imóvel, inicializado como string vazia
        public decimal NQuartos { get; set; } 

        // Construtor padrão que gera um novo ID para o imóvel
        public Imovel()
        {
            IdImovel = GerarNovoIdImovel();
        }

        // Construtor que inicializa as propriedades com valores fornecidos
        public Imovel(string tipo, string endereco, decimal nQuartos)
        {
            IdImovel = GerarNovoIdImovel();
            Tipo = tipo;
            Endereco = endereco;
            NQuartos = nQuartos;
        }

        // Método para validar se os campos obrigatórios estão preenchidos corretamente
        public bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(Tipo) &&
                   !string.IsNullOrWhiteSpace(Endereco) &&
                   NQuartos > 0;
        }

        // Método privado para gerar um novo ID sequencial para o imóvel
        private int GerarNovoIdImovel()
        {
            return _nextIdImovel++; // Incrementa o ID para o próximo imóvel
        }

        // Método para definir manualmente o ID do imóvel
        public void SetIdImovel(int id)
        {
            IdImovel = id;
        }
    }
}

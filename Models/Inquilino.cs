namespace TP_POO_R.Models
{
    public class Inquilino : Pessoa
    {
        private string _nif = string.Empty;

        public string NIF
        {
            get => _nif;
            set
            {
                if (value.Length != 9 || !long.TryParse(value, out _))
                {
                    throw new ArgumentException("O NIF deve ter exatamente 9 dígitos.");
                }
                _nif = value;
            }
        }

        public int IdImovel { get; set; }
        public new string Nome { get; set; } = string.Empty; // Inicializar como string vazia e usar 'new' para ocultar o membro herdado
        public new string Telefone { get; set; } = string.Empty; // Inicializar como string vazia e usar 'new' para ocultar o membro herdado

        // Método para validar os campos do inquilino
        public bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(Nome) &&
                   !string.IsNullOrWhiteSpace(NIF) &&
                   !string.IsNullOrWhiteSpace(Telefone) &&
                   IdImovel > 0;
        }

        // Método para associar um imóvel ao inquilino
        public void AssociarImovel(int idImovel)
        {
            if (idImovel <= 0)
            {
                throw new ArgumentException("O ID do imóvel deve ser um número positivo.");
            }
            IdImovel = idImovel;
        }
    }
}

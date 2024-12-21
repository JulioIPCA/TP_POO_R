namespace TP_POO_R.Models
{
    public class Senhorio : Pessoa
    {
        private string _nif = string.Empty; // Campo privado para armazenar o NIF

        // Propriedade para acessar e definir o NIF
        public string NIF
        {
            get => _nif;
            set
            {
                // Validação para garantir que o NIF tem 9 dígitos e é numérico
                if (value.Length != 9 || !long.TryParse(value, out _))
                {
                    throw new ArgumentException("O NIF tem de ter 9 Números.");
                }
                _nif = value;
            }
        }

        // Propriedade para armazenar a senha do senhorio
        public string Password { get; set; } = string.Empty;
    }
}

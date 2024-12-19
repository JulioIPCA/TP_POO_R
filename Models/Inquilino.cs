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
    }
}

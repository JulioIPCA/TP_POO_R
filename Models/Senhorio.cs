
namespace TP_POO_R.Models
{
    public class Senhorio : Pessoa  
    {
        private string _nif = string.Empty;

        public string NIF
        {
            get => _nif;
            set
            {
                if (value.Length != 9 || !long.TryParse(value, out _))
                {
                    throw new ArgumentException("O NIF tem de ter 9 Números.");
                }
                _nif = value;
            }
        }
        public string Password { get; set; } = string.Empty;
    }
}
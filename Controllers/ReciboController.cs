
using TP_POO_R.Models;

namespace TP_POO_R.Controllers
{
    public class ReciboController
    {
        private List<Recibo> _recibos;

        public ReciboController()
        {
            _recibos = new List<Recibo>();
        }

        public Recibo CriarRecibo(int idRecibo, string descricao, int imovelId, int inquilinoId, decimal valor, DateTime data)
        {
            // Validação básica
            if (string.IsNullOrWhiteSpace(descricao) || imovelId <= 0 || inquilinoId <= 0 || valor <= 0 || data == default)
            {
                throw new ArgumentException("Todos os campos devem ser preenchidos corretamente.");
            }

            // Criar um novo recibo
            var recibo = new Recibo
            {
                IdRecibo = idRecibo,
                Descricao = descricao,
                ImovelId = imovelId,
                InquilinoId = inquilinoId,
                Valor = valor,
                Data = data
            };

            _recibos.Add(recibo);
            return recibo;
        }

        public List<Recibo> GetRecibos()
        {
            return _recibos;
        }

        public void AdicionarRecibo(Recibo recibo)
        {
            _recibos.Add(recibo);
        }

        public void RemoverRecibo(int idRecibo)
        {
            var recibo = _recibos.Find(r => r.IdRecibo == idRecibo);
            if (recibo != null)
            {
                _recibos.Remove(recibo);
            }
        }
    }
}

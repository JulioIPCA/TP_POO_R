using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestaoRendasImoveis.Models;
using System.Collections.Generic;


namespace GestaoRendasImoveis.Controllers
{
    public class ReciboController
    {
        private List<Recibo> recibos = new List<Recibo>();

        public void AdicionarRecibo(Recibo recibo)
        {
            recibos.Add(recibo);
        }

        public List<Recibo> ObterRecibos()
        {
            return recibos;
        }
    }
}
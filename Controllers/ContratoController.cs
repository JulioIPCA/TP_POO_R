using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestaoRendasImoveis.Models;
using System.Collections.Generic;


namespace GestaoRendasImoveis.Controllers
{
    public class ContratoController
    {
        private List<Contrato> contratos = new List<Contrato>();

        public void AdicionarContrato(Contrato contrato)
        {
            contratos.Add(contrato);
        }

        public List<Contrato> ObterContratos()
        {
            return contratos;
        }
    }
}
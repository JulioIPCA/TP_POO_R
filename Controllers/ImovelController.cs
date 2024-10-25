using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestaoRendasImoveis.Models;
using System.Collections.Generic;


namespace GestaoRendasImoveis.Controllers
{
    public class ImovelController
    {
        private List<Imovel> imoveis = new List<Imovel>();

        public void AdicionarImovel(Imovel imovel)
        {
            imoveis.Add(imovel);
        }

        public List<Imovel> ObterImoveis()
        {
            return imoveis;
        }
    }
}

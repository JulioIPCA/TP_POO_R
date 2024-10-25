using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestaoRendasImoveis.Models;
using System.Collections.Generic;

namespace GestaoRendasImoveis.Controllers
{
    public class InquilinoController
    {
        private List<Inquilino> inquilinos = new List<Inquilino>();

        public void AdicionarInquilino(Inquilino inquilino)
        {
            inquilinos.Add(inquilino);
        }

        public List<Inquilino> ObterInquilinos()
        {
            return inquilinos;
        }
    }
}
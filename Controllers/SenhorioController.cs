using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestaoRendasImoveis.Models;


namespace GestaoRendasImoveis.Controllers
{
    public class SenhorioController
    {
        private List<Senhorio> senhorios = new List<Senhorio>();

        public void AdicionarSenhorio(Senhorio senhorio)
        {
            senhorios.Add(senhorio);
        }

        public List<Senhorio> ObterSenhorios()
        {
            return senhorios;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GestaoRendasImoveis.Models;
using System.Collections.Generic;


namespace GestaoRendasImoveis.Controllers
{
    public class DespesaController
    {
        private List<Despesa> despesas = new List<Despesa>();

        public void AdicionarDespesa(Despesa despesa)
        {
            despesas.Add(despesa);
        }

        public List<Despesa> ObterDespesas()
        {
            return despesas;
        }
    }
}
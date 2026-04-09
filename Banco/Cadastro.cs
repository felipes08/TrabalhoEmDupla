using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cadastro
    {
        List<Dictionary<DateTime, List<(bool, double)>>> LogsDeLancamentos;

        public Cadastro()
        {
            LogsDeLancamentos = new List<Dictionary<DateTime, List<(bool, double)>>>();
        }

        public void CadastrarLog(Dictionary<DateTime, List<(bool, double)>> dic)
        {
            if(dic != null)
            {
                LogsDeLancamentos.Add(dic);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Cadastro
    {
        public Dictionary<DateTime, double> DicionarioLogsDeLancamentos {  get; set; }

        public Cadastro()
        {
            DicionarioLogsDeLancamentos = new Dictionary<DateTime, double>();
        }

        public void CadastrarLog(Dictionary<DateTime, double> dic)
        {
            foreach(KeyValuePair<DateTime,  double> kvp in dic)
            {
                DicionarioLogsDeLancamentos.Add(kvp.Key, kvp.Value);

            }
            
        }

        
    }
}

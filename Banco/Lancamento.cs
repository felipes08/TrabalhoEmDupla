using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Lancamento
    {
        DateTime data;
        double valor;
        bool operacao;
        Dictionary<DateTime, List<(bool, double)>> RegistroDeOperacao = new Dictionary<DateTime, List<(bool, double)>>();

        public Lancamento(DateTime data, double valor, bool operacao)
        {
            this.data = data;
            this.valor = valor;
            this.operacao = operacao;
        }

        public DateTime getdata()
        {
            return data;
        }

        public double getvalor()
        {
            return valor;
        }

        public bool getoperacao()
        {
            return operacao;
        }

        public Dictionary gerarRegistro()
        {
            List<(valor, operacao)> DictionaryValue;
            RegistroDeOperacao.Add(data, DictionaryValue)
        }
    }
}

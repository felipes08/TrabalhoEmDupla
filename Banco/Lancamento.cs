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
        List<(bool op, double val)> DictionaryValue = new List<(bool op, double val)>();
        Dictionary<DateTime, List<(bool, double)>> DicionarioDaOperacao = new Dictionary<DateTime, List<(bool, double)>>();

        public Lancamento(DateTime data, double valor, bool operacao)
        {
            this.data = data;
            this.valor = valor;
            this.operacao = operacao;

            //criando a lista
            

            //adicionando a operacao e o valor na lista
            DictionaryValue.Add((operacao, valor));

            //adicionando a data como chave e a lista como valor
            DicionarioDaOperacao.Add(data, DictionaryValue);
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

        public Dictionary<DateTime, List<(bool, double)>> getDicionarioDaOperacao()
        {
            return DicionarioDaOperacao;
        }
    }
}

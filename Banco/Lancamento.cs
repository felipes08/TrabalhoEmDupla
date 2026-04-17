using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Lancamento
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public Dictionary<DateTime, double> DicionarioDoLancamento { get; set; }

        public Lancamento(double valor, bool operacao)
        {
            Data = DateTime.Now;
            Valor = (operacao) ? valor: (valor * -1);
            Tipo = (operacao) ? "Depósito" : "Saque";

            DicionarioDoLancamento = new Dictionary<DateTime, double>();
            DicionarioDoLancamento.Add(Data, Valor);
        }
    }
}

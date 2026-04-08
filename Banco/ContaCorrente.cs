using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaCorrente
    {
        double saldoAtual;

        public ContaCorrente()
        {
            saldoAtual = 100;
        }

        public double getSaldoAtual()
        {
            return saldoAtual;
        }

        public bool deposito(double valor)
        {
            if(valor < 50)
            {
                return false;
            }
            else
            {
                saldoAtual += valor;
                return true;
            }
        }
    }
}

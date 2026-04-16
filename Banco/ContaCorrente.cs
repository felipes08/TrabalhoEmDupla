using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente
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
                descontoTarifa();
                return true;
            }
        }

        public bool saque(double valor)
        {
            if(valor < 10)
            {
                return false;
            }
            else if(saldoAtual < valor)
            {
                return false;
            }
            else
            {
                saldoAtual -= valor;
                descontoTarifa();
                return true;
            }
        }
        
        void descontoTarifa()
        {
            saldoAtual -= 0.10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cadastro
    {
        List<(bool operacao, double valor)> DictionaryValue;
        Dictionary<DateTime, List<(bool, double)>> RegistroDeOperacao = new Dictionary<DateTime, List<(bool, double)>>();
    }
}

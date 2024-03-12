using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA04
{
    public abstract class PessoaAcao
    {
        public abstract string ExecutarAcao(PessoaFisica obj);
        public abstract string ExecutarAcao(PessoaJuridica obj);
    }
}
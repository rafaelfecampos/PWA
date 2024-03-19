using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA04
{
    public abstract class Pessoa
    {
        public string Nome { get; set; } = "";

        public abstract string ExecutarAcao(PessoaAcao acao);
    }
}
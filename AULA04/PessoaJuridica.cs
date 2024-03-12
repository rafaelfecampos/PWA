using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA04
{
    public class PessoaJuridica : Pessoa
    {
        public string Contato { get; set; } = "";
        public override string ExecutarAcao(PessoaAcao acao)
        {
            return acao.ExecutarAcao(this);

        }
    }
}
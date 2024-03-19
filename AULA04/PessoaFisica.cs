using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA04
{
    public class PessoaFisica : Pessoa
    {
        public string Filiacao { get; set; } = "";

        public override string ExecutarAcao(PessoaAcao acao)
        {
            return acao.ExecutarAcao(this);
        }
    }
}
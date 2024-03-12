using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AULA04
{
    public class EtiquetaAcao: PessoaAcao
    {
        public string Texto { get; set; } = "";

        public override string ExecutarAcao(PessoaFisica obj)
        {
            return $"{obj.Nome}, Endereço: ...";
        }

        public override string ExecutarAcao(PessoaJuridica obj)
        {
            return $"Aos cuidados de {obj.Contato}. {obj.Nome}, Endereço: ...";
        }
    }
}
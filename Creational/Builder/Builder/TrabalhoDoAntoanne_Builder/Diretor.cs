using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoAntoanne_Builder
{

    internal class Diretor4
    {
        public void Construtor(IConstrutorAbstrato4 ConstrutorAbstrato)
        {
            ConstrutorAbstrato.SetItemPrincipal();
            ConstrutorAbstrato.SetAcompanhamento();
            ConstrutorAbstrato.SetBebida();
            ConstrutorAbstrato.SetBrinde();
        }
    }
}

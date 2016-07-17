using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoDoAntoanne_Builder
{

    internal interface IConstrutorAbstrato4
    {

        void SetItemPrincipal();
        void SetAcompanhamento();
        void SetBebida();
        void SetBrinde();

        Produto4 Produto { get; }
    }
}
